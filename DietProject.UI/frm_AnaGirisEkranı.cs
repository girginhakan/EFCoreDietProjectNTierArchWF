using DietProject.BLL.Manager.Concrete;

namespace DietProject.UI
{
    public partial class frm_AnaGirisEkraný : Form
    {
        public frm_AnaGirisEkraný()
        {
            InitializeComponent();


          
          


        }
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            frm_KullanýcýKayýtFormu kayýtFormu = new frm_KullanýcýKayýtFormu();
            this.Hide();
            kayýtFormu.ShowDialog();
        }
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            frm_KullanýcýGirisEkraný girisEkraný = new frm_KullanýcýGirisEkraný();
            this.Hide( );
            girisEkraný.ShowDialog();
        }
    }
}
