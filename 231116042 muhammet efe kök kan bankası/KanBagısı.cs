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
    public partial class KanBagısı : Form
    {
        public KanBagısı()
        {
            InitializeComponent();
            uyeler();
        }
        SqlConnection baglanti = new SqlConnection(@"data source=DESKTOP-BMG5BKD\\MSSQLSERVER01;initial catalog=kanbank;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework");
        private void uyeler()
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
        private void KanBagısı_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtadsoyad.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtgrup.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }
        private void Reset()
        {
            txtadsoyad.Text = "";
            txtgrup.Text = "";
        }
        private void KanStok()
        {
            baglanti.Open();
            string query = "select *from Donor";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txtadsoyad.Text == "")
            {
                MessageBox.Show("Bin Donor Seciniz");
            }

            else
            {
                try
                {
                    int stok = 1;
                    string query = "update KanTbl set KStok='" + stok + " where KGrup='" + txtgrup.Text + "';";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Bagls Basarall");
                    baglanti.Close();
                    Reset();
                    uyeler();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show("Ex.Message");
                }
            }
    }
}
