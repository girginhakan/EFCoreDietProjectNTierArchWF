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
            btnGeri = new Button();
            panel = new Panel();
            tbEnCokTuketilenYemek = new TabControl();
            tabPage1 = new TabPage();
            dataGridView2 = new DataGridView();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            tabPage3 = new TabPage();
            dataGridView3 = new DataGridView();
            tbEnCokTuketilenYemek.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.Khaki;
            btnGeri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGeri.Location = new Point(54, 315);
            btnGeri.Margin = new Padding(3, 2, 3, 2);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(130, 30);
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
            panel.Margin = new Padding(3, 2, 3, 2);
            panel.Name = "panel";
            panel.Size = new Size(979, 22);
            panel.TabIndex = 28;
            panel.Paint += panel_Paint;
            panel.MouseDown += panel_MouseDown;
            // 
            // tbEnCokTuketilenYemek
            // 
            tbEnCokTuketilenYemek.Controls.Add(tabPage1);
            tbEnCokTuketilenYemek.Controls.Add(tabPage2);
            tbEnCokTuketilenYemek.Controls.Add(tabPage3);
            tbEnCokTuketilenYemek.Location = new Point(54, 43);
            tbEnCokTuketilenYemek.Name = "tbEnCokTuketilenYemek";
            tbEnCokTuketilenYemek.SelectedIndex = 0;
            tbEnCokTuketilenYemek.Size = new Size(750, 244);
            tbEnCokTuketilenYemek.TabIndex = 29;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(742, 216);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "En Çok Tüketilen Yemek Rapor";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(50, 28);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(626, 150);
            dataGridView2.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(742, 216);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Haftalık Raporlama";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(66, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(612, 150);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(742, 216);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Aylık Raporlama";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(49, 20);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(612, 150);
            dataGridView3.TabIndex = 0;
            // 
            // s
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(979, 370);
            Controls.Add(tbEnCokTuketilenYemek);
            Controls.Add(panel);
            Controls.Add(btnGeri);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "s";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Raporlar";
            Load += s_Load;
            tbEnCokTuketilenYemek.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnGeri;
        private Panel panel;
        private TabControl tbEnCokTuketilenYemek;
        private TabPage tabPage1;
        private DataGridView dataGridView2;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private TabPage tabPage3;
        private DataGridView dataGridView3;
    }
}