using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JTehran
{
    public partial class FrmshwPro : Form
    {
        public FrmshwPro()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=.;Initial Catalog=jtehran;Integrated Security=true";
        private void FrmshwPro_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM TablePro";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormupPro frm = new FormupPro();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormdelPro frm = new FormdelPro();
            frm.ShowDialog();
        }
    }
}
