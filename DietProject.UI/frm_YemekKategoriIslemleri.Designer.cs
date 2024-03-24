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
            txtKategoriAdı = new TextBox();
            txtAcıklama = new TextBox();
            lblKategoriAdı = new Label();
            lblAcıklama = new Label();
            btnGeri = new Button();
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
            btnEkle.Location = new Point(618, 195);
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
            btnSil.Location = new Point(411, 272);
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
            btnGuncelle.Location = new Point(411, 353);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(149, 76);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtKategoriAdı
            // 
            txtKategoriAdı.Location = new Point(422, 68);
            txtKategoriAdı.Margin = new Padding(3, 4, 3, 4);
            txtKategoriAdı.Name = "txtKategoriAdı";
            txtKategoriAdı.Size = new Size(345, 27);
            txtKategoriAdı.TabIndex = 3;
            // 
            // txtAcıklama
            // 
            txtAcıklama.Location = new Point(422, 137);
            txtAcıklama.Margin = new Padding(3, 4, 3, 4);
            txtAcıklama.Name = "txtAcıklama";
            txtAcıklama.Size = new Size(345, 27);
            txtAcıklama.TabIndex = 4;
            // 
            // lblKategoriAdı
            // 
            lblKategoriAdı.AutoSize = true;
            lblKategoriAdı.Location = new Point(402, 44);
            lblKategoriAdı.Name = "lblKategoriAdı";
            lblKategoriAdı.Size = new Size(96, 20);
            lblKategoriAdı.TabIndex = 5;
            lblKategoriAdı.Text = "Kategori Adı:";
            // 
            // lblAcıklama
            // 
            lblAcıklama.AutoSize = true;
            lblAcıklama.Location = new Point(402, 113);
            lblAcıklama.Name = "lblAcıklama";
            lblAcıklama.Size = new Size(73, 20);
            lblAcıklama.TabIndex = 6;
            lblAcıklama.Text = "Açıklama:";
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.Khaki;
            btnGeri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGeri.Location = new Point(618, 353);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(149, 76);
            btnGeri.TabIndex = 7;
            btnGeri.Text = "GERİ";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // frm_YemekKategoriIslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1015, 525);
            Controls.Add(btnGeri);
            Controls.Add(lblAcıklama);
            Controls.Add(lblKategoriAdı);
            Controls.Add(txtAcıklama);
            Controls.Add(txtKategoriAdı);
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
        private TextBox txtKategoriAdı;
        private TextBox txtAcıklama;
        private Label lblKategoriAdı;
        private Label lblAcıklama;
        private Button btnGeri;
    }
}