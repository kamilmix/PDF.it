namespace PDF.it
{
    partial class SplitControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSplit = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonMerge = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonBrowse = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxDestinationFolder = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxSourceFile = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panelSplit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSplit
            // 
            this.panelSplit.Controls.Add(this.button);
            this.panelSplit.Controls.Add(this.textBoxSourceFile);
            this.panelSplit.Controls.Add(this.buttonMerge);
            this.panelSplit.Controls.Add(this.buttonBrowse);
            this.panelSplit.Controls.Add(this.textBoxDestinationFolder);
            this.panelSplit.Controls.Add(this.materialLabel3);
            this.panelSplit.Controls.Add(this.materialLabel2);
            this.panelSplit.Controls.Add(this.materialLabel1);
            this.panelSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSplit.Location = new System.Drawing.Point(0, 0);
            this.panelSplit.Name = "panelSplit";
            this.panelSplit.Size = new System.Drawing.Size(640, 422);
            this.panelSplit.TabIndex = 4;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(21, 9);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(89, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Podziel PDF";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(18, 178);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(89, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Wybierz plik";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(18, 319);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(128, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Katalog docelowy";
            // 
            // buttonMerge
            // 
            this.buttonMerge.Depth = 0;
            this.buttonMerge.Location = new System.Drawing.Point(214, 379);
            this.buttonMerge.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonMerge.Name = "buttonMerge";
            this.buttonMerge.Primary = true;
            this.buttonMerge.Size = new System.Drawing.Size(209, 34);
            this.buttonMerge.TabIndex = 9;
            this.buttonMerge.Text = "Start";
            this.buttonMerge.UseVisualStyleBackColor = true;
            this.buttonMerge.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Depth = 0;
            this.buttonBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBrowse.Location = new System.Drawing.Point(526, 335);
            this.buttonBrowse.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Primary = true;
            this.buttonBrowse.Size = new System.Drawing.Size(101, 35);
            this.buttonBrowse.TabIndex = 8;
            this.buttonBrowse.Text = "Przeglądaj";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowseDestinationFolder_Click);
            // 
            // textBoxDestinationFolder
            // 
            this.textBoxDestinationFolder.Depth = 0;
            this.textBoxDestinationFolder.Hint = "C:\\";
            this.textBoxDestinationFolder.Location = new System.Drawing.Point(25, 341);
            this.textBoxDestinationFolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxDestinationFolder.Name = "textBoxDestinationFolder";
            this.textBoxDestinationFolder.PasswordChar = '\0';
            this.textBoxDestinationFolder.SelectedText = "";
            this.textBoxDestinationFolder.SelectionLength = 0;
            this.textBoxDestinationFolder.SelectionStart = 0;
            this.textBoxDestinationFolder.Size = new System.Drawing.Size(474, 23);
            this.textBoxDestinationFolder.TabIndex = 7;
            this.textBoxDestinationFolder.UseSystemPasswordChar = false;
            // 
            // button
            // 
            this.button.Depth = 0;
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button.Location = new System.Drawing.Point(526, 194);
            this.button.MouseState = MaterialSkin.MouseState.HOVER;
            this.button.Name = "button";
            this.button.Primary = true;
            this.button.Size = new System.Drawing.Size(101, 35);
            this.button.TabIndex = 11;
            this.button.Text = "Przeglądaj";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // textBoxSourceFile
            // 
            this.textBoxSourceFile.Depth = 0;
            this.textBoxSourceFile.Hint = "C:\\";
            this.textBoxSourceFile.Location = new System.Drawing.Point(25, 200);
            this.textBoxSourceFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxSourceFile.Name = "textBoxSourceFile";
            this.textBoxSourceFile.PasswordChar = '\0';
            this.textBoxSourceFile.SelectedText = "";
            this.textBoxSourceFile.SelectionLength = 0;
            this.textBoxSourceFile.SelectionStart = 0;
            this.textBoxSourceFile.Size = new System.Drawing.Size(474, 23);
            this.textBoxSourceFile.TabIndex = 10;
            this.textBoxSourceFile.UseSystemPasswordChar = false;
            // 
            // SplitControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelSplit);
            this.Name = "SplitControl";
            this.Size = new System.Drawing.Size(640, 422);
            this.panelSplit.ResumeLayout(false);
            this.panelSplit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSplit;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton buttonMerge;
        private MaterialSkin.Controls.MaterialRaisedButton buttonBrowse;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxDestinationFolder;
        private MaterialSkin.Controls.MaterialRaisedButton button;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxSourceFile;
    }
}
