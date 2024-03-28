namespace DietProject.UI
{
    partial class frm_OgunIslemleri
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
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            dgvMevcutOgunler = new DataGridView();
            lblMevcutOgunler = new Label();
            txtOgunAdi = new TextBox();
            lblOgunAdi = new Label();
            lblAciklama = new Label();
            txtAciklama = new TextBox();
            lblSecilen = new Label();
            btnGeri = new Button();
            panel = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvMevcutOgunler).BeginInit();
            SuspendLayout();
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Goldenrod;
            btnGuncelle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGuncelle.Location = new Point(421, 373);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(140, 50);
            btnGuncelle.TabIndex = 8;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Coral;
            btnSil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSil.Location = new Point(421, 456);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(140, 50);
            btnSil.TabIndex = 9;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.DarkKhaki;
            btnEkle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnEkle.Location = new Point(581, 373);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(140, 50);
            btnEkle.TabIndex = 10;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // dgvMevcutOgunler
            // 
            dgvMevcutOgunler.BackgroundColor = Color.LightGray;
            dgvMevcutOgunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMevcutOgunler.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvMevcutOgunler.Location = new Point(49, 85);
            dgvMevcutOgunler.Name = "dgvMevcutOgunler";
            dgvMevcutOgunler.RowHeadersWidth = 51;
            dgvMevcutOgunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMevcutOgunler.Size = new Size(350, 420);
            dgvMevcutOgunler.TabIndex = 7;
            dgvMevcutOgunler.CellClick += dgvMevcutOgunler_CellClick;
            // 
            // lblMevcutOgunler
            // 
            lblMevcutOgunler.AutoSize = true;
            lblMevcutOgunler.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblMevcutOgunler.Location = new Point(131, 45);
            lblMevcutOgunler.Name = "lblMevcutOgunler";
            lblMevcutOgunler.Size = new Size(120, 20);
            lblMevcutOgunler.TabIndex = 6;
            lblMevcutOgunler.Text = "Mevcut Öğünler";
            // 
            // txtOgunAdi
            // 
            txtOgunAdi.Location = new Point(421, 171);
            txtOgunAdi.Margin = new Padding(3, 4, 3, 4);
            txtOgunAdi.Name = "txtOgunAdi";
            txtOgunAdi.Size = new Size(299, 27);
            txtOgunAdi.TabIndex = 11;
            // 
            // lblOgunAdi
            // 
            lblOgunAdi.AutoSize = true;
            lblOgunAdi.Location = new Point(421, 136);
            lblOgunAdi.Name = "lblOgunAdi";
            lblOgunAdi.Size = new Size(79, 20);
            lblOgunAdi.TabIndex = 12;
            lblOgunAdi.Text = "Öğün Adı: ";
            // 
            // lblAciklama
            // 
            lblAciklama.AutoSize = true;
            lblAciklama.Location = new Point(421, 252);
            lblAciklama.Name = "lblAciklama";
            lblAciklama.Size = new Size(70, 20);
            lblAciklama.TabIndex = 13;
            lblAciklama.Text = "Açıklama";
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(423, 289);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(297, 27);
            txtAciklama.TabIndex = 14;
            // 
            // lblSecilen
            // 
            lblSecilen.AutoSize = true;
            lblSecilen.Location = new Point(421, 85);
            lblSecilen.Name = "lblSecilen";
            lblSecilen.Size = new Size(50, 20);
            lblSecilen.TabIndex = 15;
            lblSecilen.Text = "label1";
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.Khaki;
            btnGeri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGeri.Location = new Point(581, 456);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(140, 50);
            btnGeri.TabIndex = 16;
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
            panel.TabIndex = 17;
            panel.MouseDown += panel_MouseDown;
            // 
            // frm_OgunIslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(750, 550);
            Controls.Add(panel);
            Controls.Add(btnGeri);
            Controls.Add(lblSecilen);
            Controls.Add(txtAciklama);
            Controls.Add(lblAciklama);
            Controls.Add(lblOgunAdi);
            Controls.Add(txtOgunAdi);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(dgvMevcutOgunler);
            Controls.Add(lblMevcutOgunler);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_OgunIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Öğün İşlemleri";
            Load += frm_OgunIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMevcutOgunler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private DataGridView dgvMevcutOgunler;
        private Label lblMevcutOgunler;
        private TextBox txtOgunAdi;
        private Label lblOgunAdi;
        private Label lblAciklama;
        private TextBox txtAciklama;
        private Label lblSecilen;
        private Button btnGeri;
        private Panel panel;
    }
}