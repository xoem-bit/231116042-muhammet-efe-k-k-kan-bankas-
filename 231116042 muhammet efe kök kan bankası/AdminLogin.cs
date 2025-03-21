using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _231116042_muhammet_efe_kök_kan_bankası
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Admin Sifreni Giriniz");
            }
            else if (textBox2.Text == "0678")
            {
                Calisan cal = new Calisan();
                cal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("YanLis Sifre");
                textBox2.Text = "";
            }
        }
    }
    
}
