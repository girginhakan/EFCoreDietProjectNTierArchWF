namespace DietProject.UI
{
    partial class frm_KullaniciKayitFormu
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
            lblSoyad.Location = new Point(29, 168);
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
            lblEposta.Location = new Point(29, 233);
            lblEposta.Name = "lblEposta";
            lblEposta.Size = new Size(58, 20);
            lblEposta.TabIndex = 2;
            lblEposta.Text = "Eposta:";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSifre.Location = new Point(29, 284);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(44, 20);
            lblSifre.TabIndex = 3;
            lblSifre.Text = "Şifre:";
            // 
            // lblDT
            // 
            lblDT.AutoSize = true;
            lblDT.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblDT.Location = new Point(287, 99);
            lblDT.Name = "lblDT";
            lblDT.Size = new Size(106, 20);
            lblDT.TabIndex = 4;
            lblDT.Text = "Doğum Tarihi:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(85, 99);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 5;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(85, 164);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 6;
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(85, 229);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(125, 27);
            txtEposta.TabIndex = 7;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(85, 280);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(125, 27);
            txtSifre.TabIndex = 8;
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
            btnKullaniciKaydet.Click += btnKullaniciKaydet_Click;
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
            btnKullaniciKayitİptal.Click += btnKullaniciKayitİptal_Click;
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
            // txtBoy
            // 
            txtBoy.Location = new Point(395, 229);
            txtBoy.Name = "txtBoy";
            txtBoy.Size = new Size(125, 27);
            txtBoy.TabIndex = 14;
            // 
            // lblBoy
            // 
            lblBoy.AutoSize = true;
            lblBoy.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblBoy.Location = new Point(287, 229);
            lblBoy.Name = "lblBoy";
            lblBoy.Size = new Size(39, 20);
            lblBoy.TabIndex = 13;
            lblBoy.Text = "Boy:";
            // 
            // txtKilo
            // 
            txtKilo.Location = new Point(395, 295);
            txtKilo.Name = "txtKilo";
            txtKilo.Size = new Size(125, 27);
            txtKilo.TabIndex = 16;
            // 
            // lblKilo
            // 
            lblKilo.AutoSize = true;
            lblKilo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblKilo.Location = new Point(287, 295);
            lblKilo.Name = "lblKilo";
            lblKilo.Size = new Size(39, 20);
            lblKilo.TabIndex = 15;
            lblKilo.Text = "Kilo:";
            // 
            // cbYıl
            // 
            cbYıl.FormattingEnabled = true;
            cbYıl.Location = new Point(433, 145);
            cbYıl.Margin = new Padding(3, 4, 3, 4);
            cbYıl.Name = "cbYıl";
            cbYıl.Size = new Size(87, 28);
            cbYıl.TabIndex = 17;
            // 
            // cbAy
            // 
            cbAy.FormattingEnabled = true;
            cbAy.Location = new Point(382, 145);
            cbAy.Margin = new Padding(3, 4, 3, 4);
            cbAy.Name = "cbAy";
            cbAy.Size = new Size(44, 28);
            cbAy.TabIndex = 18;
            // 
            // cbGün
            // 
            cbGün.FormattingEnabled = true;
            cbGün.Location = new Point(330, 145);
            cbGün.Margin = new Padding(3, 4, 3, 4);
            cbGün.Name = "cbGün";
            cbGün.Size = new Size(44, 28);
            cbGün.TabIndex = 19;
            // 
            // frm_KullaniciKayitFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(583, 493);
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
            Name = "frm_KullaniciKayitFormu";
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