using DietProject.BLL.Manager.Concrete;
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
    public partial class frm_NormalKullaniciOgunEkleme : Form
    {
        public KullaniciOgunYemekPorsiyonModel GelenOgun { get; set; }
        OgunManager ogunManager = new OgunManager();
        PorsiyonManager porsiyonManager = new PorsiyonManager();
        YemekManager yemekManager = new YemekManager();
        KategoriManager kategoriManager = new KategoriManager();
        KullaniciOgunYemekPorsiyonManager kullaniciOgunYemekPorsiyon = new KullaniciOgunYemekPorsiyonManager();

        public frm_NormalKullaniciOgunEkleme()
        {
            InitializeComponent();

            var seciliYemekGuncelle = GelenOgun;

            if (seciliYemekGuncelle != null)
            {
                
            }
            else
            {
                btnGuncelle.Visible = true;
                btnKullaniciYemekKaydet.Visible = false;

            }

            cbOgun.DataSource = ogunManager.GetAll();
            cbOgun.DisplayMember = "OgunAdi";
            cbOgun.ValueMember = "Id";

            cbYemekKategori.DataSource = kategoriManager.GetAll();
            cbYemekKategori.DisplayMember = "KategoriAdi";
            cbYemekKategori.ValueMember = "Id";

            cbPorsiyonBirimi.DataSource = porsiyonManager.GetAll();
            cbPorsiyonBirimi.DisplayMember = "PorsiyonBirim";
            cbPorsiyonBirimi.DisplayMember = "Id";

            //cbYemekCesidi.DisplayMember = "YemekAdi";
            //cbYemekCesidi.ValueMember = "Id";

        }


        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            Metodlar.ReleaseCapture();
            Metodlar.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnKullaniciKayitİptal_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_NormalKullaniciAnaEkrani normalKullaniciAnaEkrani = new frm_NormalKullaniciAnaEkrani();
            normalKullaniciAnaEkrani.Show();

        }

        private void cbYemekKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is not null)
            {
                ComboBox cbYemekKategori = sender as ComboBox;

                KategoriModel selectedKategori = (KategoriModel)cbYemekKategori.SelectedItem;

                YemekManager yemekManager = new YemekManager();
                List<YemekModel> yemekModel = yemekManager.Search(y => y.KategoriId == selectedKategori.Id);

                cbYemekCesidi.DataSource = yemekModel;
                cbYemekCesidi.DisplayMember = "YemekAdi";
                cbYemekCesidi.ValueMember = "Id";

            }


        }

        private void btnKullaniciYemekKaydet_Click(object sender, EventArgs e)
        {
            KullaniciOgunYemekPorsiyonModel kullaniciOgun = new KullaniciOgunYemekPorsiyonModel();

            kullaniciOgun.KullaniciId = Program.KullaniciModel.Id;
            if (cbYemekCesidi.SelectedText != null && cbYemekKategori.SelectedText != null && cbOgun.SelectedText != null && cbPorsiyonBirimi.SelectedText != null && txtPorsiyonMiktari.Text != string.Empty)
            {
                kullaniciOgun.YemekId = ((YemekModel)cbYemekCesidi.SelectedItem).Id;

                kullaniciOgun.OgunId = ((OgunModel)cbOgun.SelectedItem).Id;
                kullaniciOgun.PorsiyonId = ((PorsiyonModel)cbPorsiyonBirimi.SelectedItem).Id;
                kullaniciOgun.PorsiyonMiktari = int.Parse(txtPorsiyonMiktari.Text);


                kullaniciOgunYemekPorsiyon.Add(kullaniciOgun);
                MessageBox.Show("İlgili Öğün başarıyla profilinize eklnmiştir");
                frm_NormalKullaniciAnaEkrani kullaniciAnaEkrani = new frm_NormalKullaniciAnaEkrani();
                this.Close();
                kullaniciAnaEkrani.Show();
            }
            else
            {
                MessageBox.Show("Bütün alanları girmeniz gerekmektedir.");
                return;
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            if (Program.SecilenYemek != null)
            {

                Program.SecilenYemek.Id = Program.KullaniciModel.Id;

                GelenOgun.YemekId= ((YemekModel)(cbYemekCesidi.SelectedItem)).Id;
                GelenOgun.OgunId= ((OgunModel)cbOgun.SelectedItem).Id;
                GelenOgun.PorsiyonId = ((PorsiyonModel)(cbPorsiyonBirimi.SelectedItem)).Id;
                GelenOgun.PorsiyonMiktari = double.Parse(txtPorsiyonMiktari.Text);
                kullaniciOgunYemekPorsiyon.Update(GelenOgun);

                MessageBox.Show("Öğün guncellenmistir");

            }
            else
                MessageBox.Show("Secili Öğün Yok!");
        }
    }
}
