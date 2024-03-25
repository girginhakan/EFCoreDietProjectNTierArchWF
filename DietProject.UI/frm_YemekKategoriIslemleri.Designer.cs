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
            ((System.ComponentModel.ISupportInitialize)dgvMevcutYemekKategorileri).BeginInit();
            SuspendLayout();
            // 
            // lblMevcutYemekKategorileri
            // 
            lblMevcutYemekKategorileri.AutoSize = true;
            lblMevcutYemekKategorileri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblMevcutYemekKategorileri.Location = new Point(80, 27);
            lblMevcutYemekKategorileri.Name = "lblMevcutYemekKategorileri";
            lblMevcutYemekKategorileri.Size = new Size(193, 20);
            lblMevcutYemekKategorileri.TabIndex = 0;
            lblMevcutYemekKategorileri.Text = "Mevcut Yemek Kategorileri";
            // 
            // dgvMevcutYemekKategorileri
            // 
            dgvMevcutYemekKategorileri.BackgroundColor = Color.LightGray;
            dgvMevcutYemekKategorileri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMevcutYemekKategorileri.Location = new Point(27, 68);
            dgvMevcutYemekKategorileri.Name = "dgvMevcutYemekKategorileri";
            dgvMevcutYemekKategorileri.RowHeadersWidth = 51;
            dgvMevcutYemekKategorileri.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMevcutYemekKategorileri.Size = new Size(331, 361);
            dgvMevcutYemekKategorileri.TabIndex = 1;
            dgvMevcutYemekKategorileri.CellClick += dgvMevcutYemekKategorileri_CellClick;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Lime;
            btnEkle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnEkle.Location = new Point(402, 353);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(149, 76);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Crimson;
            btnSil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSil.Location = new Point(753, 353);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(149, 76);
            btnSil.TabIndex = 2;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(255, 128, 0);
            btnGuncelle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGuncelle.Location = new Point(581, 353);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(149, 76);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtKategoriAdi
            // 
            txtKategoriAdi.Location = new Point(402, 131);
            txtKategoriAdi.Margin = new Padding(3, 4, 3, 4);
            txtKategoriAdi.Name = "txtKategoriAdi";
            txtKategoriAdi.Size = new Size(345, 27);
            txtKategoriAdi.TabIndex = 3;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(402, 242);
            txtAciklama.Margin = new Padding(3, 4, 3, 4);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(345, 27);
            txtAciklama.TabIndex = 4;
            // 
            // lblKategoriAdı
            // 
            lblKategoriAdı.AutoSize = true;
            lblKategoriAdı.Location = new Point(402, 91);
            lblKategoriAdı.Name = "lblKategoriAdı";
            lblKategoriAdı.Size = new Size(96, 20);
            lblKategoriAdı.TabIndex = 5;
            lblKategoriAdı.Text = "Kategori Adı:";
            // 
            // lblAcıklama
            // 
            lblAcıklama.AutoSize = true;
            lblAcıklama.Location = new Point(402, 204);
            lblAcıklama.Name = "lblAcıklama";
            lblAcıklama.Size = new Size(73, 20);
            lblAcıklama.TabIndex = 6;
            lblAcıklama.Text = "Açıklama:";
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.Khaki;
            btnGeri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGeri.Location = new Point(402, 437);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(149, 76);
            btnGeri.TabIndex = 7;
            btnGeri.Text = "GERİ";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // lblSecilen
            // 
            lblSecilen.AutoSize = true;
            lblSecilen.Location = new Point(402, 51);
            lblSecilen.Name = "lblSecilen";
            lblSecilen.Size = new Size(50, 20);
            lblSecilen.TabIndex = 8;
            lblSecilen.Text = "label1";
            // 
            // frm_YemekKategoriIslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1015, 525);
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
            Name = "frm_YemekKategoriIslemleri";
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
    }
}