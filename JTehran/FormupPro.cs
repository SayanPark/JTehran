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
    public partial class FormupPro : Form
    {
        public FormupPro()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=.;Initial Catalog=jtehran;Integrated Security=true";
        private void FormupPro_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            comboBox1.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int xid = Convert.ToInt32(textBox1.Text);
            string query = "SELECT * FROM TablePro WHERE IDPro=" + xid;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();

            adapter.Fill(data);

            textBox2.Text = Convert.ToString(data.Rows[0][1]);
            textBox3.Text = Convert.ToString(data.Rows[0][2]);
            comboBox1.SelectedItem = Convert.ToString(data.Rows[0][3]);
            textBox4.Text = Convert.ToString(data.Rows[0][4]);
            textBox5.Text = Convert.ToString(data.Rows[0][5]);

            textBox2.Enabled = true;
            textBox3.Enabled = true;
            comboBox1.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = false;
            textBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             SqlConnection connection = new SqlConnection(connectionString);
            
                string query = "UPDATE TablePro SET Firstname=@Firstname,Lastname=@Lastname,study=@study,Telephone=@Telephone,address=@address WHERE IDPro=@IDPro";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IDPro", Convert.ToInt32(textBox1.Text));
                command.Parameters.AddWithValue("@Firstname",textBox2.Text);
                command.Parameters.AddWithValue("@Lastname",textBox3.Text);
                command.Parameters.AddWithValue("@study",comboBox1.SelectedItem);
                command.Parameters.AddWithValue("@Telephone", Convert.ToInt64(textBox4.Text));
                command.Parameters.AddWithValue("@address", textBox5.Text);
                connection.Open();
                command.ExecuteNonQuery();
                this.Hide();   
        }
    }
}
