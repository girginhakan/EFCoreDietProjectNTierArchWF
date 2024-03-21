namespace DietProject.UI
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAd = new Label();
            lblSoyad = new Label();
            lblEposta = new Label();
            lblSifre = new Label();
            lblYas = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtEposta = new TextBox();
            txtSifre = new TextBox();
            txtYas = new TextBox();
            btnKullaniciKaydet = new Button();
            btnKullaniciKayitİptal = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblAd.Location = new Point(29, 103);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(32, 20);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSoyad.Location = new Point(29, 160);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(55, 20);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Soyad:";
            lblSoyad.Click += label2_Click;
            // 
            // lblEposta
            // 
            lblEposta.AutoSize = true;
            lblEposta.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblEposta.Location = new Point(29, 230);
            lblEposta.Name = "lblEposta";
            lblEposta.Size = new Size(58, 20);
            lblEposta.TabIndex = 2;
            lblEposta.Text = "Eposta:";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSifre.Location = new Point(300, 131);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(44, 20);
            lblSifre.TabIndex = 3;
            lblSifre.Text = "Şifre:";
            // 
            // lblYas
            // 
            lblYas.AutoSize = true;
            lblYas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblYas.Location = new Point(300, 191);
            lblYas.Name = "lblYas";
            lblYas.Size = new Size(35, 20);
            lblYas.TabIndex = 4;
            lblYas.Text = "Yaş:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(88, 100);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 5;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(88, 157);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 6;
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(88, 223);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(125, 27);
            txtEposta.TabIndex = 7;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(358, 128);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(125, 27);
            txtSifre.TabIndex = 8;
            // 
            // txtYas
            // 
            txtYas.Location = new Point(358, 187);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(125, 27);
            txtYas.TabIndex = 9;
            // 
            // btnKullaniciKaydet
            // 
            btnKullaniciKaydet.BackColor = Color.Lime;
            btnKullaniciKaydet.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnKullaniciKaydet.Location = new Point(369, 436);
            btnKullaniciKaydet.Name = "btnKullaniciKaydet";
            btnKullaniciKaydet.Size = new Size(98, 36);
            btnKullaniciKaydet.TabIndex = 10;
            btnKullaniciKaydet.Text = "KAYDET";
            btnKullaniciKaydet.UseVisualStyleBackColor = false;
            // 
            // btnKullaniciKayitİptal
            // 
            btnKullaniciKayitİptal.BackColor = Color.Crimson;
            btnKullaniciKayitİptal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnKullaniciKayitİptal.Location = new Point(473, 436);
            btnKullaniciKayitİptal.Name = "btnKullaniciKayitİptal";
            btnKullaniciKayitİptal.Size = new Size(98, 36);
            btnKullaniciKayitİptal.TabIndex = 11;
            btnKullaniciKayitİptal.Text = "İPTAL";
            btnKullaniciKayitİptal.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(22, 33);
            label6.Name = "label6";
            label6.Size = new Size(233, 31);
            label6.TabIndex = 12;
            label6.Text = "Kullanıcı Kayıt Formu";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(583, 494);
            Controls.Add(label6);
            Controls.Add(btnKullaniciKayitİptal);
            Controls.Add(btnKullaniciKaydet);
            Controls.Add(txtYas);
            Controls.Add(txtSifre);
            Controls.Add(txtEposta);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(lblYas);
            Controls.Add(lblSifre);
            Controls.Add(lblEposta);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Name = "Form2";
            Text = "Yeni Kullanıcı Kayıt ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private Label lblSoyad;
        private Label lblEposta;
        private Label lblSifre;
        private Label lblYas;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtEposta;
        private TextBox txtSifre;
        private TextBox txtYas;
        private Button btnKullaniciKaydet;
        private Button btnKullaniciKayitİptal;
        private Label label6;
    }
}