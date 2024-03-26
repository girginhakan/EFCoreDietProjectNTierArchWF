using DietProject.BLL.Manager.Concrete;
using System.Runtime.InteropServices;

namespace DietProject.UI
{
    public partial class frm_AnaGirisEkrani : Form
    {
        public frm_AnaGirisEkrani()
        {
            InitializeComponent();


        }
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            frm_KullaniciKayitFormu kayitFormu = new frm_KullaniciKayitFormu();
            this.Hide();
            kayitFormu.Show();
        }
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            frm_KullaniciGirisEkrani girisEkrani = new frm_KullaniciGirisEkrani();
            this.Hide();
            girisEkrani.Show();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Çıkış yapmak  istiyormusunuz ?", "Uyarı", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
 

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            Metodlar.ReleaseCapture();
            Metodlar.SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }

}
