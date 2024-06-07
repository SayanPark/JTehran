using System;
using System.Collections.Generic;
using System.Configuration;
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
    public partial class FrmnewTrm : Form
    {
        public FrmnewTrm()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=.;Initial Catalog=jtehran;Integrated Security=true";
        private void FrmnewTrm_Load(object sender, EventArgs e)
        {
            string query = "SELECT (IDPro) FROM TablePro";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            comboBox1.DataSource = data;
           
        }
    }
}
