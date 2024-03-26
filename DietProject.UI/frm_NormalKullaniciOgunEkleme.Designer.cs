namespace DietProject.UI
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
            cbPorsiyonMiktari = new ComboBox();
            lblPorsiyonBirimi = new Label();
            cbPorsiyonBirimi = new ComboBox();
            btnKullaniciKayitİptal = new Button();
            btnKullaniciKaydet = new Button();
            panel = new Panel();
            SuspendLayout();
            // 
            // lblOgun
            // 
            lblOgun.AutoSize = true;
            lblOgun.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblOgun.Location = new Point(37, 59);
            lblOgun.Name = "lblOgun";
            lblOgun.Size = new Size(47, 20);
            lblOgun.TabIndex = 0;
            lblOgun.Text = "Öğün";
            // 
            // cbOgun
            // 
            cbOgun.FormattingEnabled = true;
            cbOgun.Location = new Point(184, 51);
            cbOgun.Name = "cbOgun";
            cbOgun.Size = new Size(151, 28);
            cbOgun.TabIndex = 1;
            // 
            // lblYemekKategori
            // 
            lblYemekKategori.AutoSize = true;
            lblYemekKategori.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblYemekKategori.Location = new Point(37, 112);
            lblYemekKategori.Name = "lblYemekKategori";
            lblYemekKategori.Size = new Size(126, 20);
            lblYemekKategori.TabIndex = 2;
            lblYemekKategori.Text = "Yemek Kategorisi";
            // 
            // cbYemekKategori
            // 
            cbYemekKategori.FormattingEnabled = true;
            cbYemekKategori.Location = new Point(184, 107);
            cbYemekKategori.Name = "cbYemekKategori";
            cbYemekKategori.Size = new Size(151, 28);
            cbYemekKategori.TabIndex = 3;
            // 
            // cbYemekCesidi
            // 
            cbYemekCesidi.FormattingEnabled = true;
            cbYemekCesidi.Location = new Point(184, 171);
            cbYemekCesidi.Name = "cbYemekCesidi";
            cbYemekCesidi.Size = new Size(151, 28);
            cbYemekCesidi.TabIndex = 4;
            // 
            // lblYemekCesidi
            // 
            lblYemekCesidi.AutoSize = true;
            lblYemekCesidi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblYemekCesidi.Location = new Point(37, 175);
            lblYemekCesidi.Name = "lblYemekCesidi";
            lblYemekCesidi.Size = new Size(98, 20);
            lblYemekCesidi.TabIndex = 5;
            lblYemekCesidi.Text = "Yemek Çeşidi";
            // 
            // lblPorsiyonMiktari
            // 
            lblPorsiyonMiktari.AutoSize = true;
            lblPorsiyonMiktari.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPorsiyonMiktari.Location = new Point(37, 240);
            lblPorsiyonMiktari.Name = "lblPorsiyonMiktari";
            lblPorsiyonMiktari.Size = new Size(121, 20);
            lblPorsiyonMiktari.TabIndex = 6;
            lblPorsiyonMiktari.Text = "Porsiyon Miktarı";
            // 
            // cbPorsiyonMiktari
            // 
            cbPorsiyonMiktari.FormattingEnabled = true;
            cbPorsiyonMiktari.Location = new Point(184, 236);
            cbPorsiyonMiktari.Name = "cbPorsiyonMiktari";
            cbPorsiyonMiktari.Size = new Size(151, 28);
            cbPorsiyonMiktari.TabIndex = 7;
            // 
            // lblPorsiyonBirimi
            // 
            lblPorsiyonBirimi.AutoSize = true;
            lblPorsiyonBirimi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPorsiyonBirimi.Location = new Point(361, 239);
            lblPorsiyonBirimi.Name = "lblPorsiyonBirimi";
            lblPorsiyonBirimi.Size = new Size(112, 20);
            lblPorsiyonBirimi.TabIndex = 8;
            lblPorsiyonBirimi.Text = "Porsiyon Birimi";
            // 
            // cbPorsiyonBirimi
            // 
            cbPorsiyonBirimi.FormattingEnabled = true;
            cbPorsiyonBirimi.Location = new Point(479, 236);
            cbPorsiyonBirimi.Name = "cbPorsiyonBirimi";
            cbPorsiyonBirimi.Size = new Size(97, 28);
            cbPorsiyonBirimi.TabIndex = 9;
            // 
            // btnKullaniciKayitİptal
            // 
            btnKullaniciKayitİptal.BackColor = Color.Crimson;
            btnKullaniciKayitİptal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnKullaniciKayitİptal.Location = new Point(474, 445);
            btnKullaniciKayitİptal.Name = "btnKullaniciKayitİptal";
            btnKullaniciKayitİptal.Size = new Size(98, 36);
            btnKullaniciKayitİptal.TabIndex = 13;
            btnKullaniciKayitİptal.Text = "İPTAL";
            btnKullaniciKayitİptal.UseVisualStyleBackColor = false;
            btnKullaniciKayitİptal.Click += btnKullaniciKayitİptal_Click;
            // 
            // btnKullaniciKaydet
            // 
            btnKullaniciKaydet.BackColor = Color.Lime;
            btnKullaniciKaydet.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnKullaniciKaydet.Location = new Point(370, 445);
            btnKullaniciKaydet.Name = "btnKullaniciKaydet";
            btnKullaniciKaydet.Size = new Size(98, 36);
            btnKullaniciKaydet.TabIndex = 12;
            btnKullaniciKaydet.Text = "KAYDET";
            btnKullaniciKaydet.UseVisualStyleBackColor = false;
            // 
            // panel
            // 
            panel.BackColor = Color.LightCoral;
            panel.Dock = DockStyle.Top;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(594, 29);
            panel.TabIndex = 14;
            panel.MouseDown += panel_MouseDown;
            // 
            // frm_NormalKullaniciOgunEkleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(594, 493);
            Controls.Add(panel);
            Controls.Add(btnKullaniciKayitİptal);
            Controls.Add(btnKullaniciKaydet);
            Controls.Add(cbPorsiyonBirimi);
            Controls.Add(lblPorsiyonBirimi);
            Controls.Add(cbPorsiyonMiktari);
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
        private ComboBox cbPorsiyonMiktari;
        private Label lblPorsiyonBirimi;
        private ComboBox cbPorsiyonBirimi;
        private Button btnKullaniciKayitİptal;
        private Button btnKullaniciKaydet;
        private Panel panel;
    }
}