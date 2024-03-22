namespace DietProject.UI
{
    partial class frm_AnaGirisEkranı
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnKayitOl = new Button();
            btnGirisYap = new Button();
            lblBaslik = new Label();
            btnAdminGiris = new Button();
            SuspendLayout();
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.SandyBrown;
            btnKayitOl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKayitOl.Location = new Point(66, 112);
            btnKayitOl.Margin = new Padding(3, 2, 3, 2);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(186, 104);
            btnKayitOl.TabIndex = 0;
            btnKayitOl.Text = "Kayıt Ol ";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += this.btnKayitOl_Click;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.GreenYellow;
            btnGirisYap.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGirisYap.Location = new Point(265, 112);
            btnGirisYap.Margin = new Padding(3, 2, 3, 2);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(187, 104);
            btnGirisYap.TabIndex = 1;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += this.btnGirisYap_Click;
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslik.ForeColor = SystemColors.ControlText;
            lblBaslik.Location = new Point(49, 41);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(373, 30);
            lblBaslik.TabIndex = 2;
            lblBaslik.Text = "Kalori Takip Sistemine Hoşgeldiniz ! ";
            // 
            // btnAdminGiris
            // 
            btnAdminGiris.BackColor = Color.IndianRed;
            btnAdminGiris.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAdminGiris.Location = new Point(12, 317);
            btnAdminGiris.Name = "btnAdminGiris";
            btnAdminGiris.Size = new Size(137, 41);
            btnAdminGiris.TabIndex = 3;
            btnAdminGiris.Text = "Admin Girişi";
            btnAdminGiris.UseVisualStyleBackColor = false;
            // 
            // AnaGirisEkranı
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(510, 370);
            Controls.Add(btnAdminGiris);
            Controls.Add(lblBaslik);
            Controls.Add(btnGirisYap);
            Controls.Add(btnKayitOl);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AnaGirisEkranı";
            Text = "Kalori Takip Sistemi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKayitOl;
        private Button btnGirisYap;
        private Label lblBaslik;
        private Button btnAdminGiris;
    }
}
