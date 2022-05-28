using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExePABD_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            if (InputNama.Text == "Rico" && Inputpw.Text == "qwerty")
            {
                new hlmn2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User ID atau Password salah !!!");
            }
        }

        private void menuawal_TextChanged(object sender, EventArgs e)
        {
            if (Inputpw.PasswordChar == '\0')
            {
                Inputpw.PasswordChar = '*';
            }
        }
    }
}
