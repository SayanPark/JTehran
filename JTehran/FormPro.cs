using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JTehran
{
    public partial class FormPro : Form
    {
        public FormPro()
        {
            InitializeComponent();
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            FrmnewTrm a = new FrmnewTrm(); 
            a.ShowDialog();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            FrmnewPro a = new FrmnewPro();
            a.ShowDialog();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            FrmshwPro a = new FrmshwPro();
            a.ShowDialog();
        }
    }
}   
