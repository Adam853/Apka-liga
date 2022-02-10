using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panel_logowania
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
 //String^ konfiguracja = Left"datasource=127.0.0.1, port= 3306, username=root, database=Przychodnia";
            if (textBox1.Text == "adam")
            {
                if (textBox2.Text == "kupczak")
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
    }
}

