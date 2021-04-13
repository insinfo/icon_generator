using CorelDRAW;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace IconGenerator
{
    public class CorelToSvg
    {
        RichTextBox rtbLogView;
        public CorelToSvg(RichTextBox rtb)
        {
            rtbLogView = rtb;
        }

        public void ExtractIconsToSVG(string inputFilePath)
        {
            CorelDRAW.Application cdr = new CorelDRAW.Application();
            cdr.OpenDocument(inputFilePath, 1);
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
                          
                            if (filhos.ShapeType.Equals(CorelDRAW.cdrShapeType.cdrCurveShape))
                            {
                                filhos.Shape.Selected = true;
                                var iconName = GenerateSlug(filhos.Shape.Name.Replace('-',' '));
                               
                                var outFile = Path.GetDirectoryName(inputFilePath) + $"/{iconName}.svg";
                                rtbLogView.Text += outFile + "\r\n";
                                var filer = CorelDRAW.cdrFilter.cdrSVG;
                                cdr.ActiveDocument.Export(outFile, filer, CorelDRAW.cdrExportRange.cdrSelection);
                                filhos.Shape.Selected = false;
                            }
                        }
                    }
                }
                break;
            }
        }

        public  string GenerateSlug(string phrase)
        {
            string str = RemoveAccent(phrase).ToLower();
            // invalid chars           
            str = Regex.Replace(str, @"[^a-z0-9\s-]", "");
            // convert multiple spaces into one space   
            str = Regex.Replace(str, @"\s+", " ").Trim();
            // cut and trim 
            str = str.Substring(0, str.Length <= 45 ? str.Length : 45).Trim();
            str = Regex.Replace(str, @"\s", "-"); // hyphens   
            return str;
        }

        public  string RemoveAccent( string txt)
        {
            byte[] bytes = System.Text.Encoding.GetEncoding("Cyrillic").GetBytes(txt);
            return System.Text.Encoding.ASCII.GetString(bytes);
        }

    }

}
