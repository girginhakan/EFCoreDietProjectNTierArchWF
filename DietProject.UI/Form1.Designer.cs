namespace DietProject.UI
{
    partial class Form1
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
            SuspendLayout();
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.SandyBrown;
            btnKayitOl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKayitOl.Location = new Point(75, 150);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(213, 139);
            btnKayitOl.TabIndex = 0;
            btnKayitOl.Text = "Kayıt Ol ";
            btnKayitOl.UseVisualStyleBackColor = false;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.GreenYellow;
            btnGirisYap.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGirisYap.Location = new Point(303, 150);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(214, 139);
            btnGirisYap.TabIndex = 1;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = false;
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslik.ForeColor = SystemColors.ControlText;
            lblBaslik.Location = new Point(56, 55);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(476, 38);
            lblBaslik.TabIndex = 2;
            lblBaslik.Text = "Kalori Takip Sistemine Hoşgeldiniz ! ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(583, 494);
            Controls.Add(lblBaslik);
            Controls.Add(btnGirisYap);
            Controls.Add(btnKayitOl);
            Name = "Form1";
            Text = "Kalori Takip Sistemi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKayitOl;
        private Button btnGirisYap;
        private Label lblBaslik;
    }
}
