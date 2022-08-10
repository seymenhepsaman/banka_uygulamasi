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
    public partial class zirtpirtbankyenigiris : Form
    {


        public zirtpirtbankyenigiris()
        {
            InitializeComponent();
            txttckayit.MaxLength = 11;
            txtadkayit.MaxLength = 50;
            txtsoyadkayit.MaxLength = 50;
            txttelnokayit.MaxLength = 15;
            txtemailkayit.MaxLength = 50;
            txtsehirkayit.MaxLength = 35;
            txthesaptipikayit.MaxLength = 50;
            txtkartnokayit.MaxLength = 16;
            txtdtkayit.MaxLength = 10;
            txtkarttarihikayit.MaxLength = 7;
            txtcvvkayit.MaxLength = 3;
            txtibankayit.MaxLength = 26;
            txthesapbakiyesikayit.MaxLength = 70;
            txtcinsiyetkayit.MaxLength = 10;
            txtşifrekayit.PasswordChar = '\0';
            txtşifretekrarkayit.PasswordChar = '\0';
            txtşifrekayit.MaxLength = 6;
            txtşifretekrarkayit.MaxLength = 6;
            ToolTip Aciklama = new ToolTip();
            Aciklama.InitialDelay = 0;
            Aciklama.ReshowDelay = 500;
            Aciklama.AutoPopDelay = 5000;
            Aciklama.SetToolTip(txtdtkayit, "DOĞUM TARİHİNİZİ GG/AA/YYYY ŞEKLİNDE GİRİNİZ!!!");
            Aciklama.SetToolTip(txtibankayit, "IBAN'INIZIN BAŞINA ÜLKE KODU EKLEMEYİ UNUTMAYIN!!!");
            Aciklama.SetToolTip(txtkarttarihikayit, "KART TARİHİNİZİ AA/YY ŞEKLİNDE GİRİNİZ!!!");
           
        }
        static string conString = "Data Source= DESKTOP-R5VREJK; Initial Catalog= zirtpirtbank; Integrated Security=TRUE";
        SqlConnection connect = new SqlConnection(conString);

        bool durum;

        void tekrar()
        {
            connect.Open();
            SqlCommand komut = new SqlCommand("select * from veri where tc = @tc", connect);
            komut.Parameters.AddWithValue("@tc", txttckayit.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            connect.Close();
        }
        private void btnsifrealmaekrani_Click(object sender, EventArgs e)
        {

            if (txtşifrekayit.Text == txtşifretekrarkayit.Text)
            {
                try
                {
                    tekrar();
                    if (durum == true)
                    {

                        if (connect.State == ConnectionState.Closed)
                            connect.Open();
                        string kayit = "insert into veri (tc,ad,soyad,tel_no,email,sehir,hesap_tipi,kart_no,kart_tarih,cvv,iban,hesap_bakiyesi,cinsiyet,şifre,şifre_tekrar,dogum_tarihi) " +
                        "values(@tc,@ad,@soyad,@tel_no,@email,@sehir,@hesap_tipi,@kart_no,@kart_tarih,@cvv,@iban,@hesap_bakiyesi,@cinsiyet,@şifre,@şifre_tekrar,@dogum_tarihi)";
                        SqlCommand komut = new SqlCommand(kayit, connect);

                        komut.Parameters.AddWithValue("@tc", txttckayit.Text);
                        komut.Parameters.AddWithValue("@ad", txtadkayit.Text);
                        komut.Parameters.AddWithValue("@soyad", txtsoyadkayit.Text);
                        komut.Parameters.AddWithValue("@dogum_tarihi", txtdtkayit.Text);
                        komut.Parameters.AddWithValue("@tel_no", txttelnokayit.Text);
                        komut.Parameters.AddWithValue("@email", txtemailkayit.Text);
                        komut.Parameters.AddWithValue("@sehir", txtsehirkayit.Text);
                        komut.Parameters.AddWithValue("@hesap_tipi", txthesaptipikayit.Text);
                        komut.Parameters.AddWithValue("@kart_no", txtkartnokayit.Text);
                        komut.Parameters.AddWithValue("@kart_tarih", txtkarttarihikayit.Text);
                        komut.Parameters.AddWithValue("@cvv", txtcvvkayit.Text);
                        komut.Parameters.AddWithValue("@iban", txtibankayit.Text);
                        komut.Parameters.AddWithValue("@hesap_bakiyesi", txthesapbakiyesikayit.Text);
                        komut.Parameters.AddWithValue("@cinsiyet", txtcinsiyetkayit.Text);
                        komut.Parameters.AddWithValue("@şifre", txtşifrekayit.Text);
                        komut.Parameters.AddWithValue("@şifre_tekrar", txtşifretekrarkayit.Text);

                        komut.ExecuteNonQuery();
                        connect.Close();


                        MessageBox.Show("KAYIT EKLENDİ ANASAYFAYA YÖNLENDİRİLİYORSUNUZ!!!");

                            zirtpirtbankanasayfa frmanasayfa = new zirtpirtbankanasayfa();
                            frmanasayfa.Show();
                            this.Hide();


                    }
                    else
                    {
                        MessageBox.Show("BU KAYIT ZATEN VAR", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }


                catch (Exception hata)
                {
                    MessageBox.Show("HATA!!!" + hata.Message);

                }


            }
            else
            {
                MessageBox.Show("GİRİLEN ŞİFRELER AYNI DEĞİL!!!");
            }
                

        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txttckayit.Text = "TC GİRİNİZ";
            txtadkayit.Text = "AD GİRİNİZ";
            txtsoyadkayit.Text = "SOYAD GİRİNİZ";
            txttelnokayit.Text = "TEL NO GİRİNİZ";
            txtemailkayit.Text = "E-MAİL GİRİNİZ";
            txtsehirkayit.Text = "ŞEHİR GİRİNİZ";
            txthesaptipikayit.Text = "HESAP TİPİ GİRİNİZ";
            txtkartnokayit.Text = "KART NO GİRİNİZ";
            txtkarttarihikayit.Text = "KART TARİHİ GİRİNİZ";
            txtcvvkayit.Text = "CVV GİRİNİZ";
            txtibankayit.Text = "IBAN GİRİNİZ";
            txthesapbakiyesikayit.Text = "HESAP BAKİYESİ GİRİNİZ";
            txtcinsiyetkayit.Text = "CİNSİYET GİRİNİZ";
            txtdtkayit.Text = "DOĞUM TARİHİ GİRİNİZ";
            txtşifrekayit.Text = "ŞİFRE GİRİNİZ";
            txtşifretekrarkayit.Text = "ŞİFRE GİRİNİZ";

        }

        private void txttckayit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txttelnokayit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtkartnokayit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtcvvkayit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtadkayit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtsoyadkayit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtsehirkayit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txthesaptipikayit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtcinsiyetkayit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void btng_Click(object sender, EventArgs e)
        {
            if (txtşifrekayit.PasswordChar.ToString() == "*")
            {
                txtşifrekayit.PasswordChar = char.Parse("\0");
            }
            else
            {
                txtşifrekayit.PasswordChar = char.Parse("*");
            }

            if (txtşifretekrarkayit.PasswordChar.ToString() == "*")
            {
                txtşifretekrarkayit.PasswordChar = char.Parse("\0");
            }
            else
            {
                txtşifretekrarkayit.PasswordChar = char.Parse("*");
            }
        }

        private void txtşifrekayit_TextChanged(object sender, EventArgs e)
        {
            txtşifrekayit.PasswordChar = '*';
            txtşifretekrarkayit.PasswordChar = '*';
        }

        private void txtşifrekayit_Click(object sender, EventArgs e)
        {
            txtşifrekayit.Text = null;
            txtşifretekrarkayit.Visible = true;
            txtşifretekrarkayit.Text = "";
        }

        private void txtşifrekayit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtşifretekrarkayit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zirtpirtbankanasayfa frmanasayfa = new zirtpirtbankanasayfa();
            frmanasayfa.Show();
            this.Hide();
        }

        private void txttckayit_MouseClick(object sender, MouseEventArgs e)
        {
            txttckayit.Text = "";
        }

        private void txtadkayit_MouseClick(object sender, MouseEventArgs e)
        {
            txtadkayit.Text = "";
        }

        private void txtsoyadkayit_MouseClick(object sender, MouseEventArgs e)
        {
            txtsoyadkayit.Text = "";
        }

        private void txtdtkayit_MouseClick(object sender, MouseEventArgs e)
        {
            txtdtkayit.Text = "";
        }

        private void txttelnokayit_MouseClick(object sender, MouseEventArgs e)
        {
            txttelnokayit.Text = "";
        }

        private void txtemailkayit_MouseClick(object sender, MouseEventArgs e)
        {
            txtemailkayit.Text = "";
        }

        private void txtsehirkayit_MouseClick(object sender, MouseEventArgs e)
        {
            txtsehirkayit.Text = "";
        }

        private void txtcinsiyetkayit_MouseClick(object sender, MouseEventArgs e)
        {
            txtcinsiyetkayit.Text = "";
        }

        private void txthesaptipikayit_MouseClick(object sender, MouseEventArgs e)
        {
            txthesaptipikayit.Text = "";
        }

        private void txtkartnokayit_MouseClick(object sender, MouseEventArgs e)
        {
            txtkartnokayit.Text = "";
        }

        private void txtkarttarihikayit_MouseClick(object sender, MouseEventArgs e)
        {
            txtkarttarihikayit.Text = "";
        }

        private void txtcvvkayit_MouseClick(object sender, MouseEventArgs e)
        {
            txtcvvkayit.Text = "";
        }

        private void txtibankayit_MouseClick(object sender, MouseEventArgs e)
        {
            txtibankayit.Text = "";
        }

        private void txthesapbakiyesikayit_MouseClick(object sender, MouseEventArgs e)
        {
            txthesapbakiyesikayit.Text = "";
        }

        private void txtşifretekrarkayit_MouseClick(object sender, MouseEventArgs e)
        {
            txtşifretekrarkayit.Text = "";
        }

        private void zirtpirtbankyenigiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
