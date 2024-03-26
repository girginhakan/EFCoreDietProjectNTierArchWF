namespace DietProject.UI
{
    partial class s
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
            lblEnCokTuketilen = new Label();
            lblEnCokTuketilenMiktar = new Label();
            cbKullanıcı1 = new ComboBox();
            cbKullanıcı2 = new ComboBox();
            lblKullanıcı1 = new Label();
            lblKullanıcı2 = new Label();
            btnHaftalıkRapor = new Button();
            btnAylıkRapor = new Button();
            btnGeri = new Button();
            panel = new Panel();
            SuspendLayout();
            // 
            // lblEnCokTuketilen
            // 
            lblEnCokTuketilen.AutoSize = true;
            lblEnCokTuketilen.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblEnCokTuketilen.Location = new Point(30, 41);
            lblEnCokTuketilen.Name = "lblEnCokTuketilen";
            lblEnCokTuketilen.Size = new Size(217, 20);
            lblEnCokTuketilen.TabIndex = 0;
            lblEnCokTuketilen.Text = "En çok tüketilen yemek çeşidi: ";
            // 
            // lblEnCokTuketilenMiktar
            // 
            lblEnCokTuketilenMiktar.AutoSize = true;
            lblEnCokTuketilenMiktar.Location = new Point(248, 41);
            lblEnCokTuketilenMiktar.Name = "lblEnCokTuketilenMiktar";
            lblEnCokTuketilenMiktar.Size = new Size(50, 20);
            lblEnCokTuketilenMiktar.TabIndex = 1;
            lblEnCokTuketilenMiktar.Text = "label2";
            // 
            // cbKullanıcı1
            // 
            cbKullanıcı1.FormattingEnabled = true;
            cbKullanıcı1.Location = new Point(114, 119);
            cbKullanıcı1.Name = "cbKullanıcı1";
            cbKullanıcı1.Size = new Size(151, 28);
            cbKullanıcı1.TabIndex = 2;
            // 
            // cbKullanıcı2
            // 
            cbKullanıcı2.FormattingEnabled = true;
            cbKullanıcı2.Location = new Point(114, 191);
            cbKullanıcı2.Name = "cbKullanıcı2";
            cbKullanıcı2.Size = new Size(151, 28);
            cbKullanıcı2.TabIndex = 3;
            // 
            // lblKullanıcı1
            // 
            lblKullanıcı1.AutoSize = true;
            lblKullanıcı1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblKullanıcı1.Location = new Point(30, 122);
            lblKullanıcı1.Name = "lblKullanıcı1";
            lblKullanıcı1.Size = new Size(71, 20);
            lblKullanıcı1.TabIndex = 4;
            lblKullanıcı1.Text = "Kullanıcı:";
            // 
            // lblKullanıcı2
            // 
            lblKullanıcı2.AutoSize = true;
            lblKullanıcı2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblKullanıcı2.Location = new Point(30, 195);
            lblKullanıcı2.Name = "lblKullanıcı2";
            lblKullanıcı2.Size = new Size(71, 20);
            lblKullanıcı2.TabIndex = 5;
            lblKullanıcı2.Text = "Kullanıcı:";
            // 
            // btnHaftalıkRapor
            // 
            btnHaftalıkRapor.BackColor = Color.Orange;
            btnHaftalıkRapor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnHaftalıkRapor.Location = new Point(114, 260);
            btnHaftalıkRapor.Name = "btnHaftalıkRapor";
            btnHaftalıkRapor.Size = new Size(151, 50);
            btnHaftalıkRapor.TabIndex = 6;
            btnHaftalıkRapor.Text = "Haftalık Raporla";
            btnHaftalıkRapor.UseVisualStyleBackColor = false;
            // 
            // btnAylıkRapor
            // 
            btnAylıkRapor.BackColor = Color.OrangeRed;
            btnAylıkRapor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAylıkRapor.Location = new Point(114, 333);
            btnAylıkRapor.Name = "btnAylıkRapor";
            btnAylıkRapor.Size = new Size(151, 50);
            btnAylıkRapor.TabIndex = 7;
            btnAylıkRapor.Text = "Aylık Raporla";
            btnAylıkRapor.UseVisualStyleBackColor = false;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.Khaki;
            btnGeri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGeri.Location = new Point(117, 389);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(148, 40);
            btnGeri.TabIndex = 27;
            btnGeri.Text = "GERİ";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // panel
            // 
            panel.BackColor = Color.LightCoral;
            panel.Dock = DockStyle.Top;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(1119, 29);
            panel.TabIndex = 28;
            panel.MouseDown += panel_MouseDown;
            // 
            // s
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1119, 494);
            Controls.Add(panel);
            Controls.Add(btnGeri);
            Controls.Add(btnAylıkRapor);
            Controls.Add(btnHaftalıkRapor);
            Controls.Add(lblKullanıcı2);
            Controls.Add(lblKullanıcı1);
            Controls.Add(cbKullanıcı2);
            Controls.Add(cbKullanıcı1);
            Controls.Add(lblEnCokTuketilenMiktar);
            Controls.Add(lblEnCokTuketilen);
            FormBorderStyle = FormBorderStyle.None;
            Name = "s";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Raporlar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEnCokTuketilen;
        private Label lblEnCokTuketilenMiktar;
        private ComboBox cbKullanıcı1;
        private ComboBox cbKullanıcı2;
        private Label lblKullanıcı1;
        private Label lblKullanıcı2;
        private Button btnHaftalıkRapor;
        private Button btnAylıkRapor;
        private Button btnGeri;
        private Panel panel;
    }
}