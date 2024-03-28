namespace DietProject.UI
{
    partial class frm_AnaGirisEkrani
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
            btnCikisYap = new Button();
            panel = new Panel();
            SuspendLayout();
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.SandyBrown;
            btnKayitOl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKayitOl.Location = new Point(97, 192);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(200, 150);
            btnKayitOl.TabIndex = 0;
            btnKayitOl.Text = "Kayıt Ol ";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.DarkKhaki;
            btnGirisYap.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGirisYap.Location = new Point(444, 192);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(200, 150);
            btnGirisYap.TabIndex = 1;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslik.ForeColor = SystemColors.ControlText;
            lblBaslik.Location = new Point(139, 84);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(476, 38);
            lblBaslik.TabIndex = 2;
            lblBaslik.Text = "Kalori Takip Sistemine Hoşgeldiniz ! ";
            // 
            // btnCikisYap
            // 
            btnCikisYap.BackColor = Color.Khaki;
            btnCikisYap.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCikisYap.Location = new Point(97, 407);
            btnCikisYap.Name = "btnCikisYap";
            btnCikisYap.Size = new Size(547, 78);
            btnCikisYap.TabIndex = 8;
            btnCikisYap.Text = "Programı Kapat";
            btnCikisYap.UseVisualStyleBackColor = false;
            btnCikisYap.Click += btnCikisYap_Click;
            // 
            // panel
            // 
            panel.BackColor = Color.SandyBrown;
            panel.Dock = DockStyle.Top;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(750, 29);
            panel.TabIndex = 9;
            panel.MouseDown += panel_MouseDown;
            // 
            // frm_AnaGirisEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(750, 550);
            Controls.Add(panel);
            Controls.Add(btnCikisYap);
            Controls.Add(lblBaslik);
            Controls.Add(btnGirisYap);
            Controls.Add(btnKayitOl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_AnaGirisEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kalori Takip Sistemi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKayitOl;
        private Button btnGirisYap;
        private Label lblBaslik;
        private Button btnCikisYap;
        private Panel panel;
    }
}
