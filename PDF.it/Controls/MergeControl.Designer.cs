using MaterialSkin;
using MaterialSkin.Controls;
namespace PDF.it.Controls
{
    partial class MergeControl
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxDestinationFolder = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonBrowseDestinationFolder = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonMerge = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(22, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(602, 95);
            this.listBox1.TabIndex = 1;
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
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
            this.textBoxDestinationFolder.TabIndex = 3;
            this.textBoxDestinationFolder.UseSystemPasswordChar = false;
            // 
            // buttonBrowseDestinationFolder
            // 
            this.buttonBrowseDestinationFolder.Depth = 0;
            this.buttonBrowseDestinationFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBrowseDestinationFolder.Location = new System.Drawing.Point(526, 335);
            this.buttonBrowseDestinationFolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBrowseDestinationFolder.Name = "buttonBrowseDestinationFolder";
            this.buttonBrowseDestinationFolder.Primary = true;
            this.buttonBrowseDestinationFolder.Size = new System.Drawing.Size(101, 35);
            this.buttonBrowseDestinationFolder.TabIndex = 4;
            this.buttonBrowseDestinationFolder.Text = "Przeglądaj";
            this.buttonBrowseDestinationFolder.UseVisualStyleBackColor = true;
            this.buttonBrowseDestinationFolder.Click += new System.EventHandler(this.buttonBrowseDestinationFolder_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(18, 319);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(128, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Katalog docelowy";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(21, 9);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(85, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Połącz PDF";
            // 
            // buttonMerge
            // 
            this.buttonMerge.Depth = 0;
            this.buttonMerge.Location = new System.Drawing.Point(214, 379);
            this.buttonMerge.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonMerge.Name = "buttonMerge";
            this.buttonMerge.Primary = true;
            this.buttonMerge.Size = new System.Drawing.Size(209, 34);
            this.buttonMerge.TabIndex = 6;
            this.buttonMerge.Text = "Start";
            this.buttonMerge.UseVisualStyleBackColor = true;
            this.buttonMerge.Click += new System.EventHandler(this.buttonMerge_Click);
            // 
            // MergeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonMerge);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.buttonBrowseDestinationFolder);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.textBoxDestinationFolder);
            this.Controls.Add(this.listBox1);
            this.Name = "MergeControl";
            this.Size = new System.Drawing.Size(640, 422);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private MaterialSingleLineTextField textBoxDestinationFolder;
        private MaterialRaisedButton buttonBrowseDestinationFolder;
        private MaterialLabel materialLabel1;
        private MaterialLabel materialLabel2;
        private MaterialRaisedButton buttonMerge;
    }
}
