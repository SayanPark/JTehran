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
    public partial class FrmnewPro : Form
    {
        public FrmnewPro()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=.;Initial Catalog=jtehran;Integrated Security=true";
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO TablePro (Firstname,Lastname,study,Telephone,address) VALUES (@Firstname,@Lastname,@study,@Telephone,@address)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Firstname", textBox2.Text);
            command.Parameters.AddWithValue("@Lastname", textBox3.Text);
            command.Parameters.AddWithValue("@study", comboBox1.SelectedItem);
            command.Parameters.AddWithValue("@Telephone", Convert.ToDouble(textBox4.Text));
            command.Parameters.AddWithValue("@address", textBox5.Text);
            connection.Open();
            command.ExecuteNonQuery();
            this.Hide();
        }
    }
}
