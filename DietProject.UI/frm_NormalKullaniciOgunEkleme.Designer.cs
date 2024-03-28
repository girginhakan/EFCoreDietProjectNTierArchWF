﻿namespace DietProject.UI
{
    partial class frm_NormalKullaniciOgunEkleme
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
            lblOgun = new Label();
            cbOgun = new ComboBox();
            lblYemekKategori = new Label();
            cbYemekKategori = new ComboBox();
            cbYemekCesidi = new ComboBox();
            lblYemekCesidi = new Label();
            lblPorsiyonMiktari = new Label();
            lblPorsiyonBirimi = new Label();
            cbPorsiyonBirimi = new ComboBox();
            btnKullaniciKayitİptal = new Button();
            btnKullaniciYemekKaydet = new Button();
            panel = new Panel();
            txtPorsiyonMiktari = new TextBox();
            btnGuncelle = new Button();
            SuspendLayout();
            // 
            // lblOgun
            // 
            lblOgun.AutoSize = true;
            lblOgun.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblOgun.Location = new Point(174, 123);
            lblOgun.Name = "lblOgun";
            lblOgun.Size = new Size(47, 20);
            lblOgun.TabIndex = 0;
            lblOgun.Text = "Öğün";
            // 
            // cbOgun
            // 
            cbOgun.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOgun.FormattingEnabled = true;
            cbOgun.Location = new Point(321, 115);
            cbOgun.Name = "cbOgun";
            cbOgun.Size = new Size(151, 28);
            cbOgun.TabIndex = 1;
            // 
            // lblYemekKategori
            // 
            lblYemekKategori.AutoSize = true;
            lblYemekKategori.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblYemekKategori.Location = new Point(174, 176);
            lblYemekKategori.Name = "lblYemekKategori";
            lblYemekKategori.Size = new Size(126, 20);
            lblYemekKategori.TabIndex = 2;
            lblYemekKategori.Text = "Yemek Kategorisi";
            // 
            // cbYemekKategori
            // 
            cbYemekKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cbYemekKategori.FormattingEnabled = true;
            cbYemekKategori.Location = new Point(321, 171);
            cbYemekKategori.Name = "cbYemekKategori";
            cbYemekKategori.Size = new Size(151, 28);
            cbYemekKategori.TabIndex = 3;
            cbYemekKategori.SelectedIndexChanged += cbYemekKategori_SelectedIndexChanged;
            // 
            // cbYemekCesidi
            // 
            cbYemekCesidi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbYemekCesidi.FormattingEnabled = true;
            cbYemekCesidi.Location = new Point(321, 235);
            cbYemekCesidi.Name = "cbYemekCesidi";
            cbYemekCesidi.Size = new Size(151, 28);
            cbYemekCesidi.TabIndex = 4;
            // 
            // lblYemekCesidi
            // 
            lblYemekCesidi.AutoSize = true;
            lblYemekCesidi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblYemekCesidi.Location = new Point(174, 239);
            lblYemekCesidi.Name = "lblYemekCesidi";
            lblYemekCesidi.Size = new Size(98, 20);
            lblYemekCesidi.TabIndex = 5;
            lblYemekCesidi.Text = "Yemek Çeşidi";
            // 
            // lblPorsiyonMiktari
            // 
            lblPorsiyonMiktari.AutoSize = true;
            lblPorsiyonMiktari.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPorsiyonMiktari.Location = new Point(174, 304);
            lblPorsiyonMiktari.Name = "lblPorsiyonMiktari";
            lblPorsiyonMiktari.Size = new Size(121, 20);
            lblPorsiyonMiktari.TabIndex = 6;
            lblPorsiyonMiktari.Text = "Porsiyon Miktarı";
            // 
            // lblPorsiyonBirimi
            // 
            lblPorsiyonBirimi.AutoSize = true;
            lblPorsiyonBirimi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPorsiyonBirimi.Location = new Point(174, 364);
            lblPorsiyonBirimi.Name = "lblPorsiyonBirimi";
            lblPorsiyonBirimi.Size = new Size(112, 20);
            lblPorsiyonBirimi.TabIndex = 8;
            lblPorsiyonBirimi.Text = "Porsiyon Birimi";
            // 
            // cbPorsiyonBirimi
            // 
            cbPorsiyonBirimi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPorsiyonBirimi.FormattingEnabled = true;
            cbPorsiyonBirimi.Location = new Point(321, 361);
            cbPorsiyonBirimi.Name = "cbPorsiyonBirimi";
            cbPorsiyonBirimi.Size = new Size(151, 28);
            cbPorsiyonBirimi.TabIndex = 9;
            // 
            // btnKullaniciKayitİptal
            // 
            btnKullaniciKayitİptal.BackColor = Color.Khaki;
            btnKullaniciKayitİptal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnKullaniciKayitİptal.Location = new Point(492, 432);
            btnKullaniciKayitİptal.Name = "btnKullaniciKayitİptal";
            btnKullaniciKayitİptal.Size = new Size(140, 50);
            btnKullaniciKayitİptal.TabIndex = 13;
            btnKullaniciKayitİptal.Text = "İPTAL";
            btnKullaniciKayitİptal.UseVisualStyleBackColor = false;
            btnKullaniciKayitİptal.Click += btnKullaniciKayitİptal_Click;
            // 
            // btnKullaniciYemekKaydet
            // 
            btnKullaniciYemekKaydet.BackColor = Color.DarkKhaki;
            btnKullaniciYemekKaydet.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnKullaniciYemekKaydet.Location = new Point(332, 432);
            btnKullaniciYemekKaydet.Name = "btnKullaniciYemekKaydet";
            btnKullaniciYemekKaydet.Size = new Size(140, 50);
            btnKullaniciYemekKaydet.TabIndex = 12;
            btnKullaniciYemekKaydet.Text = "Yeni Kayıt";
            btnKullaniciYemekKaydet.UseVisualStyleBackColor = false;
            btnKullaniciYemekKaydet.Click += btnKullaniciYemekKaydet_Click;
            // 
            // panel
            // 
            panel.BackColor = Color.SandyBrown;
            panel.Dock = DockStyle.Top;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(750, 29);
            panel.TabIndex = 14;
            panel.MouseDown += panel_MouseDown;
            // 
            // txtPorsiyonMiktari
            // 
            txtPorsiyonMiktari.Location = new Point(321, 301);
            txtPorsiyonMiktari.Name = "txtPorsiyonMiktari";
            txtPorsiyonMiktari.Size = new Size(151, 27);
            txtPorsiyonMiktari.TabIndex = 15;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Goldenrod;
            btnGuncelle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuncelle.Location = new Point(174, 432);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(140, 50);
            btnGuncelle.TabIndex = 16;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // frm_NormalKullaniciOgunEkleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(750, 550);
            Controls.Add(btnGuncelle);
            Controls.Add(txtPorsiyonMiktari);
            Controls.Add(panel);
            Controls.Add(btnKullaniciKayitİptal);
            Controls.Add(btnKullaniciYemekKaydet);
            Controls.Add(cbPorsiyonBirimi);
            Controls.Add(lblPorsiyonBirimi);
            Controls.Add(lblPorsiyonMiktari);
            Controls.Add(lblYemekCesidi);
            Controls.Add(cbYemekCesidi);
            Controls.Add(cbYemekKategori);
            Controls.Add(lblYemekKategori);
            Controls.Add(cbOgun);
            Controls.Add(lblOgun);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_NormalKullaniciOgunEkleme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Öğün Ekle İşlemi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOgun;
        private ComboBox cbOgun;
        private Label lblYemekKategori;
        private ComboBox cbYemekKategori;
        private ComboBox cbYemekCesidi;
        private Label lblYemekCesidi;
        private Label lblPorsiyonMiktari;
        private Label lblPorsiyonBirimi;
        private ComboBox cbPorsiyonBirimi;
        private Button btnKullaniciKayitİptal;
        private Button btnKullaniciYemekKaydet;
        private Panel panel;
        private TextBox txtPorsiyonMiktari;
        private Button btnGuncelle;
    }
}