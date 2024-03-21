namespace DietProject.UI
{
    partial class Form3
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
            lblEposta = new Label();
            lblSifre = new Label();
            txtEposta = new TextBox();
            txtSifre = new TextBox();
            btnİptal = new Button();
            btnGiris = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // lblEposta
            // 
            lblEposta.AutoSize = true;
            lblEposta.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblEposta.Location = new Point(171, 170);
            lblEposta.Name = "lblEposta";
            lblEposta.Size = new Size(58, 20);
            lblEposta.TabIndex = 0;
            lblEposta.Text = "Eposta:";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSifre.Location = new Point(174, 241);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(44, 20);
            lblSifre.TabIndex = 1;
            lblSifre.Text = "Şifre:";
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(251, 171);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(163, 27);
            txtEposta.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(251, 238);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(163, 27);
            txtSifre.TabIndex = 3;
            // 
            // btnİptal
            // 
            btnİptal.BackColor = Color.Crimson;
            btnİptal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnİptal.Location = new Point(473, 446);
            btnİptal.Name = "btnİptal";
            btnİptal.Size = new Size(98, 36);
            btnİptal.TabIndex = 13;
            btnİptal.Text = "İPTAL";
            btnİptal.UseVisualStyleBackColor = false;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.Lime;
            btnGiris.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGiris.Location = new Point(369, 446);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(98, 36);
            btnGiris.TabIndex = 12;
            btnGiris.Text = "KAYDET";
            btnGiris.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(24, 35);
            label3.Name = "label3";
            label3.Size = new Size(176, 31);
            label3.TabIndex = 14;
            label3.Text = "Kullanıcı Girişi ";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(583, 494);
            Controls.Add(label3);
            Controls.Add(btnİptal);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(txtEposta);
            Controls.Add(lblSifre);
            Controls.Add(lblEposta);
            Name = "Form3";
            Text = "Kullanıcı Giriş";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEposta;
        private Label lblSifre;
        private TextBox txtEposta;
        private TextBox txtSifre;
        private Button btnİptal;
        private Button btnGiris;
        private Label label3;
    }
}