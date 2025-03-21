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
    public partial class KontrolPaneli : Form
    {
        public KontrolPaneli()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"data source=DESKTOP-BMG5BKD\\MSSQLSERVER01;initial catalog=kanbank;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework");

        private void vericek()
        {
            baglanti.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from Donor1bl", baglanti);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            Donorlbl.Text = dt.Rows[0][0].ToString();
            SqlDataAdapter sda1 = new SqlDataAdapter("Select count(*) from Tranfer1bl", baglanti);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);

            Transferlbl.Text = dt1.Rows[0][0].ToString();
            SqlDataAdapter sda2 = new SqlDataAdapter("Select count(*) from Calisan1bl", baglanti);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);

            Kullanicl1bl.Text = dt2.Rows[0][0].ToString();
            SqlDataAdapter sda3 = new SqlDataAdapter("Select count(*) from Kan1bl", baglanti);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);

            int Kstok = Convert.ToInt32(dt3.Rows[0][0].ToString());
            Totallbl.Text = "" + Kstok;
            SqlDataAdapter sda4 = new SqlDataAdapter("Select KStok from Kan1bl where KGrup=" + "0+" + "", "", baglanti);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);

            Optbl.Text = dt4.Rows[0][0].ToString();
            double Op1usPercentage = (Convert.ToDouble(dt4.Rows[0][0].ToString()) / Kstok) * 100;
            Op1usBar.Value = Convert.ToInt32(Op1usPercentage);
            SqlDataAdapter sda5 = new SqlDataAdapter("Select KStok from Kan1bl where KGrup=" + "AB+" + "'", baglanti);
            DataTable dt5 = new DataTable();
            sda5.Fill(dt5);

            ABp1us1bl.Text = dt5.Rows[0][0].ToString();
            double ABp1usPercentage = (Convert.ToDouble(dt5.Rows[0][0].ToString()) / Kstok) * 100;
            ABp1usBar.Value = Convert.ToInt32(ABp1usPercentage);
            SqlDataAdapter sda6 = new SqlDataAdapter("Select KStok from Kan1bl where KGrup=" + "0-" + "'", baglanti);
            DataTable dt6 = new DataTable();
            sda6.Fill(dt6);

            Onegat1velbl.Text = dt6.Rows[0][0].ToString();
            double OninutesPercentage = (Convert.ToDouble(dt6.Rows[0][0].ToString()) / Kstok) * 100;
            OninBar.Value = Convert.ToInt32(OninutesPercentage);
            SqlDataAdapter sda7 = new SqlDataAdapter("Select KStok from Kan1bl where KGrup=" + "AB-" + "'", baglanti);
            DataTable dt7 = new DataTable();
            sda7.Fill(dt7);
        }

        private void KontrolPaneli_Load(object sender, EventArgs e)
        {

        }
    }
}
