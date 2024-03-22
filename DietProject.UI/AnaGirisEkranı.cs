namespace DietProject.UI
{
    public partial class AnaGirisEkraný : Form
    {
        public AnaGirisEkraný()
        {
            InitializeComponent();
        }
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            KullanýcýKayýtFormu kayýtFormu = new KullanýcýKayýtFormu();
            this.Hide();
            kayýtFormu.ShowDialog();
        }
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            KullanýcýGirisEkraný girisEkraný = new KullanýcýGirisEkraný();
            this.Hide( );
            girisEkraný.ShowDialog();
        }
    }
}
