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
    public partial class FormdelPro : Form
    {
        public FormdelPro()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=.;Initial Catalog=jtehran;Integrated Security=true";
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);


            string query = "DELETE FROM TablePro WHERE IDPro=@IDPro";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IDPro", Convert.ToInt32(textBox1.Text));
            connection.Open();
            command.ExecuteNonQuery();
            Success frm = new Success();
            frm.ShowDialog();
            this.Hide();
        }
    }
}
