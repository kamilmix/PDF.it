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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonMerge = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonBrowseDestinationFolder = new System.Windows.Forms.Button();
            this.textBoxDestinationFolder = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Połącz PDF";
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(22, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(602, 95);
            this.listBox1.TabIndex = 1;
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            // 
            // buttonMerge
            // 
            this.buttonMerge.Location = new System.Drawing.Point(22, 134);
            this.buttonMerge.Name = "buttonMerge";
            this.buttonMerge.Size = new System.Drawing.Size(75, 23);
            this.buttonMerge.TabIndex = 2;
            this.buttonMerge.Text = "Połącz";
            this.buttonMerge.UseVisualStyleBackColor = true;
            this.buttonMerge.Click += new System.EventHandler(this.buttonMerge_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonBrowseDestinationFolder);
            this.groupBox1.Controls.Add(this.textBoxDestinationFolder);
            this.groupBox1.Location = new System.Drawing.Point(7, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 73);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Katalog docelowy";
            // 
            // buttonBrowseDestinationFolder
            // 
            this.buttonBrowseDestinationFolder.Location = new System.Drawing.Point(516, 30);
            this.buttonBrowseDestinationFolder.Name = "buttonBrowseDestinationFolder";
            this.buttonBrowseDestinationFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseDestinationFolder.TabIndex = 2;
            this.buttonBrowseDestinationFolder.Text = "Przeglądaj";
            this.buttonBrowseDestinationFolder.UseVisualStyleBackColor = true;
            this.buttonBrowseDestinationFolder.Click += new System.EventHandler(this.buttonBrowseDestinationFolder_Click);
            // 
            // textBoxDestinationFolder
            // 
            this.textBoxDestinationFolder.Location = new System.Drawing.Point(6, 32);
            this.textBoxDestinationFolder.Name = "textBoxDestinationFolder";
            this.textBoxDestinationFolder.Size = new System.Drawing.Size(504, 20);
            this.textBoxDestinationFolder.TabIndex = 1;
            // 
            // MergeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonMerge);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "MergeControl";
            this.Size = new System.Drawing.Size(640, 422);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonMerge;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonBrowseDestinationFolder;
        private System.Windows.Forms.TextBox textBoxDestinationFolder;
    }
}
