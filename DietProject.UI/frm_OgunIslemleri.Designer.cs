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
            ((System.ComponentModel.ISupportInitialize)dgvMevcutOgunler).BeginInit();
            SuspendLayout();
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(255, 128, 0);
            btnGuncelle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGuncelle.Location = new Point(569, 360);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(149, 76);
            btnGuncelle.TabIndex = 8;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Crimson;
            btnSil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSil.Location = new Point(724, 360);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(149, 76);
            btnSil.TabIndex = 9;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Lime;
            btnEkle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnEkle.Location = new Point(404, 360);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(149, 76);
            btnEkle.TabIndex = 10;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // dgvMevcutOgunler
            // 
            dgvMevcutOgunler.BackgroundColor = Color.LightGray;
            dgvMevcutOgunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMevcutOgunler.Location = new Point(38, 68);
            dgvMevcutOgunler.Name = "dgvMevcutOgunler";
            dgvMevcutOgunler.RowHeadersWidth = 51;
            dgvMevcutOgunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMevcutOgunler.Size = new Size(331, 368);
            dgvMevcutOgunler.TabIndex = 7;
            dgvMevcutOgunler.CellClick += dgvMevcutOgunler_CellClick;
            // 
            // lblMevcutOgunler
            // 
            lblMevcutOgunler.AutoSize = true;
            lblMevcutOgunler.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblMevcutOgunler.Location = new Point(120, 28);
            lblMevcutOgunler.Name = "lblMevcutOgunler";
            lblMevcutOgunler.Size = new Size(120, 20);
            lblMevcutOgunler.TabIndex = 6;
            lblMevcutOgunler.Text = "Mevcut Öğünler";
            // 
            // txtOgunAdi
            // 
            txtOgunAdi.Location = new Point(404, 114);
            txtOgunAdi.Margin = new Padding(3, 4, 3, 4);
            txtOgunAdi.Name = "txtOgunAdi";
            txtOgunAdi.Size = new Size(375, 27);
            txtOgunAdi.TabIndex = 11;
            // 
            // lblOgunAdi
            // 
            lblOgunAdi.AutoSize = true;
            lblOgunAdi.Location = new Point(404, 79);
            lblOgunAdi.Name = "lblOgunAdi";
            lblOgunAdi.Size = new Size(79, 20);
            lblOgunAdi.TabIndex = 12;
            lblOgunAdi.Text = "Öğün Adı: ";
            // 
            // lblAciklama
            // 
            lblAciklama.AutoSize = true;
            lblAciklama.Location = new Point(404, 204);
            lblAciklama.Name = "lblAciklama";
            lblAciklama.Size = new Size(70, 20);
            lblAciklama.TabIndex = 13;
            lblAciklama.Text = "Açıklama";
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(406, 241);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(371, 27);
            txtAciklama.TabIndex = 14;
            // 
            // lblSecilen
            // 
            lblSecilen.AutoSize = true;
            lblSecilen.Location = new Point(403, 28);
            lblSecilen.Name = "lblSecilen";
            lblSecilen.Size = new Size(50, 20);
            lblSecilen.TabIndex = 15;
            lblSecilen.Text = "label1";
            // 
            // frm_OgunIslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(891, 493);
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
            Name = "frm_OgunIslemleri";
            Text = "Öğün İşlemleri";
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
    }
}