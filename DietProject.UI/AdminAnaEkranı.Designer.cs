namespace DietProject.UI
{
    partial class AdminAnaEkranı
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
            SuspendLayout();
            // 
            // btnYemekKategoriCRUD
            // 
            btnYemekKategoriCRUD.BackColor = Color.Pink;
            btnYemekKategoriCRUD.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnYemekKategoriCRUD.Location = new Point(72, 97);
            btnYemekKategoriCRUD.Margin = new Padding(3, 2, 3, 2);
            btnYemekKategoriCRUD.Name = "btnYemekKategoriCRUD";
            btnYemekKategoriCRUD.Size = new Size(167, 75);
            btnYemekKategoriCRUD.TabIndex = 0;
            btnYemekKategoriCRUD.Text = "Yemek Kategori İşlemleri";
            btnYemekKategoriCRUD.UseVisualStyleBackColor = false;
            btnYemekKategoriCRUD.Click += btnYemekKategoriCRUD_Click;
            // 
            // btnYemekCesidiCRUD
            // 
            btnYemekCesidiCRUD.BackColor = Color.Thistle;
            btnYemekCesidiCRUD.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnYemekCesidiCRUD.Location = new Point(268, 97);
            btnYemekCesidiCRUD.Margin = new Padding(3, 2, 3, 2);
            btnYemekCesidiCRUD.Name = "btnYemekCesidiCRUD";
            btnYemekCesidiCRUD.Size = new Size(167, 75);
            btnYemekCesidiCRUD.TabIndex = 1;
            btnYemekCesidiCRUD.Text = "Yemek Çeşidi İşlemleri";
            btnYemekCesidiCRUD.UseVisualStyleBackColor = false;
            btnYemekCesidiCRUD.Click += btnYemekCesidiCRUD_Click;
            // 
            // btnOgunİslemleriCRUD
            // 
            btnOgunİslemleriCRUD.BackColor = Color.Plum;
            btnOgunİslemleriCRUD.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOgunİslemleriCRUD.Location = new Point(72, 202);
            btnOgunİslemleriCRUD.Margin = new Padding(3, 2, 3, 2);
            btnOgunİslemleriCRUD.Name = "btnOgunİslemleriCRUD";
            btnOgunİslemleriCRUD.Size = new Size(167, 71);
            btnOgunİslemleriCRUD.TabIndex = 2;
            btnOgunİslemleriCRUD.Text = "Öğün İşlemleri";
            btnOgunİslemleriCRUD.UseVisualStyleBackColor = false;
            btnOgunİslemleriCRUD.Click += btnOgunİslemleriCRUD_Click;
            // 
            // btnPorsiyonİslemleriCRUD
            // 
            btnPorsiyonİslemleriCRUD.BackColor = Color.FromArgb(255, 192, 255);
            btnPorsiyonİslemleriCRUD.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnPorsiyonİslemleriCRUD.Location = new Point(268, 202);
            btnPorsiyonİslemleriCRUD.Margin = new Padding(3, 2, 3, 2);
            btnPorsiyonİslemleriCRUD.Name = "btnPorsiyonİslemleriCRUD";
            btnPorsiyonİslemleriCRUD.Size = new Size(167, 71);
            btnPorsiyonİslemleriCRUD.TabIndex = 3;
            btnPorsiyonİslemleriCRUD.Text = "Porsiyon İşlemleri";
            btnPorsiyonİslemleriCRUD.UseVisualStyleBackColor = false;
            btnPorsiyonİslemleriCRUD.Click += btnPorsiyonİslemleriCRUD_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(128, 44);
            label1.Name = "label1";
            label1.Size = new Size(267, 19);
            label1.TabIndex = 4;
            label1.Text = "Lütfen İşlem Yapılacak Olan Alanı Seçiniz";
            // 
            // btnRaporlama
            // 
            btnRaporlama.BackColor = Color.RosyBrown;
            btnRaporlama.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnRaporlama.Location = new Point(72, 302);
            btnRaporlama.Margin = new Padding(3, 2, 3, 2);
            btnRaporlama.Name = "btnRaporlama";
            btnRaporlama.Size = new Size(363, 71);
            btnRaporlama.TabIndex = 5;
            btnRaporlama.Text = "Raporlama İşlemleri";
            btnRaporlama.UseVisualStyleBackColor = false;
            btnRaporlama.Click += btnRaporlama_Click;
            // 
            // AdminAnaEkranı
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(513, 430);
            Controls.Add(btnRaporlama);
            Controls.Add(label1);
            Controls.Add(btnPorsiyonİslemleriCRUD);
            Controls.Add(btnOgunİslemleriCRUD);
            Controls.Add(btnYemekCesidiCRUD);
            Controls.Add(btnYemekKategoriCRUD);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminAnaEkranı";
            Text = "İşlemler";
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
    }
}