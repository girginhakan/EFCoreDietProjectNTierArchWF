namespace DietProject.UI
{
    partial class frm_KullaniciGirisEkrani
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
            panel = new Panel();
            cbSifreGoster = new CheckBox();
            SuspendLayout();
            // 
            // lblEposta
            // 
            lblEposta.AutoSize = true;
            lblEposta.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblEposta.Location = new Point(200, 181);
            lblEposta.Name = "lblEposta";
            lblEposta.Size = new Size(58, 20);
            lblEposta.TabIndex = 0;
            lblEposta.Text = "Eposta:";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSifre.Location = new Point(203, 251);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(44, 20);
            lblSifre.TabIndex = 1;
            lblSifre.Text = "Şifre:";
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(280, 181);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(234, 27);
            txtEposta.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(280, 247);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(234, 27);
            txtSifre.TabIndex = 3;
            // 
            // btnİptal
            // 
            btnİptal.BackColor = Color.Khaki;
            btnİptal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnİptal.Location = new Point(416, 374);
            btnİptal.Name = "btnİptal";
            btnİptal.Size = new Size(100, 50);
            btnİptal.TabIndex = 13;
            btnİptal.Text = "İPTAL";
            btnİptal.UseVisualStyleBackColor = false;
            btnİptal.Click += btnİptal_Click;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.DarkKhaki;
            btnGiris.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGiris.Location = new Point(280, 374);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(100, 50);
            btnGiris.TabIndex = 12;
            btnGiris.Text = "GİRİŞ";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(71, 69);
            label3.Name = "label3";
            label3.Size = new Size(176, 31);
            label3.TabIndex = 14;
            label3.Text = "Kullanıcı Girişi ";
            // 
            // panel
            // 
            panel.BackColor = Color.SandyBrown;
            panel.Dock = DockStyle.Top;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(750, 29);
            panel.TabIndex = 17;
            panel.MouseDown += panel_MouseDown;
            // 
            // cbSifreGoster
            // 
            cbSifreGoster.AutoSize = true;
            cbSifreGoster.Location = new Point(280, 307);
            cbSifreGoster.Margin = new Padding(3, 4, 3, 4);
            cbSifreGoster.Name = "cbSifreGoster";
            cbSifreGoster.Size = new Size(124, 24);
            cbSifreGoster.TabIndex = 15;
            cbSifreGoster.Text = "Şifremi göster";
            cbSifreGoster.UseVisualStyleBackColor = true;
            cbSifreGoster.CheckedChanged += cbSifreGoster_CheckedChanged;
            // 
            // frm_KullaniciGirisEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(750, 550);
            Controls.Add(panel);
            Controls.Add(cbSifreGoster);
            Controls.Add(label3);
            Controls.Add(btnİptal);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(txtEposta);
            Controls.Add(lblSifre);
            Controls.Add(lblEposta);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_KullaniciGirisEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Giriş";
            Load += frm_KullanıcıGirisEkranı_Load;
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
        private Panel panel;
        private CheckBox cbSifreGoster;
    }
}