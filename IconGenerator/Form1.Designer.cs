namespace IconGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnExtractIcons = new System.Windows.Forms.Button();
            this.tbCorrentFolder = new System.Windows.Forms.TextBox();
            this.btGenLisviewIcon = new System.Windows.Forms.Button();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btGenMyCustonLogo = new System.Windows.Forms.Button();
            this.btGenIconActionBar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.brSelectFile = new System.Windows.Forms.Button();
            this.btSelectFolder = new System.Windows.Forms.Button();
            this.rtbLogView = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(859, 384);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.rtbLogView);
            this.tabPage1.Controls.Add(this.btnExtractIcons);
            this.tabPage1.Controls.Add(this.tbCorrentFolder);
            this.tabPage1.Controls.Add(this.btGenLisviewIcon);
            this.tabPage1.Controls.Add(this.pbPreview);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.btGenMyCustonLogo);
            this.tabPage1.Controls.Add(this.btGenIconActionBar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(851, 358);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Android";
            // 
            // btnExtractIcons
            // 
            this.btnExtractIcons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExtractIcons.FlatAppearance.BorderSize = 0;
            this.btnExtractIcons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtractIcons.Location = new System.Drawing.Point(571, 6);
            this.btnExtractIcons.Name = "btnExtractIcons";
            this.btnExtractIcons.Size = new System.Drawing.Size(173, 42);
            this.btnExtractIcons.TabIndex = 7;
            this.btnExtractIcons.Text = "Extrair Icones para SVG";
            this.btnExtractIcons.UseVisualStyleBackColor = false;
            this.btnExtractIcons.Click += new System.EventHandler(this.BtnExtractIcons_Click);
            // 
            // tbCorrentFolder
            // 
            this.tbCorrentFolder.BackColor = System.Drawing.Color.Black;
            this.tbCorrentFolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCorrentFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCorrentFolder.ForeColor = System.Drawing.Color.White;
            this.tbCorrentFolder.Location = new System.Drawing.Point(6, 313);
            this.tbCorrentFolder.Name = "tbCorrentFolder";
            this.tbCorrentFolder.Size = new System.Drawing.Size(815, 19);
            this.tbCorrentFolder.TabIndex = 6;
            // 
            // btGenLisviewIcon
            // 
            this.btGenLisviewIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btGenLisviewIcon.FlatAppearance.BorderSize = 0;
            this.btGenLisviewIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGenLisviewIcon.Location = new System.Drawing.Point(6, 6);
            this.btGenLisviewIcon.Name = "btGenLisviewIcon";
            this.btGenLisviewIcon.Size = new System.Drawing.Size(122, 42);
            this.btGenLisviewIcon.TabIndex = 5;
            this.btGenLisviewIcon.Text = "Gerar Launcher icons";
            this.btGenLisviewIcon.UseVisualStyleBackColor = false;
            this.btGenLisviewIcon.Click += new System.EventHandler(this.btGenLisviewIcon_Click);
            // 
            // pbPreview
            // 
            this.pbPreview.BackColor = System.Drawing.Color.DimGray;
            this.pbPreview.Location = new System.Drawing.Point(6, 70);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(276, 237);
            this.pbPreview.TabIndex = 4;
            this.pbPreview.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(390, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 42);
            this.button4.TabIndex = 3;
            this.button4.Text = "Gerar Icone StatusBar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btGenMyCustonLogo
            // 
            this.btGenMyCustonLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btGenMyCustonLogo.FlatAppearance.BorderSize = 0;
            this.btGenMyCustonLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGenMyCustonLogo.Location = new System.Drawing.Point(262, 6);
            this.btGenMyCustonLogo.Name = "btGenMyCustonLogo";
            this.btGenMyCustonLogo.Size = new System.Drawing.Size(122, 42);
            this.btGenMyCustonLogo.TabIndex = 2;
            this.btGenMyCustonLogo.Text = "Gerar MyCustonLogo";
            this.btGenMyCustonLogo.UseVisualStyleBackColor = false;
            this.btGenMyCustonLogo.Click += new System.EventHandler(this.btGenMyCustonLogo_Click);
            // 
            // btGenIconActionBar
            // 
            this.btGenIconActionBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btGenIconActionBar.FlatAppearance.BorderSize = 0;
            this.btGenIconActionBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGenIconActionBar.Location = new System.Drawing.Point(134, 6);
            this.btGenIconActionBar.Name = "btGenIconActionBar";
            this.btGenIconActionBar.Size = new System.Drawing.Size(122, 42);
            this.btGenIconActionBar.TabIndex = 1;
            this.btGenIconActionBar.Text = "Gerar ActionBar icons";
            this.btGenIconActionBar.UseVisualStyleBackColor = false;
            this.btGenIconActionBar.Click += new System.EventHandler(this.btGenIconActionBar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(851, 358);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "IOS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // brSelectFile
            // 
            this.brSelectFile.BackColor = System.Drawing.SystemColors.Highlight;
            this.brSelectFile.FlatAppearance.BorderSize = 0;
            this.brSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brSelectFile.Location = new System.Drawing.Point(12, 8);
            this.brSelectFile.Name = "brSelectFile";
            this.brSelectFile.Size = new System.Drawing.Size(122, 32);
            this.brSelectFile.TabIndex = 6;
            this.brSelectFile.Text = "Selecionar Arquivo";
            this.brSelectFile.UseVisualStyleBackColor = false;
            this.brSelectFile.Click += new System.EventHandler(this.brSelectFile_Click);
            // 
            // btSelectFolder
            // 
            this.btSelectFolder.BackColor = System.Drawing.SystemColors.Highlight;
            this.btSelectFolder.FlatAppearance.BorderSize = 0;
            this.btSelectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSelectFolder.Location = new System.Drawing.Point(140, 8);
            this.btSelectFolder.Name = "btSelectFolder";
            this.btSelectFolder.Size = new System.Drawing.Size(122, 32);
            this.btSelectFolder.TabIndex = 7;
            this.btSelectFolder.Text = "Selecionar Pasta";
            this.btSelectFolder.UseVisualStyleBackColor = false;
            this.btSelectFolder.Click += new System.EventHandler(this.btSelectFolder_Click);
            // 
            // rtbLogView
            // 
            this.rtbLogView.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rtbLogView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLogView.ForeColor = System.Drawing.Color.White;
            this.rtbLogView.Location = new System.Drawing.Point(301, 70);
            this.rtbLogView.Name = "rtbLogView";
            this.rtbLogView.Size = new System.Drawing.Size(507, 237);
            this.rtbLogView.TabIndex = 8;
            this.rtbLogView.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(883, 452);
            this.Controls.Add(this.btSelectFolder);
            this.Controls.Add(this.brSelectFile);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btGenMyCustonLogo;
        private System.Windows.Forms.Button btGenIconActionBar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btGenLisviewIcon;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.Button brSelectFile;
        private System.Windows.Forms.Button btSelectFolder;
        private System.Windows.Forms.TextBox tbCorrentFolder;
        private System.Windows.Forms.Button btnExtractIcons;
        private System.Windows.Forms.RichTextBox rtbLogView;
    }
}

