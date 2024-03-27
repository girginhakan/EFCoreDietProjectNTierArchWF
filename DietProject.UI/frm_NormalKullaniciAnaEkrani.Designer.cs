namespace DietProject.UI
{
    partial class frm_NormalKullaniciAnaEkrani
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
            lblTuketilenOgunler = new Label();
            dgvTuketilenOgunler = new DataGridView();
            lblToplamKalori = new Label();
            label3 = new Label();
            btnOgunEkle = new Button();
            btnOgunSil = new Button();
            btnOgunGuncelle = new Button();
            btnGeri = new Button();
            panel = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvTuketilenOgunler).BeginInit();
            SuspendLayout();
            // 
            // lblTuketilenOgunler
            // 
            lblTuketilenOgunler.AutoSize = true;
            lblTuketilenOgunler.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTuketilenOgunler.Location = new Point(46, 128);
            lblTuketilenOgunler.Name = "lblTuketilenOgunler";
            lblTuketilenOgunler.Size = new Size(136, 20);
            lblTuketilenOgunler.TabIndex = 0;
            lblTuketilenOgunler.Text = "Tüketilen Öğünler:";
            // 
            // dgvTuketilenOgunler
            // 
            dgvTuketilenOgunler.BackgroundColor = SystemColors.Info;
            dgvTuketilenOgunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTuketilenOgunler.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvTuketilenOgunler.GridColor = Color.LavenderBlush;
            dgvTuketilenOgunler.Location = new Point(50, 163);
            dgvTuketilenOgunler.Name = "dgvTuketilenOgunler";
            dgvTuketilenOgunler.RowHeadersWidth = 51;
            dgvTuketilenOgunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTuketilenOgunler.Size = new Size(486, 219);
            dgvTuketilenOgunler.TabIndex = 1;
            dgvTuketilenOgunler.CellClick += dgvTuketilenOgunler_CellClick;
            // 
            // lblToplamKalori
            // 
            lblToplamKalori.AutoSize = true;
            lblToplamKalori.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblToplamKalori.Location = new Point(75, 403);
            lblToplamKalori.Name = "lblToplamKalori";
            lblToplamKalori.Size = new Size(357, 20);
            lblToplamKalori.TabIndex = 2;
            lblToplamKalori.Text = "Gün içerisindeki toplam tüketilen kalori miktarınız: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(454, 403);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // btnOgunEkle
            // 
            btnOgunEkle.BackColor = Color.FromArgb(255, 128, 0);
            btnOgunEkle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOgunEkle.ForeColor = SystemColors.ActiveCaptionText;
            btnOgunEkle.Location = new Point(54, 44);
            btnOgunEkle.Name = "btnOgunEkle";
            btnOgunEkle.Size = new Size(139, 53);
            btnOgunEkle.TabIndex = 4;
            btnOgunEkle.Text = "EKLE";
            btnOgunEkle.UseVisualStyleBackColor = false;
            btnOgunEkle.Click += btnOgunEkle_Click;
            // 
            // btnOgunSil
            // 
            btnOgunSil.BackColor = Color.Red;
            btnOgunSil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOgunSil.ForeColor = SystemColors.ActiveCaptionText;
            btnOgunSil.Location = new Point(405, 44);
            btnOgunSil.Name = "btnOgunSil";
            btnOgunSil.Size = new Size(139, 53);
            btnOgunSil.TabIndex = 4;
            btnOgunSil.Text = "SİL";
            btnOgunSil.UseVisualStyleBackColor = false;
            // 
            // btnOgunGuncelle
            // 
            btnOgunGuncelle.BackColor = Color.FromArgb(128, 128, 255);
            btnOgunGuncelle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOgunGuncelle.ForeColor = SystemColors.ActiveCaptionText;
            btnOgunGuncelle.Location = new Point(229, 44);
            btnOgunGuncelle.Name = "btnOgunGuncelle";
            btnOgunGuncelle.Size = new Size(139, 53);
            btnOgunGuncelle.TabIndex = 4;
            btnOgunGuncelle.Text = "GÜNCELLE";
            btnOgunGuncelle.UseVisualStyleBackColor = false;
            btnOgunGuncelle.Click += btnOgunGuncelle_Click;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.Khaki;
            btnGeri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGeri.Location = new Point(75, 433);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(442, 48);
            btnGeri.TabIndex = 9;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // panel
            // 
            panel.BackColor = Color.LightCoral;
            panel.Dock = DockStyle.Top;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(583, 29);
            panel.TabIndex = 10;
            panel.MouseDown += panel_MouseDown;
            // 
            // frm_NormalKullaniciAnaEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(583, 493);
            Controls.Add(panel);
            Controls.Add(btnGeri);
            Controls.Add(btnOgunGuncelle);
            Controls.Add(btnOgunSil);
            Controls.Add(btnOgunEkle);
            Controls.Add(label3);
            Controls.Add(lblToplamKalori);
            Controls.Add(dgvTuketilenOgunler);
            Controls.Add(lblTuketilenOgunler);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_NormalKullaniciAnaEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form10";
            Load += frm_NormalKullaniciAnaEkrani_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTuketilenOgunler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTuketilenOgunler;
        private DataGridView dgvTuketilenOgunler;
        private Label lblToplamKalori;
        private Label label3;
        private Button btnOgunEkle;
        private Button btnOgunSil;
        private Button btnOgunGuncelle;
        private Button btnGeri;
        private Panel panel;
    }
}