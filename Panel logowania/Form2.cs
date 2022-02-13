using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Panel_logowania
{
    public partial class Form2 : Form
    {
        private string server;
        private string database;
        private string uid;
        private string passwd;

        public Form2()
        {
            InitializeComponent();
        }

        void pobierzDane()
        {
            try
            {
                server = "localhost";
                database = "mydb";
                uid = "root";
                passwd = "admin";

                MySqlConnection conn = new MySqlConnection("SERVER=" + server + ";DATABASE=" + database + ";UID=" + uid + ";PASSWORD=" + passwd + ";");
                MySqlCommand command = new MySqlCommand("SELECT * FROM uzytkownicy", conn);

                conn.Open();

                MySqlDataAdapter adap = new MySqlDataAdapter(command);
                DataSet ds = new DataSet();
                adap.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0].DefaultView;

                conn.Close();
            }
            catch (Exception ex)
            {
                string b1 = string.Format("Błąd połączenia z bazą danych", ex.Message);
                MessageBox.Show(b1, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pobierzDane();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( String.IsNullOrEmpty(textBox1.Text) && String.IsNullOrEmpty(textBox2.Text) && String.IsNullOrEmpty(textBox3.Text) && textBox2.Text != textBox3.Text)
            {
                button1.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
