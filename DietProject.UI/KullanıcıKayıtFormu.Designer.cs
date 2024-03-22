namespace DietProject.UI
{
    partial class KullanıcıKayıtFormu
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
            lblDT = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtEposta = new TextBox();
            txtSifre = new TextBox();
            btnKullaniciKaydet = new Button();
            btnKullaniciKayitİptal = new Button();
            label6 = new Label();
            txtBoy = new TextBox();
            lblBoy = new Label();
            txtKilo = new TextBox();
            lblKilo = new Label();
            cbYıl = new ComboBox();
            cbAy = new ComboBox();
            cbGün = new ComboBox();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblAd.Location = new Point(25, 77);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(25, 15);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSoyad.Location = new Point(25, 126);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(43, 15);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Soyad:";
            lblSoyad.Click += label2_Click;
            // 
            // lblEposta
            // 
            lblEposta.AutoSize = true;
            lblEposta.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblEposta.Location = new Point(25, 175);
            lblEposta.Name = "lblEposta";
            lblEposta.Size = new Size(45, 15);
            lblEposta.TabIndex = 2;
            lblEposta.Text = "Eposta:";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSifre.Location = new Point(25, 213);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(34, 15);
            lblSifre.TabIndex = 3;
            lblSifre.Text = "Şifre:";
            // 
            // lblDT
            // 
            lblDT.AutoSize = true;
            lblDT.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblDT.Location = new Point(251, 74);
            lblDT.Name = "lblDT";
            lblDT.Size = new Size(83, 15);
            lblDT.TabIndex = 4;
            lblDT.Text = "Doğum Tarihi:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(74, 74);
            txtAd.Margin = new Padding(3, 2, 3, 2);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(110, 23);
            txtAd.TabIndex = 5;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(74, 123);
            txtSoyad.Margin = new Padding(3, 2, 3, 2);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(110, 23);
            txtSoyad.TabIndex = 6;
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(74, 172);
            txtEposta.Margin = new Padding(3, 2, 3, 2);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(110, 23);
            txtEposta.TabIndex = 7;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(74, 210);
            txtSifre.Margin = new Padding(3, 2, 3, 2);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(110, 23);
            txtSifre.TabIndex = 8;
            // 
            // btnKullaniciKaydet
            // 
            btnKullaniciKaydet.BackColor = Color.Lime;
            btnKullaniciKaydet.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnKullaniciKaydet.Location = new Point(323, 327);
            btnKullaniciKaydet.Margin = new Padding(3, 2, 3, 2);
            btnKullaniciKaydet.Name = "btnKullaniciKaydet";
            btnKullaniciKaydet.Size = new Size(86, 27);
            btnKullaniciKaydet.TabIndex = 10;
            btnKullaniciKaydet.Text = "KAYDET";
            btnKullaniciKaydet.UseVisualStyleBackColor = false;
            btnKullaniciKaydet.Click += btnKullaniciKaydet_Click;
            // 
            // btnKullaniciKayitİptal
            // 
            btnKullaniciKayitİptal.BackColor = Color.Crimson;
            btnKullaniciKayitİptal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnKullaniciKayitİptal.Location = new Point(414, 327);
            btnKullaniciKayitİptal.Margin = new Padding(3, 2, 3, 2);
            btnKullaniciKayitİptal.Name = "btnKullaniciKayitİptal";
            btnKullaniciKayitİptal.Size = new Size(86, 27);
            btnKullaniciKayitİptal.TabIndex = 11;
            btnKullaniciKayitİptal.Text = "İPTAL";
            btnKullaniciKayitİptal.UseVisualStyleBackColor = false;
            btnKullaniciKayitİptal.Click += btnKullaniciKayitİptal_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(19, 25);
            label6.Name = "label6";
            label6.Size = new Size(195, 25);
            label6.TabIndex = 12;
            label6.Text = "Kullanıcı Kayıt Formu";
            // 
            // txtBoy
            // 
            txtBoy.Location = new Point(346, 172);
            txtBoy.Margin = new Padding(3, 2, 3, 2);
            txtBoy.Name = "txtBoy";
            txtBoy.Size = new Size(110, 23);
            txtBoy.TabIndex = 14;
            // 
            // lblBoy
            // 
            lblBoy.AutoSize = true;
            lblBoy.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblBoy.Location = new Point(251, 172);
            lblBoy.Name = "lblBoy";
            lblBoy.Size = new Size(30, 15);
            lblBoy.TabIndex = 13;
            lblBoy.Text = "Boy:";
            // 
            // txtKilo
            // 
            txtKilo.Location = new Point(346, 221);
            txtKilo.Margin = new Padding(3, 2, 3, 2);
            txtKilo.Name = "txtKilo";
            txtKilo.Size = new Size(110, 23);
            txtKilo.TabIndex = 16;
            // 
            // lblKilo
            // 
            lblKilo.AutoSize = true;
            lblKilo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblKilo.Location = new Point(251, 221);
            lblKilo.Name = "lblKilo";
            lblKilo.Size = new Size(30, 15);
            lblKilo.TabIndex = 15;
            lblKilo.Text = "Kilo:";
            // 
            // cbYıl
            // 
            cbYıl.FormattingEnabled = true;
            cbYıl.Location = new Point(379, 109);
            cbYıl.Name = "cbYıl";
            cbYıl.Size = new Size(77, 23);
            cbYıl.TabIndex = 17;
            // 
            // cbAy
            // 
            cbAy.FormattingEnabled = true;
            cbAy.Location = new Point(334, 109);
            cbAy.Name = "cbAy";
            cbAy.Size = new Size(39, 23);
            cbAy.TabIndex = 18;
            // 
            // cbGün
            // 
            cbGün.FormattingEnabled = true;
            cbGün.Location = new Point(289, 109);
            cbGün.Name = "cbGün";
            cbGün.Size = new Size(39, 23);
            cbGün.TabIndex = 19;
            // 
            // KullanıcıKayıtFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(510, 370);
            Controls.Add(cbGün);
            Controls.Add(cbAy);
            Controls.Add(cbYıl);
            Controls.Add(txtKilo);
            Controls.Add(lblKilo);
            Controls.Add(txtBoy);
            Controls.Add(lblBoy);
            Controls.Add(label6);
            Controls.Add(btnKullaniciKayitİptal);
            Controls.Add(btnKullaniciKaydet);
            Controls.Add(txtSifre);
            Controls.Add(txtEposta);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(lblDT);
            Controls.Add(lblSifre);
            Controls.Add(lblEposta);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Margin = new Padding(3, 2, 3, 2);
            Name = "KullanıcıKayıtFormu";
            Text = "Yeni Kullanıcı Kayıt ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private Label lblSoyad;
        private Label lblEposta;
        private Label lblSifre;
        private Label lblDT;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtEposta;
        private TextBox txtSifre;
        private Button btnKullaniciKaydet;
        private Button btnKullaniciKayitİptal;
        private Label label6;
        private TextBox txtBoy;
        private Label lblBoy;
        private TextBox txtKilo;
        private Label lblKilo;
        private ComboBox cbYıl;
        private ComboBox cbAy;
        private ComboBox cbGün;
    }
}