//using DietProject.DAL.Context;
//using DietProject.DAL.Entities;
using DietProject.BLL;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using DietProject.BLL.Manager.Concrete;
using DietProject.BLL.Models;
using System.Text.RegularExpressions;
using System.Security.Policy;

namespace DietProject.UI
{
    public partial class frm_KullaniciKayitFormu : Form
    {
        DateTime secilenTarih;
        public frm_KullaniciKayitFormu()
        {



            InitializeComponent();
            YılAyGün();

        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            Metodlar.ReleaseCapture();
            Metodlar.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void YılAyGün()
        {
            for (int yil = 1979; yil <= 2006; yil++)
            {
                cbYıl.Items.Add(yil.ToString());
            }
            for (int gun = 1; gun <= 31; gun++)
            {
                cbGün.Items.Add(gun.ToString());
            }
            for (int ay = 1; ay <= 12; ay++)
            {
                cbAy.Items.Add(ay.ToString());
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnKullaniciKayitİptal_Click(object sender, EventArgs e)
        {
            frm_AnaGirisEkrani anaGirisEkrani = new frm_AnaGirisEkrani();
            this.Close();
            anaGirisEkrani.Show();

        }

        private void btnKullaniciKaydet_Click(object sender, EventArgs e)
        {


            KullaniciModel kullaniciModel = new KullaniciModel();

            //---AD-----------
            if (!AlanKontrol(txtAd.Text))
            {
                MessageBox.Show("Lütfen adinizi giriniz.");
                return;
            }
            else
                kullaniciModel.Adi = txtAd.Text;


            //----SOYAD------------

            if (!AlanKontrol(txtSoyad.Text))
            {
                MessageBox.Show("Lütfen soyadınızı giriniz.");
                return;
            }
            else
                kullaniciModel.Soyadi = txtSoyad.Text;



            //-----EMAİL------------


            if (!AlanKontrol(txtEposta.Text))
            {
                MessageBox.Show("Lütfen epostanızı giriniz.");
                return;
            }
            else
                kullaniciModel.Eposta = txtEposta.Text;

            //-----ŞİFRE------------

            if (PasswordControl())
            {
                kullaniciModel.Sifre = Metodlar.Sha256Hash(txtSifre.Text);
            }
            else
            {
                MessageBox.Show("Sifre kontrolünüz basarili olamadi, kayit islemi için uygun şifre giriniz.");
                return;
            }
            int secilenYil, secilenAy, secilenGun;
            //-----YIL-----------
            if ((cbYıl.SelectedItem.ToString() != string.Empty))
            {
                secilenYil = int.Parse(cbYıl.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Yıl alanı boş geçilemez");
                return;
            }

            if ((cbAy.SelectedItem.ToString() != string.Empty))
            {
                secilenAy = int.Parse(cbAy.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Ay alanı boş geçilemez");
                return;
            }
            if ((cbGün.SelectedItem.ToString() != string.Empty))
            {
                secilenGun = int.Parse(cbGün.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Gün alanı boş geçilemez");
                return;
            }

            secilenTarih = new DateTime(secilenYil, secilenAy, secilenGun);
            kullaniciModel.DogumTarihi = secilenTarih;




            // ----BOY---------

            string boyString = txtBoy.Text;

            if (double.TryParse(boyString, out double boy))
            {
                if (boy < 240 & boy > 140 && boyString != string.Empty)
                {
                    kullaniciModel.Boy = boy;
                }
                else
                {
                    MessageBox.Show("Boy aralıkları dışında giriş yada boy alanı boş girilemez yaptınız.");
                    return;

                }
            }
            else
            {
                MessageBox.Show("Geçersiz boy formatı!");
                return;
            }


            // ------KİLO-------------

            string kiloString = txtKilo.Text;
            if (double.TryParse(kiloString, out double kilo))
            {
                if (kilo < 240 & kilo > 40 && kiloString != string.Empty)
                {
                    kullaniciModel.Kilo = kilo;
                }
                else
                {
                    MessageBox.Show("Kilo aralıkları dışında giriş yaptınız.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Geçersiz kilo formatı!");
                return;
            }


            //-------DATABASEİŞLEMLERİ---------

            KullaniciManager kullaniciManager = new KullaniciManager();

            kullaniciManager.Add(kullaniciModel);
            MessageBox.Show("Kullanıcı başarıyla oluşturuldu. Anasayfaya yönlendiriliyorsunuz.");
            this.Close();
            frm_AnaGirisEkrani anaGirisEkrani = new frm_AnaGirisEkrani();
            anaGirisEkrani.Show();


        }

        public static bool AlanKontrol(string alan)
        {
            if (string.IsNullOrWhiteSpace(alan))
                return false;
            return true;
        }

        private bool PasswordControl()
        {
            string psswrd = txtSifre.Text;

            if (psswrd != null && psswrd.Length >= 8)
            {
                int uppercaseCount = psswrd.Count(char.IsUpper);
                int lowercaseCount = psswrd.Count(char.IsLower);
                int specialCharacterCount = Regex.Matches(psswrd, @"[!:+*]").Count;

                if (uppercaseCount < 2)
                {
                    MessageBox.Show("En az 2 büyük harf içermelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (lowercaseCount < 3)
                {
                    MessageBox.Show("En az üç küçük harf içermelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (specialCharacterCount < 2)
                {
                    MessageBox.Show("En az iki özel karakter (!:+*) içermelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                return true;
            }
            else
            {
                MessageBox.Show("Sifre en az 8 karakter içermelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void frm_KullaniciKayitFormu_Load(object sender, EventArgs e)
        {
            cbYıl.SelectedText = DateTime.Now.Year.ToString();
            cbAy.SelectedText = DateTime.Now.Month.ToString();
            cbGün.SelectedText = DateTime.Now.Day.ToString();
        }
    }
}
