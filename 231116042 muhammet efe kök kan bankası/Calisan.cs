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
    public partial class Calisan : Form
    {
        public Calisan()
        {
            InitializeComponent();
            uyeler();
        }
        SqlConnection baglanti = new SqlConnection(@"data source=DESKTOP-BMG5BKD\\MSSQLSERVER01;initial catalog=kanbank;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework");
        private void Reset()
        {
            txtadsoyad.Text = "";
            txtsifre.Text = "";
            key = 0;
        }
        private void uyeler()
        {
            baglanti.Open();
            string query = "select *from Calisan";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txtadsoyad.Text == "" || txtsifre.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    string query = "insert into CalisanTbl values('" + txtadsoyad.Text + "'','" + txtsifre.Text + "')";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Calisan Basarıyla Kaydedildi");
                    baglanti.Close();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ex.Message");
                }
            }
        }
        int key = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtadsoyad.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtsifre.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            if (txtadsoyad.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Silinecek callsani seciniz");
            }

            else
            {
                try
                {
                    string query = "delete from Calisan where CallNum=" + key + ",";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Çalışan Basarayla Silindi");
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

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (txtadsoyad.Text == "" | txtsifre.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }

            else
            {
                try
                {
                    string query = "update CalisanTbl set CalId='" + txtadsoyad.Text + "', CalSif='" + txtsifre.Text + "' where CallNum=" + key + ";";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Calisan Basarayla Güncellendi");
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
}
