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
            btnGeri = new Button();
            panel = new Panel();
            SuspendLayout();
            // 
            // btnYemekKategoriCRUD
            // 
            btnYemekKategoriCRUD.BackColor = Color.BurlyWood;
            btnYemekKategoriCRUD.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnYemekKategoriCRUD.Location = new Point(29, 131);
            btnYemekKategoriCRUD.Name = "btnYemekKategoriCRUD";
            btnYemekKategoriCRUD.Size = new Size(252, 100);
            btnYemekKategoriCRUD.TabIndex = 0;
            btnYemekKategoriCRUD.Text = "Yemek Kategori İşlemleri";
            btnYemekKategoriCRUD.UseVisualStyleBackColor = false;
            btnYemekKategoriCRUD.Click += btnYemekKategoriCRUD_Click;
            // 
            // btnYemekCesidiCRUD
            // 
            btnYemekCesidiCRUD.BackColor = Color.Khaki;
            btnYemekCesidiCRUD.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnYemekCesidiCRUD.Location = new Point(444, 131);
            btnYemekCesidiCRUD.Name = "btnYemekCesidiCRUD";
            btnYemekCesidiCRUD.Size = new Size(250, 100);
            btnYemekCesidiCRUD.TabIndex = 1;
            btnYemekCesidiCRUD.Text = "Yemek Çeşidi İşlemleri";
            btnYemekCesidiCRUD.UseVisualStyleBackColor = false;
            btnYemekCesidiCRUD.Click += btnYemekCesidiCRUD_Click;
            // 
            // btnOgunİslemleriCRUD
            // 
            btnOgunİslemleriCRUD.BackColor = Color.DarkGoldenrod;
            btnOgunİslemleriCRUD.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOgunİslemleriCRUD.Location = new Point(29, 271);
            btnOgunİslemleriCRUD.Name = "btnOgunİslemleriCRUD";
            btnOgunİslemleriCRUD.Size = new Size(252, 95);
            btnOgunİslemleriCRUD.TabIndex = 2;
            btnOgunİslemleriCRUD.Text = "Öğün İşlemleri";
            btnOgunİslemleriCRUD.UseVisualStyleBackColor = false;
            btnOgunİslemleriCRUD.Click += btnOgunİslemleriCRUD_Click;
            // 
            // btnPorsiyonİslemleriCRUD
            // 
            btnPorsiyonİslemleriCRUD.BackColor = Color.SandyBrown;
            btnPorsiyonİslemleriCRUD.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnPorsiyonİslemleriCRUD.Location = new Point(444, 271);
            btnPorsiyonİslemleriCRUD.Name = "btnPorsiyonİslemleriCRUD";
            btnPorsiyonİslemleriCRUD.Size = new Size(250, 95);
            btnPorsiyonİslemleriCRUD.TabIndex = 3;
            btnPorsiyonİslemleriCRUD.Text = "Porsiyon İşlemleri";
            btnPorsiyonİslemleriCRUD.UseVisualStyleBackColor = false;
            btnPorsiyonİslemleriCRUD.Click += btnPorsiyonİslemleriCRUD_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(219, 71);
            label1.Name = "label1";
            label1.Size = new Size(320, 23);
            label1.TabIndex = 4;
            label1.Text = "Lütfen İşlem Yapılacak Olan Alanı Seçiniz";
            // 
            // btnRaporlama
            // 
            btnRaporlama.BackColor = Color.Orange;
            btnRaporlama.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnRaporlama.Location = new Point(153, 408);
            btnRaporlama.Name = "btnRaporlama";
            btnRaporlama.Size = new Size(415, 85);
            btnRaporlama.TabIndex = 5;
            btnRaporlama.Text = "Raporlama İşlemleri";
            btnRaporlama.UseVisualStyleBackColor = false;
            btnRaporlama.Click += btnRaporlama_Click;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.Pink;
            btnGeri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGeri.Location = new Point(244, 541);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(415, 57);
            btnGeri.TabIndex = 8;
            btnGeri.Text = "Çıkış yap";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
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
            // frm_AdminAnaEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(750, 550);
            Controls.Add(panel);
            Controls.Add(btnGeri);
            Controls.Add(btnRaporlama);
            Controls.Add(label1);
            Controls.Add(btnPorsiyonİslemleriCRUD);
            Controls.Add(btnOgunİslemleriCRUD);
            Controls.Add(btnYemekCesidiCRUD);
            Controls.Add(btnYemekKategoriCRUD);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_AdminAnaEkrani";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button btnGeri;
        private Panel panel;
    }
}