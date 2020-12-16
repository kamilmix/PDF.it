namespace PDF.it
{
    partial class MainForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelMenuSelectedItem = new System.Windows.Forms.Panel();
            this.buttonMenuMergePDF = new System.Windows.Forms.Button();
            this.buttonMenuSplitPDF = new System.Windows.Forms.Button();
            this.labelLogo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitControl1 = new PDF.it.SplitControl();
            this.mergeControl1 = new PDF.it.Controls.MergeControl();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.panelMenu.Controls.Add(this.panelMenuSelectedItem);
            this.panelMenu.Controls.Add(this.buttonMenuMergePDF);
            this.panelMenu.Controls.Add(this.buttonMenuSplitPDF);
            this.panelMenu.Controls.Add(this.labelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(156, 450);
            this.panelMenu.TabIndex = 1;
            // 
            // panelMenuSelectedItem
            // 
            this.panelMenuSelectedItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.panelMenuSelectedItem.Location = new System.Drawing.Point(3, 142);
            this.panelMenuSelectedItem.Name = "panelMenuSelectedItem";
            this.panelMenuSelectedItem.Size = new System.Drawing.Size(8, 43);
            this.panelMenuSelectedItem.TabIndex = 3;
            // 
            // buttonMenuMergePDF
            // 
            this.buttonMenuMergePDF.FlatAppearance.BorderSize = 0;
            this.buttonMenuMergePDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuMergePDF.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMenuMergePDF.ForeColor = System.Drawing.Color.White;
            this.buttonMenuMergePDF.Location = new System.Drawing.Point(3, 203);
            this.buttonMenuMergePDF.Name = "buttonMenuMergePDF";
            this.buttonMenuMergePDF.Size = new System.Drawing.Size(150, 44);
            this.buttonMenuMergePDF.TabIndex = 2;
            this.buttonMenuMergePDF.Text = "Połącz PDF";
            this.buttonMenuMergePDF.UseVisualStyleBackColor = true;
            this.buttonMenuMergePDF.Click += new System.EventHandler(this.buttonMenuMergePDF_Click);
            // 
            // buttonMenuSplitPDF
            // 
            this.buttonMenuSplitPDF.FlatAppearance.BorderSize = 0;
            this.buttonMenuSplitPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuSplitPDF.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMenuSplitPDF.ForeColor = System.Drawing.Color.White;
            this.buttonMenuSplitPDF.Location = new System.Drawing.Point(3, 142);
            this.buttonMenuSplitPDF.Name = "buttonMenuSplitPDF";
            this.buttonMenuSplitPDF.Size = new System.Drawing.Size(150, 44);
            this.buttonMenuSplitPDF.TabIndex = 1;
            this.buttonMenuSplitPDF.Text = "Podziel PDF";
            this.buttonMenuSplitPDF.UseVisualStyleBackColor = true;
            this.buttonMenuSplitPDF.Click += new System.EventHandler(this.buttonMenuSplitPDF_Click);
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogo.ForeColor = System.Drawing.Color.White;
            this.labelLogo.Location = new System.Drawing.Point(12, 9);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(105, 38);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "PDF.it";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(73)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(156, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 22);
            this.panel1.TabIndex = 2;
            // 
            // splitControl1
            // 
            this.splitControl1.Location = new System.Drawing.Point(163, 29);
            this.splitControl1.Name = "splitControl1";
            this.splitControl1.Size = new System.Drawing.Size(649, 427);
            this.splitControl1.TabIndex = 4;
            // 
            // mergeControl1
            // 
            this.mergeControl1.Location = new System.Drawing.Point(163, 29);
            this.mergeControl1.Name = "mergeControl1";
            this.mergeControl1.Size = new System.Drawing.Size(640, 422);
            this.mergeControl1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitControl1);
            this.Controls.Add(this.mergeControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "PDF.it";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonMenuMergePDF;
        private System.Windows.Forms.Button buttonMenuSplitPDF;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Panel panelMenuSelectedItem;
        private Controls.MergeControl mergeControl1;
        private SplitControl splitControl1;
    }
}

