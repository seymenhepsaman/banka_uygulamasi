
namespace zirtpirtbankk
{
    partial class zirtpirtbankanasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(zirtpirtbankanasayfa));
            this.zırtpırtbank = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txttcanasayfa = new System.Windows.Forms.TextBox();
            this.btngiris = new System.Windows.Forms.Button();
            this.btnyenigiris = new System.Windows.Forms.Button();
            this.txtsifreanasayfa = new System.Windows.Forms.TextBox();
            this.hosgeldiniz = new System.Windows.Forms.Label();
            this.btng = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // zırtpırtbank
            // 
            this.zırtpırtbank.AutoSize = true;
            this.zırtpırtbank.BackColor = System.Drawing.Color.Transparent;
            this.zırtpırtbank.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zırtpırtbank.ForeColor = System.Drawing.Color.Black;
            this.zırtpırtbank.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.zırtpırtbank.Location = new System.Drawing.Point(33, 29);
            this.zırtpırtbank.Name = "zırtpırtbank";
            this.zırtpırtbank.Size = new System.Drawing.Size(251, 30);
            this.zırtpırtbank.TabIndex = 0;
            this.zırtpırtbank.Text = "ZIRT PIRT BANK";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(138, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 53);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txttcanasayfa
            // 
            this.txttcanasayfa.BackColor = System.Drawing.Color.Black;
            this.txttcanasayfa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttcanasayfa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttcanasayfa.ForeColor = System.Drawing.Color.Gray;
            this.txttcanasayfa.Location = new System.Drawing.Point(116, 165);
            this.txttcanasayfa.Name = "txttcanasayfa";
            this.txttcanasayfa.Size = new System.Drawing.Size(100, 23);
            this.txttcanasayfa.TabIndex = 1;
            this.txttcanasayfa.Text = "TC GİRİNİZ";
            this.txttcanasayfa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txttcanasayfa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txttcanasayfa_MouseClick);
            this.txttcanasayfa.TextChanged += new System.EventHandler(this.txttcanasayfa_TextChanged);
            this.txttcanasayfa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttcanasayfa_KeyPress);
            // 
            // btngiris
            // 
            this.btngiris.BackColor = System.Drawing.Color.Gray;
            this.btngiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngiris.ForeColor = System.Drawing.Color.Black;
            this.btngiris.Location = new System.Drawing.Point(38, 261);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(96, 33);
            this.btngiris.TabIndex = 4;
            this.btngiris.Text = "GİRİŞ";
            this.btngiris.UseVisualStyleBackColor = false;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // btnyenigiris
            // 
            this.btnyenigiris.BackColor = System.Drawing.Color.Gray;
            this.btnyenigiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnyenigiris.ForeColor = System.Drawing.Color.Black;
            this.btnyenigiris.Location = new System.Drawing.Point(189, 261);
            this.btnyenigiris.Name = "btnyenigiris";
            this.btnyenigiris.Size = new System.Drawing.Size(95, 33);
            this.btnyenigiris.TabIndex = 5;
            this.btnyenigiris.Text = "YENİ GİRİŞ";
            this.btnyenigiris.UseVisualStyleBackColor = false;
            this.btnyenigiris.Click += new System.EventHandler(this.btnyenigiris_Click);
            // 
            // txtsifreanasayfa
            // 
            this.txtsifreanasayfa.BackColor = System.Drawing.Color.Black;
            this.txtsifreanasayfa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsifreanasayfa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsifreanasayfa.ForeColor = System.Drawing.Color.Gray;
            this.txtsifreanasayfa.Location = new System.Drawing.Point(116, 215);
            this.txtsifreanasayfa.Name = "txtsifreanasayfa";
            this.txtsifreanasayfa.Size = new System.Drawing.Size(100, 23);
            this.txtsifreanasayfa.TabIndex = 2;
            this.txtsifreanasayfa.Text = "ŞİFRE GİRİNİZ";
            this.txtsifreanasayfa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsifreanasayfa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtsifreanasayfa_MouseClick);
            this.txtsifreanasayfa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsifreanasayfa_KeyPress);
            // 
            // hosgeldiniz
            // 
            this.hosgeldiniz.AutoSize = true;
            this.hosgeldiniz.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hosgeldiniz.ForeColor = System.Drawing.Color.Black;
            this.hosgeldiniz.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hosgeldiniz.Location = new System.Drawing.Point(92, 327);
            this.hosgeldiniz.Name = "hosgeldiniz";
            this.hosgeldiniz.Size = new System.Drawing.Size(143, 21);
            this.hosgeldiniz.TabIndex = 7;
            this.hosgeldiniz.Text = "HOŞGELDİNİZ";
            // 
            // btng
            // 
            this.btng.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btng.BackgroundImage")));
            this.btng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btng.Location = new System.Drawing.Point(222, 215);
            this.btng.Name = "btng";
            this.btng.Size = new System.Drawing.Size(27, 23);
            this.btng.TabIndex = 3;
            this.btng.UseVisualStyleBackColor = true;
            this.btng.Click += new System.EventHandler(this.btng_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "SAAT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(12, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "TARİH";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-710, -140);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1741, 750);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // zirtpirtbankanasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(321, 474);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btng);
            this.Controls.Add(this.hosgeldiniz);
            this.Controls.Add(this.txtsifreanasayfa);
            this.Controls.Add(this.btnyenigiris);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.txttcanasayfa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.zırtpırtbank);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "zirtpirtbankanasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZIRT PIRT BANK";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.zirtpirtbankanasayfa_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label zırtpırtbank;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txttcanasayfa;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Button btnyenigiris;
        private System.Windows.Forms.TextBox txtsifreanasayfa;
        private System.Windows.Forms.Label hosgeldiniz;
        private System.Windows.Forms.Button btng;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

