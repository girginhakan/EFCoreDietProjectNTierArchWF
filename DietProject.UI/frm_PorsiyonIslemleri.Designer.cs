namespace DietProject.UI
{
    partial class frm_PorsiyonIslemleri
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
            btnPorsiyonGuncelle = new Button();
            btnPorsiyonSil = new Button();
            btnPorsiyonEkle = new Button();
            dgvMevcutPorsiyonlar = new DataGridView();
            lblMevcutPorsiyonlar = new Label();
            lblPorsiyonBirim = new Label();
            txtPorsiyonBirim = new TextBox();
            lblSecilen1 = new Label();
            btnGeri = new Button();
            panel = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvMevcutPorsiyonlar).BeginInit();
            SuspendLayout();
            // 
            // btnPorsiyonGuncelle
            // 
            btnPorsiyonGuncelle.BackColor = Color.FromArgb(255, 128, 0);
            btnPorsiyonGuncelle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnPorsiyonGuncelle.Location = new Point(562, 220);
            btnPorsiyonGuncelle.Name = "btnPorsiyonGuncelle";
            btnPorsiyonGuncelle.Size = new Size(148, 45);
            btnPorsiyonGuncelle.TabIndex = 13;
            btnPorsiyonGuncelle.Text = "GÜNCELLE";
            btnPorsiyonGuncelle.UseVisualStyleBackColor = false;
            btnPorsiyonGuncelle.Click += btnPorsiyonGuncelle_Click;
            // 
            // btnPorsiyonSil
            // 
            btnPorsiyonSil.BackColor = Color.Crimson;
            btnPorsiyonSil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnPorsiyonSil.Location = new Point(562, 271);
            btnPorsiyonSil.Name = "btnPorsiyonSil";
            btnPorsiyonSil.Size = new Size(148, 47);
            btnPorsiyonSil.TabIndex = 14;
            btnPorsiyonSil.Text = "SİL";
            btnPorsiyonSil.UseVisualStyleBackColor = false;
            btnPorsiyonSil.Click += btnPorsiyonSil_Click;
            // 
            // btnPorsiyonEkle
            // 
            btnPorsiyonEkle.BackColor = Color.Lime;
            btnPorsiyonEkle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnPorsiyonEkle.Location = new Point(405, 217);
            btnPorsiyonEkle.Name = "btnPorsiyonEkle";
            btnPorsiyonEkle.Size = new Size(148, 48);
            btnPorsiyonEkle.TabIndex = 15;
            btnPorsiyonEkle.Text = "EKLE";
            btnPorsiyonEkle.UseVisualStyleBackColor = false;
            btnPorsiyonEkle.Click += btnPorsiyonEkle_Click;
            // 
            // dgvMevcutPorsiyonlar
            // 
            dgvMevcutPorsiyonlar.BackgroundColor = Color.LightGray;
            dgvMevcutPorsiyonlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMevcutPorsiyonlar.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvMevcutPorsiyonlar.Location = new Point(51, 83);
            dgvMevcutPorsiyonlar.Name = "dgvMevcutPorsiyonlar";
            dgvMevcutPorsiyonlar.RowHeadersWidth = 51;
            dgvMevcutPorsiyonlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMevcutPorsiyonlar.Size = new Size(332, 418);
            dgvMevcutPorsiyonlar.TabIndex = 12;
            dgvMevcutPorsiyonlar.CellClick += dgvMevcutPorsiyonMiktarları_CellClick;
            // 
            // lblMevcutPorsiyonlar
            // 
            lblMevcutPorsiyonlar.AutoSize = true;
            lblMevcutPorsiyonlar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblMevcutPorsiyonlar.Location = new Point(159, 48);
            lblMevcutPorsiyonlar.Name = "lblMevcutPorsiyonlar";
            lblMevcutPorsiyonlar.Size = new Size(141, 20);
            lblMevcutPorsiyonlar.TabIndex = 11;
            lblMevcutPorsiyonlar.Text = "Mevcut Porsiyonlar";
            // 
            // lblPorsiyonBirim
            // 
            lblPorsiyonBirim.AutoSize = true;
            lblPorsiyonBirim.Location = new Point(406, 118);
            lblPorsiyonBirim.Name = "lblPorsiyonBirim";
            lblPorsiyonBirim.Size = new Size(107, 20);
            lblPorsiyonBirim.TabIndex = 22;
            lblPorsiyonBirim.Text = "Porsiyon Birimi";
            // 
            // txtPorsiyonBirim
            // 
            txtPorsiyonBirim.Location = new Point(409, 155);
            txtPorsiyonBirim.Name = "txtPorsiyonBirim";
            txtPorsiyonBirim.Size = new Size(295, 27);
            txtPorsiyonBirim.TabIndex = 23;
            // 
            // lblSecilen1
            // 
            lblSecilen1.AutoSize = true;
            lblSecilen1.Location = new Point(409, 83);
            lblSecilen1.Name = "lblSecilen1";
            lblSecilen1.Size = new Size(50, 20);
            lblSecilen1.TabIndex = 24;
            lblSecilen1.Text = "label1";
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.Khaki;
            btnGeri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGeri.Location = new Point(405, 273);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(156, 41);
            btnGeri.TabIndex = 25;
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
            panel.Size = new Size(774, 29);
            panel.TabIndex = 26;
            panel.MouseDown += panel_MouseDown;
            // 
            // frm_PorsiyonIslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(774, 539);
            Controls.Add(panel);
            Controls.Add(btnGeri);
            Controls.Add(lblSecilen1);
            Controls.Add(txtPorsiyonBirim);
            Controls.Add(lblPorsiyonBirim);
            Controls.Add(btnPorsiyonGuncelle);
            Controls.Add(btnPorsiyonSil);
            Controls.Add(btnPorsiyonEkle);
            Controls.Add(dgvMevcutPorsiyonlar);
            Controls.Add(lblMevcutPorsiyonlar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_PorsiyonIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Porsiyon İşlemleri";
            ((System.ComponentModel.ISupportInitialize)dgvMevcutPorsiyonlar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPorsiyonGuncelle;
        private Button btnPorsiyonSil;
        private Button btnPorsiyonEkle;
        private DataGridView dgvMevcutPorsiyonlar;
        private Label lblMevcutPorsiyonlar;
        private Label lblPorsiyonBirim;
        private TextBox txtPorsiyonBirim;
        private Label lblSecilen1;
        private Button btnGeri;
        private Panel panel;
    }
}