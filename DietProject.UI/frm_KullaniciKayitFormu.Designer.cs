﻿namespace DietProject.UI
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
            panel = new Panel();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblAd.Location = new Point(72, 135);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(32, 20);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSoyad.Location = new Point(72, 198);
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
            lblEposta.Location = new Point(72, 263);
            lblEposta.Name = "lblEposta";
            lblEposta.Size = new Size(58, 20);
            lblEposta.TabIndex = 2;
            lblEposta.Text = "Eposta:";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSifre.Location = new Point(72, 331);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(44, 20);
            lblSifre.TabIndex = 3;
            lblSifre.Text = "Şifre:";
            // 
            // lblDT
            // 
            lblDT.AutoSize = true;
            lblDT.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblDT.Location = new Point(337, 133);
            lblDT.Name = "lblDT";
            lblDT.Size = new Size(106, 20);
            lblDT.TabIndex = 4;
            lblDT.Text = "Doğum Tarihi:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(136, 132);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 5;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(136, 198);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 6;
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(136, 260);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(125, 27);
            txtEposta.TabIndex = 7;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(136, 331);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(125, 27);
            txtSifre.TabIndex = 8;
            // 
            // btnKullaniciKaydet
            // 
            btnKullaniciKaydet.BackColor = Color.DarkKhaki;
            btnKullaniciKaydet.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnKullaniciKaydet.Location = new Point(448, 449);
            btnKullaniciKaydet.Name = "btnKullaniciKaydet";
            btnKullaniciKaydet.Size = new Size(100, 50);
            btnKullaniciKaydet.TabIndex = 10;
            btnKullaniciKaydet.Text = "KAYDET";
            btnKullaniciKaydet.UseVisualStyleBackColor = false;
            btnKullaniciKaydet.Click += btnKullaniciKaydet_Click;
            // 
            // btnKullaniciKayitİptal
            // 
            btnKullaniciKayitİptal.BackColor = Color.Khaki;
            btnKullaniciKayitİptal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnKullaniciKayitİptal.Location = new Point(567, 449);
            btnKullaniciKayitİptal.Name = "btnKullaniciKayitİptal";
            btnKullaniciKayitİptal.Size = new Size(100, 50);
            btnKullaniciKayitİptal.TabIndex = 11;
            btnKullaniciKayitİptal.Text = "İPTAL";
            btnKullaniciKayitİptal.UseVisualStyleBackColor = false;
            btnKullaniciKayitİptal.Click += btnKullaniciKayitİptal_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(72, 67);
            label6.Name = "label6";
            label6.Size = new Size(233, 31);
            label6.TabIndex = 12;
            label6.Text = "Kullanıcı Kayıt Formu";
            // 
            // txtBoy
            // 
            txtBoy.Location = new Point(464, 198);
            txtBoy.Name = "txtBoy";
            txtBoy.Size = new Size(190, 27);
            txtBoy.TabIndex = 14;
            // 
            // lblBoy
            // 
            lblBoy.AutoSize = true;
            lblBoy.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblBoy.Location = new Point(337, 198);
            lblBoy.Name = "lblBoy";
            lblBoy.Size = new Size(39, 20);
            lblBoy.TabIndex = 13;
            lblBoy.Text = "Boy:";
            // 
            // txtKilo
            // 
            txtKilo.Location = new Point(464, 267);
            txtKilo.Name = "txtKilo";
            txtKilo.Size = new Size(190, 27);
            txtKilo.TabIndex = 16;
            // 
            // lblKilo
            // 
            lblKilo.AutoSize = true;
            lblKilo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblKilo.Location = new Point(337, 267);
            lblKilo.Name = "lblKilo";
            lblKilo.Size = new Size(39, 20);
            lblKilo.TabIndex = 15;
            lblKilo.Text = "Kilo:";
            // 
            // cbYıl
            // 
            cbYıl.DropDownStyle = ComboBoxStyle.DropDownList;
            cbYıl.FormattingEnabled = true;
            cbYıl.Location = new Point(567, 132);
            cbYıl.Margin = new Padding(3, 4, 3, 4);
            cbYıl.Name = "cbYıl";
            cbYıl.Size = new Size(87, 28);
            cbYıl.TabIndex = 17;
            // 
            // cbAy
            // 
            cbAy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAy.FormattingEnabled = true;
            cbAy.Location = new Point(516, 132);
            cbAy.Margin = new Padding(3, 4, 3, 4);
            cbAy.Name = "cbAy";
            cbAy.Size = new Size(44, 28);
            cbAy.TabIndex = 18;
            // 
            // cbGün
            // 
            cbGün.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGün.FormattingEnabled = true;
            cbGün.Location = new Point(464, 132);
            cbGün.Margin = new Padding(3, 4, 3, 4);
            cbGün.Name = "cbGün";
            cbGün.Size = new Size(44, 28);
            cbGün.TabIndex = 19;
            // 
            // panel
            // 
            panel.BackColor = Color.SandyBrown;
            panel.Dock = DockStyle.Top;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(750, 29);
            panel.TabIndex = 20;
            panel.MouseDown += panel_MouseDown;
            // 
            // frm_KullaniciKayitFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(750, 550);
            Controls.Add(panel);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_KullaniciKayitFormu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yeni Kullanıcı Kayıt ";
            Load += frm_KullaniciKayitFormu_Load;
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
        private Panel panel;
    }
}