using System;
using System.Collections;
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
    public partial class KanTransferi : Form
    {
        public KanTransferi()
        {
            InitializeComponent();
            fillHastaCb();
        }
        SqlConnection baglanti = new SqlConnection(@"data source=DESKTOP-BMG5BKD\\MSSQLSERVER01;initial catalog=kanbank;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework");
        private void fillHastaCb()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select HNum from Hasta", baglanti);
            SqlDataReader rdr;
            rdr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("HNum", typeof(int));
            dt.Load(rdr);
            cmbıd.ValueMember = "HNum";
            cmbıd.DataSource = dt;
            baglanti.Close();
        }
        private void VeriAl()
        {
            baglanti.Open();
            string query = "select * from HastaTbl where HMume" + cmbıd.SelectedValue.ToString() + "";
            SqlCommand komut = new SqlCommand(query, baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtadsoyad.Text = dr["HAdSoyad"].ToString();
                txtgrup.Text = dr["HKGrup"].ToString();
            }
            baglanti.Close();
        }
        int stokk = 0;
        private void Stok(string Kgrup)
        {
            baglanti.Open();
            string query = "select * from Kan where KGrup=" + Kgrup + "'";
            SqlCommand komut = new SqlCommand(query, baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                stokk = Convert.ToInt32(dr["KStok"].ToString());
            }
            baglanti.Close();
        }
        private void KanTransferi_Load(object sender, EventArgs e)
        {

        }

        private void cmbıd_SelectionChangeCommitted(object sender, EventArgs e)
        {
            VeriAl();
        }

        private void Reset()
        {
            txtadsoyad.Text = "";
            txtgrup.Text = "";       
            bunifuThinButton21.Visible = false;
        }

        private void kanguncelle()
        {
            int yenistok = stokk - 1;
            try
            {
                string query = "update Kan set KStok=" + yenistok + " where KGrup='" + txtgrup.Text + "';";
                SqlCommand komut = new SqlCommand(query, baglanti);
                komut.ExecuteNonQuery();
                //MessageBox.Show("Hasta Basarayla Güncellendi");
                baglanti.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ex.Message");
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txtadsoyad.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    string query = "insert into TranferTbl values('" + txtadsoyad.Text + "','" + txtgrup.Text + "',)";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Transfer Basarlll");
                    baglanti.Close();
                    Reset();
                    kanguncelle();
                    Stok(txtgrup.Text);
                }
                catch (Exception Ex)
                    {
                    MessageBox.Show("Ex.Message");
                }
                }
            }
    }
}
