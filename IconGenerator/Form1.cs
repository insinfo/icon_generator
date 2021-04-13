using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CorelDRAW;
using VGCore;
using System.IO;

namespace IconGenerator
{
    public partial class Form1 : Form
    {
        private string correntFolder = null;
        private string correntFile = null;
        private List<IconSize> LauncherIconSizes;
        private List<IconSize> ActionBarIconSizes;
        private List<IconSize> MyCustonLogoIconSizes;
        private int URI_FOLDER_TYPE = 0;
        private int URI_FILE_TYPE = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //correntFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            //correntFolder = @"C:\Users\Isaque\Desktop\Artes\Listaberta\icons\categories\";
            //tbCorrentFolder.Text = correntFolder;

            LauncherIconSizes = new List<IconSize>();
            LauncherIconSizes.Add(new IconSize(48,48, "drawable-mdpi"));
            LauncherIconSizes.Add(new IconSize(72, 72, "drawable-hdpi"));
            LauncherIconSizes.Add(new IconSize(96, 96, "drawable-xhdpi"));
            LauncherIconSizes.Add(new IconSize(144, 144, "drawable-xxhdpi"));
            LauncherIconSizes.Add(new IconSize(192, 192, "drawable-xxxhdpi"));

            ActionBarIconSizes = new List<IconSize>();
            ActionBarIconSizes.Add(new IconSize(32, 32, "drawable-mdpi"));
            ActionBarIconSizes.Add(new IconSize(48, 48, "drawable-hdpi"));
            ActionBarIconSizes.Add(new IconSize(64, 64, "drawable-xhdpi"));
            ActionBarIconSizes.Add(new IconSize(96, 96, "drawable-xxhdpi"));
            ActionBarIconSizes.Add(new IconSize(128, 128, "drawable-xxxhdpi"));

            MyCustonLogoIconSizes = new List<IconSize>();
            MyCustonLogoIconSizes.Add(new IconSize(192, 192, "drawable-mdpi"));
            MyCustonLogoIconSizes.Add(new IconSize(288, 288, "drawable-hdpi"));
            MyCustonLogoIconSizes.Add(new IconSize(384, 384, "drawable-xhdpi"));
            MyCustonLogoIconSizes.Add(new IconSize(576, 576, "drawable-xxhdpi"));
            MyCustonLogoIconSizes.Add(new IconSize(768, 768, "drawable-xxxhdpi"));
        }

        private void btSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
                       
            correntFolder = fbd.SelectedPath;
            tbCorrentFolder.Text = correntFolder;          
        }

        private void brSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.Filter = "Coreldraw files (*.cdr)|*.cdr";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                correntFile = openFileDialog.FileName;
                tbCorrentFolder.Text = correntFile;
               
            }
        }

        private void btGenLisviewIcon_Click(object sender, EventArgs e)
        {
            if (correntFolder == null && correntFile != null)
            {
                genIcon(LauncherIconSizes, correntFile, URI_FILE_TYPE);
            }
            else if (correntFolder != null && correntFile == null)
            {
                genIcon(LauncherIconSizes, correntFolder, URI_FOLDER_TYPE);
            }
        }

        private void btGenIconActionBar_Click(object sender, EventArgs e)
        {
            if (correntFolder == null && correntFile != null)
            {
                genIcon(ActionBarIconSizes, correntFile, URI_FILE_TYPE);
            }
            else if (correntFolder != null && correntFile == null)
            {
                genIcon(ActionBarIconSizes, correntFolder, URI_FOLDER_TYPE);
            }
        }

        private void btGenMyCustonLogo_Click(object sender, EventArgs e)
        {
            if (correntFolder == null && correntFile != null)
            {
                genIcon(MyCustonLogoIconSizes, correntFile, URI_FILE_TYPE);
            }
            else if (correntFolder != null && correntFile == null)
            {
                genIcon(MyCustonLogoIconSizes, correntFolder, URI_FOLDER_TYPE);
            }
        }

        void genIcon(List<IconSize> iconSizes, string uri,int typeURI)
        {
            string folder = "";
            List<TextShape> iconNames = new List<TextShape>(); 
            List<Rect> iconPositions = new List<Rect>();
            List<string> cdrFiles = new List<string>();
            CorelDRAW.Application cdr = new CorelDRAW.Application();

            if (typeURI.Equals(URI_FOLDER_TYPE))
            {
                folder = uri;
                /** Obtem uma lista de todos arquivos da pasta **/
                string[] files = Directory.GetFiles(uri);

                /** cria uma lista contendo apenas arquivos CDR **/
                foreach (string file in files)
                {
                    if (file.Contains(".cdr"))
                    {
                        cdrFiles.Add(file);
                    }
                }
            }
            else if (typeURI.Equals(URI_FILE_TYPE))
            {
                folder = Path.GetDirectoryName(uri);
                if (uri.Contains(".cdr"))
                {
                    cdrFiles.Add(uri);
                }
            }               
           
            /** executa para todos os arquivos CDR da pasta **/
            for (int i = 0; i < cdrFiles.Count; i++)
            {
                string correntFile = cdrFiles[i];
                cdr.OpenDocument(correntFile, 1);
                /** obtem todas as paginas do arquivo atual **/
                CorelDRAW.Pages pages = cdr.ActiveDocument.Pages;
                CorelDRAW.Layers layers;
               // int pageCount = 0;
                /** varre todas as paginas do arquivo atual **/
                foreach (Page correntPage in pages)
                {
                    /** obtem todas as camadas da pagina atual **/
                    layers = correntPage.AllLayers;
                    /** varre todas as camadas de cada pagina **/
                    foreach (Layer correntLayer in layers)
                    {
                        /** verifica se o nome da camada corrent é Camada 1 **/
                        if (correntLayer.Name.Equals("Camada 1"))
                        {
                            CorelDRAW.TreeNode nodes = correntLayer.TreeNode;
                            foreach (CorelDRAW.TreeNode filhos in nodes.Children)
                            {
                                if (filhos.ShapeType.Equals(CorelDRAW.cdrShapeType.cdrTextShape))
                                {
                                    iconNames.Add(new TextShape(filhos.Shape.BoundingBox, filhos.Shape.Text.Contents));
                                }
                                if (filhos.ShapeType.Equals(CorelDRAW.cdrShapeType.cdrRectangleShape))
                                {
                                    iconPositions.Add(filhos.Shape.BoundingBox);                                    
                                }
                            }
                        }
                    }
                    break;
                }

                /** Converte os icones para PNG com o tamanho determinado pela lista de tamanhos de icones **/
                for (int j = 0; j < iconSizes.Count; j++)
                {
                    if (!Directory.Exists(folder + @"\" + iconSizes[j].folderName))
                    {
                        Directory.CreateDirectory(folder + @"\" + iconSizes[j].folderName);
                    }

                    for (int h = 0; h < iconPositions.Count; h++)
                    {
                        string outputFile = "";
                        Rect ExportArea = null;
                       
                        for (int l = 0; l < iconNames.Count; l++)
                        {
                            if (iconNames[l].BoundingBox.x == iconPositions[h].x)
                            {
                                ExportArea = iconPositions[h];
                                outputFile = folder + @"\" + iconSizes[j].folderName + @"\" + iconNames[l].Text.Trim() + ".png";// Path.GetFileNameWithoutExtension(CDRFile)
                                CorelDRAW.cdrFilter filer = CorelDRAW.cdrFilter.cdrPNG;
                                CorelDRAW.cdrExportRange cdrCurrentPage = CorelDRAW.cdrExportRange.cdrCurrentPage;
                                CorelDRAW.cdrImageType cdrRGBColorImage = CorelDRAW.cdrImageType.cdrRGBColorImage;
                                int Width = iconSizes[j].Width;
                                int Height = iconSizes[j].Height;
                                int resolutionX = 72;
                                int resolutionY = 72;
                                CorelDRAW.cdrAntiAliasingType cdrNoAntiAliasing = CorelDRAW.cdrAntiAliasingType.cdrNormalAntiAliasing;
                                bool Dithered = false;
                                bool Transparent = true;
                                bool UseColorProfile = true;
                                bool MaintainLayers = false;
                                CorelDRAW.cdrCompressionType cdrCompressionNone = CorelDRAW.cdrCompressionType.cdrCompressionNone;
                                StructPaletteOptions PaletteOptions = null;
                                
                                cdr.ActiveDocument.ExportBitmap(outputFile, filer, cdrCurrentPage, cdrRGBColorImage,
                                    Width, Height, resolutionX, resolutionY,
                                    cdrNoAntiAliasing,
                                    Dithered,
                                    Transparent,
                                    UseColorProfile,
                                    MaintainLayers,
                                    cdrCompressionNone,
                                    PaletteOptions, ExportArea).Finish();
                            }
                        }
                    }
                }

                cdr.ActiveDocument.Close();
            }
            cdr.Quit();
        }

        private void BtnExtractIcons_Click(object sender, EventArgs e)
        {
            var cts = new CorelToSvg(rtbLogView);
            cts.ExtractIconsToSVG(correntFile);
        }
    }

    public class IconSize
    {
        public int Width;
        public int Height;
        public string folderName;

        public IconSize(int Width, int Height, string folderName)
        {
            this.Width = Width;
            this.Height = Height;
            this.folderName = folderName;
        }
    }

    public class TextShape
    {
        public Rect BoundingBox;       
        public string Text;

        public TextShape(Rect BoundingBox, string Text)
        {
            this.BoundingBox = BoundingBox;           
            this.Text = Text;
        }
    }

   
}
