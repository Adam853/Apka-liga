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
    public partial class Form1 : Form
    {
        private string server;
        private string database;
        private string uid;
        private string passwd;

        public Form1()
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

                //

                conn.Close();
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            checkBox1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
 //String^ konfiguracja = Left"datasource=127.0.0.1, port= 3306, username=root, database=Przychodnia";
            if (textBox4.Text == "Admin")
            {
                if (textBox3.Text == "Admin")
                {
                        
                     this.Hide();
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                }
                else
                    MessageBox.Show("Podano bledne dane");
            }
            else
                MessageBox.Show("Podano bledne dane");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Visible == false)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                checkBox1.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                button3.Text = "Anuluj";
                label5.Text = "Rejestracja";
            }
            else
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
                checkBox1.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                button3.Text = "Rejestruj";
                label5.Text = "Logowanie";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label2.Text = "";

            if (textBox1.Text == "" && textBox2.Text == "")
            {
                label1.Text = "Imię";
                label2.Text = "Nazwisko";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label4.Text = "";

            if (textBox3.Text == "" && textBox4.Text == "")
            {
                label4.Text = "Login";
                label3.Text = "Hasło";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "";

            if (textBox3.Text == "" && textBox4.Text == "")
            {
                label4.Text = "Login";
                label3.Text = "Hasło";
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            label1.Text = "";

            if(textBox1.Text == "" && textBox2.Text == "")
            {
                label1.Text = "Imię";
                label2.Text = "Nazwisko";
            }
        }
    }
}

