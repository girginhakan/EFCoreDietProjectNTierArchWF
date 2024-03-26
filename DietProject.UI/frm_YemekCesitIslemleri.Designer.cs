﻿namespace DietProject.UI
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
            dgvMevcutYemekCesitleri.Location = new Point(39, 85);
            dgvMevcutYemekCesitleri.Name = "dgvMevcutYemekCesitleri";
            dgvMevcutYemekCesitleri.RowHeadersWidth = 51;
            dgvMevcutYemekCesitleri.Size = new Size(332, 389);
            dgvMevcutYemekCesitleri.TabIndex = 2;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(255, 128, 0);
            btnGuncelle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGuncelle.Location = new Point(408, 330);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(148, 76);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Crimson;
            btnSil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSil.Location = new Point(408, 234);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(148, 76);
            btnSil.TabIndex = 4;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Lime;
            btnEkle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnEkle.Location = new Point(408, 137);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(148, 76);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.Khaki;
            btnGeri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGeri.Location = new Point(408, 424);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(148, 50);
            btnGeri.TabIndex = 26;
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
            panel.Size = new Size(583, 29);
            panel.TabIndex = 27;
            panel.MouseDown += panel_MouseDown;
            // 
            // frm_YemekCesitIslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(583, 494);
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
    }
}