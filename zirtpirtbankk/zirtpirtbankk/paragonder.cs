using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace zirtpirtbankk
{
    public partial class paragonder : Form
    {
        zirtpirtbankgirisanasayfa zirtpirtbankgirisanasayfa = new zirtpirtbankgirisanasayfa();
        public int vericibakiye { get; set; }
        public string vericiiban { get; set; }

        int alicibakiye;
        public string adsoyad1 { get; set; }
        SqlConnection con = new SqlConnection("Data Source= DESKTOP-R5VREJK; Initial Catalog= zirtpirtbank; Integrated Security=TRUE");

        public paragonder()
        {
            InitializeComponent();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string query = "SELECT * FROM veri WHERE iban='" + txtibangonder.Text + "'";
                SqlCommand komut2 = new SqlCommand(query, con);
                SqlDataReader reader = komut2.ExecuteReader();
                if (reader.Read())
                {
                    alicibakiye = Convert.ToInt32(reader["hesap_bakiyesi"]);
                    con.Close();
                    if (vericibakiye >= int.Parse(txtbakiyegonder.Text))
                    {
                        con.Open();
                        string query3 = "UPDATE veri set hesap_bakiyesi=@yenihesapbakiyesi where iban=@vericiiban";
                        SqlCommand komut3 = new SqlCommand(query3, con);
                        komut3.Parameters.AddWithValue("@vericiiban", vericiiban);
                        komut3.Parameters.AddWithValue("@yenihesapbakiyesi", (vericibakiye - int.Parse(txtbakiyegonder.Text)).ToString());
                        SqlDataAdapter da1 = new SqlDataAdapter(komut3);
                        SqlDataReader dr1 = komut3.ExecuteReader();
                        con.Close();

                        con.Open();
                        string query2 = "UPDATE veri set hesap_bakiyesi=@yenihesapbakiyesi where iban=@aliciiban";
                        SqlCommand komut = new SqlCommand(query2, con);
                        komut.Parameters.AddWithValue("@aliciiban", txtibangonder.Text);
                        komut.Parameters.AddWithValue("@yenihesapbakiyesi", (alicibakiye + int.Parse(txtbakiyegonder.Text)).ToString());
                        SqlDataAdapter da = new SqlDataAdapter(komut);
                        SqlDataReader dr = komut.ExecuteReader();
                        con.Close();
                        MessageBox.Show("PARA BAŞARIYLA GÖNDERİLDİ");
                        zirtpirtbankgirisanasayfa.label1.Text = (vericibakiye - int.Parse(txtbakiyegonder.Text)).ToString();
                        zirtpirtbankgirisanasayfa.label2.Text = vericiiban.ToString();
                        zirtpirtbankgirisanasayfa.label5.Text = adsoyad1.ToString();
                        //zirtpirtbankgirisanasayfa.Hide();
                        zirtpirtbankgirisanasayfa.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("YETERSİZ BAKİYE", "UYARI", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception danger)
            {

                MessageBox.Show("HAY AKSİ BİR SORUN OLUŞTU\n" + danger, "SİSTEM HATASI", MessageBoxButtons.OK);


            }

        }
        private void paragonder_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            zirtpirtbankgirisanasayfa.Show();
            zirtpirtbankgirisanasayfa.label1.Text = (vericibakiye).ToString();
            zirtpirtbankgirisanasayfa.label2.Text = vericiiban.ToString();
            zirtpirtbankgirisanasayfa.label5.Text = adsoyad1.ToString();
        }

        private void paragonder_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtibangonder_MouseClick(object sender, MouseEventArgs e)
        {
            txtibangonder.Text = "";
        }

        private void txtbakiyegonder_MouseClick(object sender, MouseEventArgs e)
        {
            txtbakiyegonder.Text = "";
        }
    }
}
