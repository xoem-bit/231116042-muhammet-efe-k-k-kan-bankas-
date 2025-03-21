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
    public partial class KanStogu : Form
    {
        public KanStogu()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"data source=DESKTOP-BMG5BKD\\MSSQLSERVER01;initial catalog=kanbank;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework");

        private void KanStok()
        {
            baglanti.Open();
            string query = "select *from Donor";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void KanStogu_Load(object sender, EventArgs e)
        {

        }
    }
}
