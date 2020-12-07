using System;
using System.Windows.Forms;

namespace PDF.it
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonMenuSplitPDF_Click(object sender, EventArgs e)
        {
            splitControl1.BringToFront();
            panelMenuSelectedItem.Top = buttonMenuSplitPDF.Top;
        }

        private void buttonMenuMergePDF_Click(object sender, EventArgs e)
        {
            mergeControl1.BringToFront();
            panelMenuSelectedItem.Top = buttonMenuMergePDF.Top;
        }
    }
}
