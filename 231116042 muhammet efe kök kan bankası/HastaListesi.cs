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
    public partial class HastaListesi : Form
    {
        public HastaListesi()
        {
            InitializeComponent();
            uyeler();
        }
        SqlConnection baglanti = new SqlConnection(@"data source=DESKTOP-BMG5BKD\\MSSQLSERVER01;initial catalog=kanbank;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework");

        private void uyeler()
        {
            baglanti.Open();
            string query = "select *from DonorTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void HastaListesi_Load(object sender, EventArgs e)
        {

        }
        int key = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtadsoyad.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtyas.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txttel.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            cmbcins.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            cmbgrup.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtadres.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            if (txtadsoyad.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Reset()
        {
            txtadsoyad.Text = "";
            txtyas.Text = "";
            cmbcins.SelectedIndex = -1;
            txttel.Text = "";
            txtadres.Text = "";
            cmbgrup.SelectedIndex = -1;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Silinecek hastayı seciniz");
            }
            else
            {
                try
                {
                    string query = "delete from HastaTbl where HNum=" + key + ",";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Hasta Basarıyla Silindi");
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
            if (txtadsoyad.Text == "" || txtyas.Text == "" || cmbcins.SelectedIndex == -1 || txttel.Text == "" || cmbgrup.SelectedIndex == -1 || txtadres.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }

            else
            {
                try
                {
                    string query = "update Donor values('" + txtadsoyad.Text + "'," + txtyas.Text + ",'" + cmbcins.SelectedItem.ToString() + "','" + txttel.Text + "," + txtadres.Text + "','" + cmbgrup.SelectedItem.ToString() + "')";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Donor Basar:yla Kaydedildi");
                    baglanti.Close();
                    Reset();
                }
                catch (Exception Ex)

                {
                    MessageBox.Show("Ex.Message");
                }

            }
        }
    }
}
