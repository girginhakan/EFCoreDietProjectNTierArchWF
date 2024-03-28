namespace DietProject.UI
{
    partial class frm_YemekCesitIslemleri
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
            lblYemekCesitleri = new Label();
            dgvMevcutYemekCesitleri = new DataGridView();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            btnGeri = new Button();
            panel = new Panel();
            lblSecilen = new Label();
            lblYemekAdi = new Label();
            lblAciklama = new Label();
            lblKalori = new Label();
            txtYemekAdi = new TextBox();
            txtAciklama = new TextBox();
            txtKalori = new TextBox();
            cbKategori = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMevcutYemekCesitleri).BeginInit();
            SuspendLayout();
            // 
            // lblYemekCesitleri
            // 
            lblYemekCesitleri.AutoSize = true;
            lblYemekCesitleri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblYemekCesitleri.Location = new Point(114, 41);
            lblYemekCesitleri.Name = "lblYemekCesitleri";
            lblYemekCesitleri.Size = new Size(167, 20);
            lblYemekCesitleri.TabIndex = 1;
            lblYemekCesitleri.Text = "Mevcut Yemek Çeşitleri";
            // 
            // dgvMevcutYemekCesitleri
            // 
            dgvMevcutYemekCesitleri.BackgroundColor = Color.LightGray;
            dgvMevcutYemekCesitleri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMevcutYemekCesitleri.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvMevcutYemekCesitleri.Location = new Point(39, 85);
            dgvMevcutYemekCesitleri.Name = "dgvMevcutYemekCesitleri";
            dgvMevcutYemekCesitleri.RowHeadersWidth = 51;
            dgvMevcutYemekCesitleri.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMevcutYemekCesitleri.Size = new Size(350, 420);
            dgvMevcutYemekCesitleri.TabIndex = 2;
            dgvMevcutYemekCesitleri.CellClick += dgvMevcutYemekCesitleri_CellClick;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Goldenrod;
            btnGuncelle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGuncelle.Location = new Point(405, 376);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(140, 50);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Coral;
            btnSil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSil.Location = new Point(405, 454);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(140, 50);
            btnSil.TabIndex = 4;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.DarkKhaki;
            btnEkle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnEkle.Location = new Point(567, 376);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(140, 50);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.Khaki;
            btnGeri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGeri.Location = new Point(567, 454);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(140, 50);
            btnGeri.TabIndex = 26;
            btnGeri.Text = "GERİ";
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
            panel.TabIndex = 27;
            panel.MouseDown += panel_MouseDown;
            // 
            // lblSecilen
            // 
            lblSecilen.AutoSize = true;
            lblSecilen.Location = new Point(405, 41);
            lblSecilen.Name = "lblSecilen";
            lblSecilen.Size = new Size(50, 20);
            lblSecilen.TabIndex = 28;
            lblSecilen.Text = "label1";
            // 
            // lblYemekAdi
            // 
            lblYemekAdi.AutoSize = true;
            lblYemekAdi.Location = new Point(405, 85);
            lblYemekAdi.Name = "lblYemekAdi";
            lblYemekAdi.Size = new Size(82, 20);
            lblYemekAdi.TabIndex = 29;
            lblYemekAdi.Text = "Yemek Adi:";
            // 
            // lblAciklama
            // 
            lblAciklama.AutoSize = true;
            lblAciklama.Location = new Point(405, 159);
            lblAciklama.Name = "lblAciklama";
            lblAciklama.Size = new Size(73, 20);
            lblAciklama.TabIndex = 30;
            lblAciklama.Text = "Açıklama:";
            // 
            // lblKalori
            // 
            lblKalori.AutoSize = true;
            lblKalori.Location = new Point(405, 243);
            lblKalori.Name = "lblKalori";
            lblKalori.Size = new Size(51, 20);
            lblKalori.TabIndex = 31;
            lblKalori.Text = "Kalori:";
            // 
            // txtYemekAdi
            // 
            txtYemekAdi.Location = new Point(405, 119);
            txtYemekAdi.Name = "txtYemekAdi";
            txtYemekAdi.Size = new Size(115, 27);
            txtYemekAdi.TabIndex = 32;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(405, 193);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(302, 27);
            txtAciklama.TabIndex = 33;
            // 
            // txtKalori
            // 
            txtKalori.Location = new Point(405, 279);
            txtKalori.Name = "txtKalori";
            txtKalori.Size = new Size(302, 27);
            txtKalori.TabIndex = 34;
            // 
            // cbKategori
            // 
            cbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKategori.FormattingEnabled = true;
            cbKategori.Location = new Point(585, 118);
            cbKategori.Name = "cbKategori";
            cbKategori.Size = new Size(122, 28);
            cbKategori.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(585, 85);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 36;
            label1.Text = "Kategorisi:";
            // 
            // frm_YemekCesitIslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(750, 550);
            Controls.Add(label1);
            Controls.Add(cbKategori);
            Controls.Add(txtKalori);
            Controls.Add(txtAciklama);
            Controls.Add(txtYemekAdi);
            Controls.Add(lblKalori);
            Controls.Add(lblAciklama);
            Controls.Add(lblYemekAdi);
            Controls.Add(lblSecilen);
            Controls.Add(panel);
            Controls.Add(btnGeri);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(dgvMevcutYemekCesitleri);
            Controls.Add(lblYemekCesitleri);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_YemekCesitIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yemek Çeşidi İşlemleri";
            Load += frm_YemekCesitIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMevcutYemekCesitleri).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblYemekCesitleri;
        private DataGridView dgvMevcutYemekCesitleri;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private Button btnGeri;
        private Panel panel;
        private Label lblSecilen;
        private Label lblYemekAdi;
        private Label lblAciklama;
        private Label lblKalori;
        private TextBox txtYemekAdi;
        private TextBox txtAciklama;
        private TextBox txtKalori;
        private ComboBox cbKategori;
        private Label label1;
    }
}