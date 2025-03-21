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
    public partial class Hasta : Form
    {
        public Hasta()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"data source=DESKTOP-BMG5BKD\\MSSQLSERVER01;initial catalog=kanbank;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework");

        private void Hasta_Load(object sender, EventArgs e)
        {

        }
        private void Reset()
        {
            txtadsoyad.Text = "";
            txtyas.Text = "";
            cmbcins.SelectedIndex = -1;
            txttel.Text = "";
            txtadres.Text = "";
            cmbkan.SelectedIndex = -1;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txtadsoyad.Text == "" || txtyas.Text == "" || cmbcins.SelectedIndex == -1 || txttel.Text == "" || cmbkan.SelectedIndex == -1 || txtadres.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }

            else
            {
                try
                {
                    string query = "insert into Donor values('" + txtadsoyad.Text + "'," + txtyas.Text + ",'" + cmbcins.SelectedItem.ToString() + "','" + txttel.Text + "," + txtadres.Text + "','" + cmbgrup.SelectedItem.ToString() + "')";
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
