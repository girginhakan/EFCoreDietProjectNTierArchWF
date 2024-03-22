namespace DietProject.UI
{
    partial class NormalKullanıcıAnaEkranı
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
            ((System.ComponentModel.ISupportInitialize)dgvTuketilenOgunler).BeginInit();
            SuspendLayout();
            // 
            // lblTuketilenOgunler
            // 
            lblTuketilenOgunler.AutoSize = true;
            lblTuketilenOgunler.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTuketilenOgunler.Location = new Point(40, 96);
            lblTuketilenOgunler.Name = "lblTuketilenOgunler";
            lblTuketilenOgunler.Size = new Size(104, 15);
            lblTuketilenOgunler.TabIndex = 0;
            lblTuketilenOgunler.Text = "Tüketilen Öğünler:";
            // 
            // dgvTuketilenOgunler
            // 
            dgvTuketilenOgunler.BackgroundColor = SystemColors.Info;
            dgvTuketilenOgunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTuketilenOgunler.GridColor = Color.LavenderBlush;
            dgvTuketilenOgunler.Location = new Point(44, 122);
            dgvTuketilenOgunler.Margin = new Padding(3, 2, 3, 2);
            dgvTuketilenOgunler.Name = "dgvTuketilenOgunler";
            dgvTuketilenOgunler.RowHeadersWidth = 51;
            dgvTuketilenOgunler.Size = new Size(425, 164);
            dgvTuketilenOgunler.TabIndex = 1;
            // 
            // lblToplamKalori
            // 
            lblToplamKalori.AutoSize = true;
            lblToplamKalori.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblToplamKalori.Location = new Point(66, 302);
            lblToplamKalori.Name = "lblToplamKalori";
            lblToplamKalori.Size = new Size(275, 15);
            lblToplamKalori.TabIndex = 2;
            lblToplamKalori.Text = "Gün içerisindeki toplam tüketilen kalori miktarınız: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(397, 302);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // btnOgunEkle
            // 
            btnOgunEkle.BackColor = Color.FromArgb(255, 128, 0);
            btnOgunEkle.Cursor = Cursors.No;
            btnOgunEkle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOgunEkle.ForeColor = SystemColors.ActiveCaptionText;
            btnOgunEkle.Location = new Point(47, 33);
            btnOgunEkle.Margin = new Padding(3, 2, 3, 2);
            btnOgunEkle.Name = "btnOgunEkle";
            btnOgunEkle.Size = new Size(122, 40);
            btnOgunEkle.TabIndex = 4;
            btnOgunEkle.Text = "EKLE";
            btnOgunEkle.UseVisualStyleBackColor = false;
            btnOgunEkle.Click += btnOgunEkle_Click;
            // 
            // btnOgunSil
            // 
            btnOgunSil.BackColor = Color.Red;
            btnOgunSil.Cursor = Cursors.No;
            btnOgunSil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOgunSil.ForeColor = SystemColors.ActiveCaptionText;
            btnOgunSil.Location = new Point(354, 33);
            btnOgunSil.Margin = new Padding(3, 2, 3, 2);
            btnOgunSil.Name = "btnOgunSil";
            btnOgunSil.Size = new Size(122, 40);
            btnOgunSil.TabIndex = 4;
            btnOgunSil.Text = "SİL";
            btnOgunSil.UseVisualStyleBackColor = false;
            // 
            // btnOgunGuncelle
            // 
            btnOgunGuncelle.BackColor = Color.FromArgb(128, 128, 255);
            btnOgunGuncelle.Cursor = Cursors.No;
            btnOgunGuncelle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOgunGuncelle.ForeColor = SystemColors.ActiveCaptionText;
            btnOgunGuncelle.Location = new Point(200, 33);
            btnOgunGuncelle.Margin = new Padding(3, 2, 3, 2);
            btnOgunGuncelle.Name = "btnOgunGuncelle";
            btnOgunGuncelle.Size = new Size(122, 40);
            btnOgunGuncelle.TabIndex = 4;
            btnOgunGuncelle.Text = "GÜNCELLE";
            btnOgunGuncelle.UseVisualStyleBackColor = false;
            btnOgunGuncelle.Click += button3_Click;
            // 
            // NormalKullanıcıAnaEkranı
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(510, 370);
            Controls.Add(btnOgunGuncelle);
            Controls.Add(btnOgunSil);
            Controls.Add(btnOgunEkle);
            Controls.Add(label3);
            Controls.Add(lblToplamKalori);
            Controls.Add(dgvTuketilenOgunler);
            Controls.Add(lblTuketilenOgunler);
            Margin = new Padding(3, 2, 3, 2);
            Name = "NormalKullanıcıAnaEkranı";
            Text = "Form10";
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
    }
}