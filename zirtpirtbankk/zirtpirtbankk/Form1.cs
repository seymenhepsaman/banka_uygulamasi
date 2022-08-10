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
    public partial class zirtpirtbankanasayfa : Form
    {
        paragonder frmpp = new paragonder();
        public zirtpirtbankanasayfa()
        {
            InitializeComponent();
            txtsifreanasayfa.Text = "123456";
            txtsifreanasayfa.PasswordChar = '*';
            txtsifreanasayfa.MaxLength = 6;
            txttcanasayfa.MaxLength = 11;
        }
        bool oku;
        SqlConnection con = new SqlConnection("Data Source= DESKTOP-R5VREJK; Initial Catalog= zirtpirtbank; Integrated Security=TRUE");
        private void btngiris_Click(object sender, EventArgs e)
            {
            string tc = txttcanasayfa.Text;
            string şifre = txtsifreanasayfa.Text;
                con.Open();
            SqlCommand com = new SqlCommand("Select * from veri", con);
            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                if(tc == reader["tc"].ToString().TrimEnd() && şifre == reader["şifre"].ToString().TrimEnd())
                {
                    oku = true;
                    break;
                }
                else
                {
                    oku = false;
                }
            }
                con.Close();
            if (oku)
            {
                MessageBox.Show("BAŞARIYLA GİRİŞ YAPILDI");
                string hesap_bakiyesi = "", iban = "", adsoyad = "";
                con.Open();
                SqlCommand command = new SqlCommand("Select * from veri where tc = @tc ", con);
                command.Parameters.AddWithValue("@tc", txttcanasayfa.Text);
                SqlDataReader readerr = command.ExecuteReader();

                while (readerr.Read())

                {
                    hesap_bakiyesi = readerr["hesap_bakiyesi"].ToString();
                    iban = readerr["iban"].ToString();
                    adsoyad = readerr["ad"]+" "+readerr["soyad"].ToString();

                }

                readerr.Close();
                command.Dispose();
                con.Close();

                zirtpirtbankgirisanasayfa frmzart = new zirtpirtbankgirisanasayfa();
                frmzart.label1.Text = hesap_bakiyesi.ToString();
                frmzart.label2.Text = iban.ToString();
                frmzart.label5.Text = adsoyad.ToString();
                
                frmzart.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("BÖYLE BİR KAYIT YOK LÜTFEN KAYIT OLUNUZ","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private void txtsifreanasayfa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txttcanasayfa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnyenigiris_Click(object sender, EventArgs e)
        {
            zirtpirtbankyenigiris frmyenigiris = new zirtpirtbankyenigiris(); 
            frmyenigiris.Show();
            this.Hide();
        }

        

        private void txttcanasayfa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btng_Click(object sender, EventArgs e)
        {
            if (txtsifreanasayfa.PasswordChar.ToString() == "*")
            {
                txtsifreanasayfa.PasswordChar = char.Parse("\0");
            }
            else
            {
                txtsifreanasayfa.PasswordChar = char.Parse("*");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label2.Text = dt.ToLongDateString();
            label1.Text = dt.ToLongTimeString();
        }

        private void zirtpirtbankanasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txttcanasayfa_MouseClick(object sender, MouseEventArgs e)
        {
            txttcanasayfa.Text = "";
        }

        private void txtsifreanasayfa_MouseClick(object sender, MouseEventArgs e)
        {
            txtsifreanasayfa.Text = "";
        }
    }
}
