using DietProject.BLL.Manager.Concrete;

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
    }
}