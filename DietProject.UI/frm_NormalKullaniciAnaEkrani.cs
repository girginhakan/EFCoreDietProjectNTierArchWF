using DietProject.BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietProject.UI
{
    public partial class frm_NormalKullaniciAnaEkrani : Form
    {
        //public KullaniciModel SecilenKullanici {  get; set; } 
        //public frm_KullaniciGirisEkrani MainForm { get; set; }
        public frm_NormalKullaniciAnaEkrani()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnOgunEkle_Click(object sender, EventArgs e)
        {
            frm_NormalKullaniciOgunEkleme normalKullanıcıOgunEkleme = new frm_NormalKullaniciOgunEkleme();
            normalKullanıcıOgunEkleme.Show();
            this.Hide();
        }
    }
}
