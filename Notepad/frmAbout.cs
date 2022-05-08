using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            lblProductName.Text = String.Format("Product name: {0}", Application.ProductName);
            lblProductVersion.Text = String.Format("Version: {0}", Application.ProductVersion);
            lblCopyright.Text = ("Copyright ©  2022 by J. Daniel Wonderson");
        }
    }
}
