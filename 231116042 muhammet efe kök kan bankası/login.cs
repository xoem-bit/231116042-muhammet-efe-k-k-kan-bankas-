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

namespace _231116042_muhammet_efe_kök_kan_bankası
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"data source=DESKTOP-BMG5BKD\\MSSQLSERVER01;initial catalog=kanbank;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework");

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from CalisanTbl where CalId='" + textBox1.Text + "' and CalSif='" + textBox2.Text + "'", baglanti);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                AnaSayfa ana = new AnaSayfa();
                ana.Show();
                this.Hide();
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Yanlis Kullanıcı yada Sifre");
            }

            baglanti.Close();
        }
    }
}
