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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnPro_Click(object sender, EventArgs e)
        {
            FormPro frm = new FormPro();
            frm.ShowDialog();
        }

        private void bttnStu_Click(object sender, EventArgs e)
        {
            FormStu frm = new FormStu();
            frm.ShowDialog();
        }
    }
}
