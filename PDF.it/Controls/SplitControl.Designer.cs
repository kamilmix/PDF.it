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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button = new System.Windows.Forms.Button();
            this.textBoxSourceFile = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonBrowseDestinationFolder = new System.Windows.Forms.Button();
            this.textBoxDestinationFolder = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelSplit.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSplit
            // 
            this.panelSplit.Controls.Add(this.groupBox2);
            this.panelSplit.Controls.Add(this.groupBox1);
            this.panelSplit.Controls.Add(this.button1);
            this.panelSplit.Location = new System.Drawing.Point(3, 3);
            this.panelSplit.Name = "panelSplit";
            this.panelSplit.Size = new System.Drawing.Size(644, 422);
            this.panelSplit.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button);
            this.groupBox2.Controls.Add(this.textBoxSourceFile);
            this.groupBox2.Location = new System.Drawing.Point(6, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(626, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wybierz plik";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(510, 18);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 1;
            this.button.Text = "Przeglądaj";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // textBoxSourceFile
            // 
            this.textBoxSourceFile.Location = new System.Drawing.Point(7, 20);
            this.textBoxSourceFile.Name = "textBoxSourceFile";
            this.textBoxSourceFile.Size = new System.Drawing.Size(497, 20);
            this.textBoxSourceFile.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonBrowseDestinationFolder);
            this.groupBox1.Controls.Add(this.textBoxDestinationFolder);
            this.groupBox1.Location = new System.Drawing.Point(6, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 73);
            this.groupBox1.TabIndex = 2;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SplitControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelSplit);
            this.Name = "SplitControl";
            this.Size = new System.Drawing.Size(649, 427);
            this.panelSplit.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSplit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox textBoxSourceFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonBrowseDestinationFolder;
        private System.Windows.Forms.TextBox textBoxDestinationFolder;
        private System.Windows.Forms.Button button1;
    }
}
