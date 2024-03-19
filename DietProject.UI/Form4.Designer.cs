namespace DietProject.UI
{
    partial class Form4
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
            // 
            // btnOgunİslemleriCRUD
            // 
            btnOgunİslemleriCRUD.BackColor = Color.Plum;
            btnOgunİslemleriCRUD.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOgunİslemleriCRUD.Location = new Point(82, 270);
            btnOgunİslemleriCRUD.Name = "btnOgunİslemleriCRUD";
            btnOgunİslemleriCRUD.Size = new Size(191, 95);
            btnOgunİslemleriCRUD.TabIndex = 2;
            btnOgunİslemleriCRUD.Text = "Öğün İşlemleri";
            btnOgunİslemleriCRUD.UseVisualStyleBackColor = false;
            // 
            // btnPorsiyonİslemleriCRUD
            // 
            btnPorsiyonİslemleriCRUD.BackColor = Color.FromArgb(255, 192, 255);
            btnPorsiyonİslemleriCRUD.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnPorsiyonİslemleriCRUD.Location = new Point(306, 270);
            btnPorsiyonİslemleriCRUD.Name = "btnPorsiyonİslemleriCRUD";
            btnPorsiyonİslemleriCRUD.Size = new Size(191, 95);
            btnPorsiyonİslemleriCRUD.TabIndex = 3;
            btnPorsiyonİslemleriCRUD.Text = "Porsiyon İşlemleri";
            btnPorsiyonİslemleriCRUD.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(146, 58);
            label1.Name = "label1";
            label1.Size = new Size(320, 23);
            label1.TabIndex = 4;
            label1.Text = "Lütfen İşlem Yapılacak Olan Alanı Seçiniz";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(583, 494);
            Controls.Add(label1);
            Controls.Add(btnPorsiyonİslemleriCRUD);
            Controls.Add(btnOgunİslemleriCRUD);
            Controls.Add(btnYemekCesidiCRUD);
            Controls.Add(btnYemekKategoriCRUD);
            Name = "Form4";
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
    }
}