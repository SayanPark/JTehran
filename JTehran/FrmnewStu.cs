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
    public partial class FrmnewStu : Form
    {
        public FrmnewStu()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=.;Initial Catalog=jtehran;Integrated Security=true";
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO TableProfile (Firstname,Lastname,Telephone,Address) VALUES (@Firstname,@Lastname,@Telephone,@Address)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Firstname",textBox2.Text);
            command.Parameters.AddWithValue("@Lastname", textBox3.Text);
            command.Parameters.AddWithValue("@Telephone", Convert.ToInt32(textBox4.Text));
            command.Parameters.AddWithValue("@Address", textBox5.Text);
            connection.Open();
            command.ExecuteNonQuery();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            button1.Enabled = true;
        }

        private void FrmnewStu_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            button1.Enabled = false;

            string query = "SELECT * FROM TableLess";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            comboBox1.DataSource = data;
        }
    }
}
