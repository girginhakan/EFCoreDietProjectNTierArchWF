namespace DietProject.UI
{
    partial class frm_YemekKategoriIslemleri
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
            lblMevcutYemekKategorileri = new Label();
            dgvMevcutYemekKategorileri = new DataGridView();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            txtKategoriAdi = new TextBox();
            txtAciklama = new TextBox();
            lblKategoriAdı = new Label();
            lblAcıklama = new Label();
            btnGeri = new Button();
            lblSecilen = new Label();
            panel = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvMevcutYemekKategorileri).BeginInit();
            SuspendLayout();
            // 
            // lblMevcutYemekKategorileri
            // 
            lblMevcutYemekKategorileri.AutoSize = true;
            lblMevcutYemekKategorileri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblMevcutYemekKategorileri.Location = new Point(80, 40);
            lblMevcutYemekKategorileri.Name = "lblMevcutYemekKategorileri";
            lblMevcutYemekKategorileri.Size = new Size(193, 20);
            lblMevcutYemekKategorileri.TabIndex = 0;
            lblMevcutYemekKategorileri.Text = "Mevcut Yemek Kategorileri";
            // 
            // dgvMevcutYemekKategorileri
            // 
            dgvMevcutYemekKategorileri.BackgroundColor = Color.LightGray;
            dgvMevcutYemekKategorileri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMevcutYemekKategorileri.Location = new Point(27, 81);
            dgvMevcutYemekKategorileri.Name = "dgvMevcutYemekKategorileri";
            dgvMevcutYemekKategorileri.RowHeadersWidth = 51;
            dgvMevcutYemekKategorileri.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMevcutYemekKategorileri.Size = new Size(350, 420);
            dgvMevcutYemekKategorileri.TabIndex = 1;
            dgvMevcutYemekKategorileri.CellClick += dgvMevcutYemekKategorileri_CellClick;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.DarkKhaki;
            btnEkle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnEkle.Location = new Point(582, 375);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(140, 50);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Coral;
            btnSil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSil.Location = new Point(408, 452);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(140, 50);
            btnSil.TabIndex = 2;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Goldenrod;
            btnGuncelle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGuncelle.Location = new Point(408, 375);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(140, 50);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtKategoriAdi
            // 
            txtKategoriAdi.Location = new Point(408, 143);
            txtKategoriAdi.Margin = new Padding(3, 4, 3, 4);
            txtKategoriAdi.Name = "txtKategoriAdi";
            txtKategoriAdi.Size = new Size(314, 27);
            txtKategoriAdi.TabIndex = 3;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(408, 252);
            txtAciklama.Margin = new Padding(3, 4, 3, 4);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(314, 27);
            txtAciklama.TabIndex = 4;
            // 
            // lblKategoriAdı
            // 
            lblKategoriAdı.AutoSize = true;
            lblKategoriAdı.Location = new Point(408, 103);
            lblKategoriAdı.Name = "lblKategoriAdı";
            lblKategoriAdı.Size = new Size(96, 20);
            lblKategoriAdı.TabIndex = 5;
            lblKategoriAdı.Text = "Kategori Adı:";
            // 
            // lblAcıklama
            // 
            lblAcıklama.AutoSize = true;
            lblAcıklama.Location = new Point(408, 211);
            lblAcıklama.Name = "lblAcıklama";
            lblAcıklama.Size = new Size(73, 20);
            lblAcıklama.TabIndex = 6;
            lblAcıklama.Text = "Açıklama:";
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.Khaki;
            btnGeri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGeri.Location = new Point(582, 452);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(140, 50);
            btnGeri.TabIndex = 7;
            btnGeri.Text = "GERİ";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // lblSecilen
            // 
            lblSecilen.AutoSize = true;
            lblSecilen.Location = new Point(408, 40);
            lblSecilen.Name = "lblSecilen";
            lblSecilen.Size = new Size(50, 20);
            lblSecilen.TabIndex = 8;
            lblSecilen.Text = "label1";
            // 
            // panel
            // 
            panel.BackColor = Color.SandyBrown;
            panel.Dock = DockStyle.Top;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(750, 29);
            panel.TabIndex = 10;
            panel.MouseDown += panel_MouseDown;
            // 
            // frm_YemekKategoriIslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(750, 550);
            Controls.Add(panel);
            Controls.Add(lblSecilen);
            Controls.Add(btnGeri);
            Controls.Add(lblAcıklama);
            Controls.Add(lblKategoriAdı);
            Controls.Add(txtAciklama);
            Controls.Add(txtKategoriAdi);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(dgvMevcutYemekKategorileri);
            Controls.Add(lblMevcutYemekKategorileri);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_YemekKategoriIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yemek Kategorisi İşlemleri";
            ((System.ComponentModel.ISupportInitialize)dgvMevcutYemekKategorileri).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMevcutYemekKategorileri;
        private DataGridView dgvMevcutYemekKategorileri;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private TextBox txtKategoriAdi;
        private TextBox txtAciklama;
        private Label lblKategoriAdı;
        private Label lblAcıklama;
        private Button btnGeri;
        private Label lblSecilen;
        private Panel panel;
    }
}