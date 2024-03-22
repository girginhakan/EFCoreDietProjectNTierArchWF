namespace DietProject.UI
{
    partial class OgunIslemleri
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
            ((System.ComponentModel.ISupportInitialize)dgvMevcutOgunler).BeginInit();
            SuspendLayout();
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(255, 128, 0);
            btnGuncelle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGuncelle.Location = new Point(407, 320);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(148, 76);
            btnGuncelle.TabIndex = 8;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Crimson;
            btnSil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSil.Location = new Point(407, 224);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(148, 76);
            btnSil.TabIndex = 9;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Lime;
            btnEkle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnEkle.Location = new Point(407, 127);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(148, 76);
            btnEkle.TabIndex = 10;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            // 
            // dgvMevcutOgunler
            // 
            dgvMevcutOgunler.BackgroundColor = Color.LightGray;
            dgvMevcutOgunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMevcutOgunler.Location = new Point(38, 75);
            dgvMevcutOgunler.Name = "dgvMevcutOgunler";
            dgvMevcutOgunler.RowHeadersWidth = 51;
            dgvMevcutOgunler.Size = new Size(332, 361);
            dgvMevcutOgunler.TabIndex = 7;
            // 
            // lblMevcutOgunler
            // 
            lblMevcutOgunler.AutoSize = true;
            lblMevcutOgunler.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblMevcutOgunler.Location = new Point(144, 27);
            lblMevcutOgunler.Name = "lblMevcutOgunler";
            lblMevcutOgunler.Size = new Size(120, 20);
            lblMevcutOgunler.TabIndex = 6;
            lblMevcutOgunler.Text = "Mevcut Öğünler";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(583, 494);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(dgvMevcutOgunler);
            Controls.Add(lblMevcutOgunler);
            Name = "Form7";
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
    }
}