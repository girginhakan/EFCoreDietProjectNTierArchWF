namespace DietProject.UI
{
    partial class frm_AdminAnaEkrani
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
            btnYemekKategoriCRUD = new Button();
            btnYemekCesidiCRUD = new Button();
            btnOgunİslemleriCRUD = new Button();
            btnPorsiyonİslemleriCRUD = new Button();
            label1 = new Label();
            btnRaporlama = new Button();
            lblKullanici = new Label();
            btnGeri = new Button();
            SuspendLayout();
            // 
            // btnYemekKategoriCRUD
            // 
            btnYemekKategoriCRUD.BackColor = Color.Pink;
            btnYemekKategoriCRUD.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnYemekKategoriCRUD.Location = new Point(82, 129);
            btnYemekKategoriCRUD.Name = "btnYemekKategoriCRUD";
            btnYemekKategoriCRUD.Size = new Size(191, 100);
            btnYemekKategoriCRUD.TabIndex = 0;
            btnYemekKategoriCRUD.Text = "Yemek Kategori İşlemleri";
            btnYemekKategoriCRUD.UseVisualStyleBackColor = false;
            btnYemekKategoriCRUD.Click += btnYemekKategoriCRUD_Click;
            // 
            // btnYemekCesidiCRUD
            // 
            btnYemekCesidiCRUD.BackColor = Color.Thistle;
            btnYemekCesidiCRUD.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnYemekCesidiCRUD.Location = new Point(306, 129);
            btnYemekCesidiCRUD.Name = "btnYemekCesidiCRUD";
            btnYemekCesidiCRUD.Size = new Size(191, 100);
            btnYemekCesidiCRUD.TabIndex = 1;
            btnYemekCesidiCRUD.Text = "Yemek Çeşidi İşlemleri";
            btnYemekCesidiCRUD.UseVisualStyleBackColor = false;
            btnYemekCesidiCRUD.Click += btnYemekCesidiCRUD_Click;
            // 
            // btnOgunİslemleriCRUD
            // 
            btnOgunİslemleriCRUD.BackColor = Color.Plum;
            btnOgunİslemleriCRUD.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOgunİslemleriCRUD.Location = new Point(82, 269);
            btnOgunİslemleriCRUD.Name = "btnOgunİslemleriCRUD";
            btnOgunİslemleriCRUD.Size = new Size(191, 95);
            btnOgunİslemleriCRUD.TabIndex = 2;
            btnOgunİslemleriCRUD.Text = "Öğün İşlemleri";
            btnOgunİslemleriCRUD.UseVisualStyleBackColor = false;
            btnOgunİslemleriCRUD.Click += btnOgunİslemleriCRUD_Click;
            // 
            // btnPorsiyonİslemleriCRUD
            // 
            btnPorsiyonİslemleriCRUD.BackColor = Color.FromArgb(255, 192, 255);
            btnPorsiyonİslemleriCRUD.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnPorsiyonİslemleriCRUD.Location = new Point(306, 269);
            btnPorsiyonİslemleriCRUD.Name = "btnPorsiyonİslemleriCRUD";
            btnPorsiyonİslemleriCRUD.Size = new Size(191, 95);
            btnPorsiyonİslemleriCRUD.TabIndex = 3;
            btnPorsiyonİslemleriCRUD.Text = "Porsiyon İşlemleri";
            btnPorsiyonİslemleriCRUD.UseVisualStyleBackColor = false;
            btnPorsiyonİslemleriCRUD.Click += btnPorsiyonİslemleriCRUD_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(146, 59);
            label1.Name = "label1";
            label1.Size = new Size(320, 23);
            label1.TabIndex = 4;
            label1.Text = "Lütfen İşlem Yapılacak Olan Alanı Seçiniz";
            // 
            // btnRaporlama
            // 
            btnRaporlama.BackColor = Color.RosyBrown;
            btnRaporlama.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnRaporlama.Location = new Point(82, 403);
            btnRaporlama.Name = "btnRaporlama";
            btnRaporlama.Size = new Size(415, 95);
            btnRaporlama.TabIndex = 5;
            btnRaporlama.Text = "Raporlama İşlemleri";
            btnRaporlama.UseVisualStyleBackColor = false;
            btnRaporlama.Click += btnRaporlama_Click;
            // 
            // lblKullanici
            // 
            lblKullanici.AutoSize = true;
            lblKullanici.Location = new Point(23, 21);
            lblKullanici.Name = "lblKullanici";
            lblKullanici.Size = new Size(50, 20);
            lblKullanici.TabIndex = 6;
            lblKullanici.Text = "label2";
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.Khaki;
            btnGeri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGeri.Location = new Point(82, 504);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(415, 57);
            btnGeri.TabIndex = 8;
            btnGeri.Text = "Çıkış yap";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // frm_AdminAnaEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(586, 573);
            Controls.Add(btnGeri);
            Controls.Add(lblKullanici);
            Controls.Add(btnRaporlama);
            Controls.Add(label1);
            Controls.Add(btnPorsiyonİslemleriCRUD);
            Controls.Add(btnOgunİslemleriCRUD);
            Controls.Add(btnYemekCesidiCRUD);
            Controls.Add(btnYemekKategoriCRUD);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_AdminAnaEkrani";
            Text = "İşlemler";
            Load += frm_AdminAnaEkrani_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnYemekKategoriCRUD;
        private Button btnYemekCesidiCRUD;
        private Button btnOgunİslemleriCRUD;
        private Button btnPorsiyonİslemleriCRUD;
        private Label label1;
        private Button btnRaporlama;
        private Label lblKullanici;
        private Button btnGeri;
    }
}