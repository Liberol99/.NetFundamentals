namespace FastReportCSharp
{
    partial class Form1
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
            this.btnKullanicilar = new System.Windows.Forms.Button();
            this.btnBankaBakiye = new System.Windows.Forms.Button();
            this.btnStok = new System.Windows.Forms.Button();
            this.chkTasarim = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnKullanicilar
            // 
            this.btnKullanicilar.Location = new System.Drawing.Point(12, 39);
            this.btnKullanicilar.Name = "btnKullanicilar";
            this.btnKullanicilar.Size = new System.Drawing.Size(173, 23);
            this.btnKullanicilar.TabIndex = 0;
            this.btnKullanicilar.Text = "Rapor Kullanıcılar";
            this.btnKullanicilar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKullanicilar.UseVisualStyleBackColor = true;
            this.btnKullanicilar.Click += new System.EventHandler(this.btnKullanicilar_Click);
            // 
            // btnBankaBakiye
            // 
            this.btnBankaBakiye.Location = new System.Drawing.Point(12, 68);
            this.btnBankaBakiye.Name = "btnBankaBakiye";
            this.btnBankaBakiye.Size = new System.Drawing.Size(173, 23);
            this.btnBankaBakiye.TabIndex = 0;
            this.btnBankaBakiye.Text = "Rapor Banka Bakiye";
            this.btnBankaBakiye.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBankaBakiye.UseVisualStyleBackColor = true;
            this.btnBankaBakiye.Click += new System.EventHandler(this.btnBankaBakiye_Click);
            // 
            // btnStok
            // 
            this.btnStok.Location = new System.Drawing.Point(12, 97);
            this.btnStok.Name = "btnStok";
            this.btnStok.Size = new System.Drawing.Size(173, 23);
            this.btnStok.TabIndex = 0;
            this.btnStok.Text = "Rapor Stok";
            this.btnStok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStok.UseVisualStyleBackColor = true;
            this.btnStok.Click += new System.EventHandler(this.btnStok_Click);
            // 
            // chkTasarim
            // 
            this.chkTasarim.AutoSize = true;
            this.chkTasarim.Location = new System.Drawing.Point(12, 12);
            this.chkTasarim.Name = "chkTasarim";
            this.chkTasarim.Size = new System.Drawing.Size(147, 17);
            this.chkTasarim.TabIndex = 1;
            this.chkTasarim.Text = "Rapor Görünümü Tasarım";
            this.chkTasarim.UseVisualStyleBackColor = true;
            this.chkTasarim.CheckedChanged += new System.EventHandler(this.chkTasarim_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 151);
            this.Controls.Add(this.chkTasarim);
            this.Controls.Add(this.btnStok);
            this.Controls.Add(this.btnBankaBakiye);
            this.Controls.Add(this.btnKullanicilar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKullanicilar;
        private System.Windows.Forms.Button btnBankaBakiye;
        private System.Windows.Forms.Button btnStok;
        private System.Windows.Forms.CheckBox chkTasarim;
    }
}

