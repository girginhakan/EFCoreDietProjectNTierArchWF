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
            cbSifreGoster = new CheckBox();
            linklSifremiUnuttum = new LinkLabel();
            SuspendLayout();
            // 
            // lblEposta
            // 
            lblEposta.AutoSize = true;
            lblEposta.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblEposta.Location = new Point(171, 171);
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
            txtSifre.Location = new Point(251, 237);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(163, 27);
            txtSifre.TabIndex = 3;
            // 
            // btnİptal
            // 
            btnİptal.BackColor = Color.Crimson;
            btnİptal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnİptal.Location = new Point(473, 445);
            btnİptal.Name = "btnİptal";
            btnİptal.Size = new Size(98, 36);
            btnİptal.TabIndex = 13;
            btnİptal.Text = "İPTAL";
            btnİptal.UseVisualStyleBackColor = false;
            btnİptal.Click += btnİptal_Click;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.Lime;
            btnGiris.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGiris.Location = new Point(369, 445);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(98, 36);
            btnGiris.TabIndex = 12;
            btnGiris.Text = "GİRİŞ";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
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
            // cbSifreGoster
            // 
            cbSifreGoster.AutoSize = true;
            cbSifreGoster.Location = new Point(201, 296);
            cbSifreGoster.Margin = new Padding(3, 4, 3, 4);
            cbSifreGoster.Name = "cbSifreGoster";
            cbSifreGoster.Size = new Size(124, 24);
            cbSifreGoster.TabIndex = 15;
            cbSifreGoster.Text = "Şifremi göster";
            cbSifreGoster.UseVisualStyleBackColor = true;
            cbSifreGoster.CheckedChanged += cbSifreGoster_CheckedChanged;
            // 
            // linklSifremiUnuttum
            // 
            linklSifremiUnuttum.AutoSize = true;
            linklSifremiUnuttum.Location = new Point(339, 296);
            linklSifremiUnuttum.Name = "linklSifremiUnuttum";
            linklSifremiUnuttum.Size = new Size(117, 20);
            linklSifremiUnuttum.TabIndex = 16;
            linklSifremiUnuttum.TabStop = true;
            linklSifremiUnuttum.Text = "Şifremi Unuttum";
            linklSifremiUnuttum.LinkClicked += linklSifremiUnuttum_LinkClicked;
            // 
            // frm_KullaniciGirisEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(583, 493);
            Controls.Add(linklSifremiUnuttum);
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
        private CheckBox cbSifreGoster;
        private LinkLabel linklSifremiUnuttum;
    }
}