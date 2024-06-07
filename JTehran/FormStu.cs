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
    public partial class FormStu : Form
    {
        public FormStu()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            FrmnewStu frm = new FrmnewStu();
            frm.ShowDialog();
        }

        private void FormStu_Load(object sender, EventArgs e)
        {

        }
    }
}
