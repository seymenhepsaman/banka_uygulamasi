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
    public partial class hesaplar : Form
    {

        public string adsoyad2  { get; set; }
        
        SqlConnection con = new SqlConnection("Data Source= DESKTOP-R5VREJK; Initial Catalog= zirtpirtbank; Integrated Security=TRUE");

        public string iban { get; set; }
        public hesaplar()
        {
            InitializeComponent();
        }

        private void hesaplar_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            zirtpirtbankgirisanasayfa zirtpirtbankgirisanasayfa = new zirtpirtbankgirisanasayfa();
            this.Hide();
            zirtpirtbankgirisanasayfa.Show();
            zirtpirtbankgirisanasayfa.label1.Text = label5.Text;
            zirtpirtbankgirisanasayfa.label2.Text = label6.Text;
            zirtpirtbankgirisanasayfa.label5.Text = adsoyad2;
            //aa.label5.Text = adsoyad2.ToString();

        }

        private void hesaplar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
