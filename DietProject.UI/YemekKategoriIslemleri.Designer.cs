namespace DietProject.UI
{
    partial class YemekKategoriIslemleri
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
            ((System.ComponentModel.ISupportInitialize)dgvMevcutYemekKategorileri).BeginInit();
            SuspendLayout();
            // 
            // lblMevcutYemekKategorileri
            // 
            lblMevcutYemekKategorileri.AutoSize = true;
            lblMevcutYemekKategorileri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblMevcutYemekKategorileri.Location = new Point(80, 26);
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
            dgvMevcutYemekKategorileri.Size = new Size(332, 361);
            dgvMevcutYemekKategorileri.TabIndex = 1;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Lime;
            btnEkle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnEkle.Location = new Point(393, 109);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(148, 76);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Crimson;
            btnSil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSil.Location = new Point(393, 206);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(148, 76);
            btnSil.TabIndex = 2;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(255, 128, 0);
            btnGuncelle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGuncelle.Location = new Point(393, 302);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(148, 76);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(583, 494);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(dgvMevcutYemekKategorileri);
            Controls.Add(lblMevcutYemekKategorileri);
            Name = "Form5";
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
    }
}