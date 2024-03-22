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
            ((System.ComponentModel.ISupportInitialize)dgvMevcutYemekKategorileri).BeginInit();
            SuspendLayout();
            // 
            // lblMevcutYemekKategorileri
            // 
            lblMevcutYemekKategorileri.AutoSize = true;
            lblMevcutYemekKategorileri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblMevcutYemekKategorileri.Location = new Point(70, 20);
            lblMevcutYemekKategorileri.Name = "lblMevcutYemekKategorileri";
            lblMevcutYemekKategorileri.Size = new Size(148, 15);
            lblMevcutYemekKategorileri.TabIndex = 0;
            lblMevcutYemekKategorileri.Text = "Mevcut Yemek Kategorileri";
            // 
            // dgvMevcutYemekKategorileri
            // 
            dgvMevcutYemekKategorileri.BackgroundColor = Color.LightGray;
            dgvMevcutYemekKategorileri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMevcutYemekKategorileri.Location = new Point(24, 51);
            dgvMevcutYemekKategorileri.Margin = new Padding(3, 2, 3, 2);
            dgvMevcutYemekKategorileri.Name = "dgvMevcutYemekKategorileri";
            dgvMevcutYemekKategorileri.RowHeadersWidth = 51;
            dgvMevcutYemekKategorileri.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMevcutYemekKategorileri.Size = new Size(290, 271);
            dgvMevcutYemekKategorileri.TabIndex = 1;
            dgvMevcutYemekKategorileri.CellClick += dgvMevcutYemekKategorileri_CellClick;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Lime;
            btnEkle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnEkle.Location = new Point(541, 146);
            btnEkle.Margin = new Padding(3, 2, 3, 2);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(130, 57);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Crimson;
            btnSil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSil.Location = new Point(360, 204);
            btnSil.Margin = new Padding(3, 2, 3, 2);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(130, 57);
            btnSil.TabIndex = 2;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(255, 128, 0);
            btnGuncelle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGuncelle.Location = new Point(360, 265);
            btnGuncelle.Margin = new Padding(3, 2, 3, 2);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(130, 57);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtKategoriAdı
            // 
            txtKategoriAdı.Location = new Point(369, 51);
            txtKategoriAdı.Name = "txtKategoriAdı";
            txtKategoriAdı.Size = new Size(302, 23);
            txtKategoriAdı.TabIndex = 3;
            // 
            // txtAcıklama
            // 
            txtAcıklama.Location = new Point(369, 103);
            txtAcıklama.Name = "txtAcıklama";
            txtAcıklama.Size = new Size(302, 23);
            txtAcıklama.TabIndex = 4;
            // 
            // lblKategoriAdı
            // 
            lblKategoriAdı.AutoSize = true;
            lblKategoriAdı.Location = new Point(352, 33);
            lblKategoriAdı.Name = "lblKategoriAdı";
            lblKategoriAdı.Size = new Size(75, 15);
            lblKategoriAdı.TabIndex = 5;
            lblKategoriAdı.Text = "Kategori Adı:";
            // 
            // lblAcıklama
            // 
            lblAcıklama.AutoSize = true;
            lblAcıklama.Location = new Point(352, 85);
            lblAcıklama.Name = "lblAcıklama";
            lblAcıklama.Size = new Size(59, 15);
            lblAcıklama.TabIndex = 6;
            lblAcıklama.Text = "Açıklama:";
            // 
            // frm_YemekKategoriIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(888, 394);
            Controls.Add(lblAcıklama);
            Controls.Add(lblKategoriAdı);
            Controls.Add(txtAcıklama);
            Controls.Add(txtKategoriAdı);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(dgvMevcutYemekKategorileri);
            Controls.Add(lblMevcutYemekKategorileri);
            Margin = new Padding(3, 2, 3, 2);
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
    }
}