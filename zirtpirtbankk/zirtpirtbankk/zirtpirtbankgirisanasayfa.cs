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

namespace zirtpirtbankk
{
    public partial class zirtpirtbankgirisanasayfa : Form
    {

        SqlConnection con = new SqlConnection("Data Source= DESKTOP-R5VREJK; Initial Catalog= zirtpirtbank; Integrated Security=TRUE");

        int sayac =0;
        hesaplar frmhesaplar = new hesaplar();
        public zirtpirtbankgirisanasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(label1.Text);
            paragonder frmpg = new paragonder();
            frmpg.vericibakiye =a;
            frmpg.vericiiban =label2.Text.ToString();
            frmpg.Show();
            frmpg.adsoyad1 = label5.Text;
            this.Hide();
        }

        private void zirtpirtbankgirisanasayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnpanel_Click(object sender, EventArgs e)
        {
            if (sayac%2==0)
            {
                panel1.Visible = true;
                sayac++;
            }
            else
            {
                panel1.Visible = false;
                sayac++;
            }
        }

        private void btnhesapbilgileri_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmhesaplar.Show();

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string query = "SELECT * FROM veri WHERE iban='" + label2.Text + "'";
            SqlCommand komut2 = new SqlCommand(query, con);
            SqlDataReader reader = komut2.ExecuteReader();
            if (reader.Read())
            {
                frmhesaplar.label2.Text = reader["kart_no"].ToString();
                frmhesaplar.label5.Text = reader["hesap_bakiyesi"].ToString();
                frmhesaplar.label6.Text = reader["iban"].ToString();
                frmhesaplar.adsoyad2 = reader["ad"].ToString()+" "+reader["soyad"].ToString();
            }
            con.Close();
            frmhesaplar.iban = label2.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.turkiye.gov.tr/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://uzmanpara.milliyet.com.tr/doviz-kurlari/");
        }

        private void zirtpirtbankgirisanasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
