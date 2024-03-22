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
            txtOgunEkle = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMevcutOgunler).BeginInit();
            SuspendLayout();
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(255, 128, 0);
            btnGuncelle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGuncelle.Location = new Point(356, 240);
            btnGuncelle.Margin = new Padding(3, 2, 3, 2);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(130, 57);
            btnGuncelle.TabIndex = 8;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Crimson;
            btnSil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSil.Location = new Point(356, 168);
            btnSil.Margin = new Padding(3, 2, 3, 2);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(130, 57);
            btnSil.TabIndex = 9;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Lime;
            btnEkle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnEkle.Location = new Point(356, 95);
            btnEkle.Margin = new Padding(3, 2, 3, 2);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(130, 57);
            btnEkle.TabIndex = 10;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // dgvMevcutOgunler
            // 
            dgvMevcutOgunler.BackgroundColor = Color.LightGray;
            dgvMevcutOgunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMevcutOgunler.Location = new Point(33, 56);
            dgvMevcutOgunler.Margin = new Padding(3, 2, 3, 2);
            dgvMevcutOgunler.Name = "dgvMevcutOgunler";
            dgvMevcutOgunler.RowHeadersWidth = 51;
            dgvMevcutOgunler.Size = new Size(290, 271);
            dgvMevcutOgunler.TabIndex = 7;
            // 
            // lblMevcutOgunler
            // 
            lblMevcutOgunler.AutoSize = true;
            lblMevcutOgunler.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblMevcutOgunler.Location = new Point(126, 20);
            lblMevcutOgunler.Name = "lblMevcutOgunler";
            lblMevcutOgunler.Size = new Size(93, 15);
            lblMevcutOgunler.TabIndex = 6;
            lblMevcutOgunler.Text = "Mevcut Öğünler";
            // 
            // txtOgunEkle
            // 
            txtOgunEkle.Location = new Point(356, 56);
            txtOgunEkle.Name = "txtOgunEkle";
            txtOgunEkle.Size = new Size(130, 23);
            txtOgunEkle.TabIndex = 11;
            // 
            // frm_OgunIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(510, 370);
            Controls.Add(txtOgunEkle);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(dgvMevcutOgunler);
            Controls.Add(lblMevcutOgunler);
            Margin = new Padding(3, 2, 3, 2);
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
        private TextBox txtOgunEkle;
    }
}