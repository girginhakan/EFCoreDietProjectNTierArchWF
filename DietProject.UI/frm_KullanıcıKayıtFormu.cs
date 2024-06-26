﻿using DietProject.DAL.Context;
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

namespace DietProject.UI
{
    public partial class frm_KullanıcıKayıtFormu : Form
    {

        public frm_KullanıcıKayıtFormu()
        {
            InitializeComponent();
            YılAyGün();

        }

        private void YılAyGün()
        {
            for (int yil = 1979; yil <= 2006; yil++)
            {
                cbYıl.Items.Add(yil.ToString());
            }
            for (int gun= 1; gun <=31 ; gun++)
            {
                cbGün.Items.Add(gun.ToString());
            }
            for(int ay= 1; ay  <= 12 ; ay++) 
            { 
                cbAy.Items.Add(ay.ToString());
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnKullaniciKayitİptal_Click(object sender, EventArgs e)
        {
            frm_AnaGirisEkranı anaGirisEkranı = new frm_AnaGirisEkranı();
            this.Close();
            anaGirisEkranı.Show();

        }

        private void btnKullaniciKaydet_Click(object sender, EventArgs e)
        {
            KullaniciDetayModel kullaniciDetayModel = new KullaniciDetayModel();
            
            KullaniciModel kullaniciModel = new KullaniciModel();


            string isim = txtAd.Text;
            if (isim.Any(char.IsDigit) && isim.Length < 3 && isim.IsNullOrEmpty())
            {
                MessageBox.Show("Lütfen adınızı uygun şekilde giriniz.");
            }
            else
            {
                kullaniciDetayModel.Adi=isim;
            }

            string soyad = txtSoyad.Text;
            if (soyad.Any(char.IsDigit) && soyad.Length < 3 && soyad.IsNullOrEmpty())
            {
                MessageBox.Show("Lütfen soyadınız uygun şekilde giriniz.");
            }
            else
            {
                kullaniciDetayModel.Soyadi = soyad;    
            }

            string email = txtEposta.Text;
            if (email.IsNullOrEmpty() && !(email.Contains("@")) && !(email.EndsWith(".com")))
            {
                MessageBox.Show("Lütfen emailinizi uygun şekilde giriniz.");
            }
            else
            {
                kullaniciModel.Eposta=email;
            }

            string sifre = txtSifre.Text;
            if (sifre.IsNullOrEmpty() && !(sifre.Any(char.IsDigit)) && !(sifre.Any(char.IsLower)) && !(sifre.Any(char.IsUpper)) && sifre.Length<=8 && !(sifre.Any(char.IsLetter)))
            {
                MessageBox.Show("Şifreniz en az 8 karakter içermelidir, en az bir büyük harf,bir küçük harf, bir sayı kullanmalısınız.");
            }
            else
            {
                kullaniciModel.Sifre = Metodlar.Sha256Hash(sifre);
            }
            //yıl-----------

            string secilenYilString = cbYıl.SelectedItem.ToString();

            int secilenYil = int.Parse(secilenYilString);

            string secilenAyString = cbAy.SelectedItem.ToString();

            int secilenAy = int.Parse(secilenAyString);

            string secilenGunString = cbGün.SelectedItem.ToString();

            int secilenGun = int.Parse(secilenGunString);



            DateTime secilenTarih = new DateTime(secilenYil, secilenAy, secilenGun);

            kullaniciDetayModel.DogumTarihi = secilenTarih;

            // boy---------
              string boyString = txtBoy.Text;

            if (double.TryParse(boyString, out double boy))
            {
                if(boy < 240 & boy>140)
                {
                    kullaniciDetayModel.Boy=boy;
                }
                else
                {
                    MessageBox.Show("Boy aralıkları dışında giriş yaptınız.");
                }
                
            }
            else
            {
                MessageBox.Show("Geçersiz boy formatı!");
            }

            // kilo-------------
            string kiloString = txtKilo.Text;
            if (double.TryParse(kiloString, out double kilo))
            {
                if (kilo < 240 & kilo > 40)
                {
                    kullaniciDetayModel.Kilo = kilo;
                }
                else
                {
                    MessageBox.Show("Kilo aralıkları dışında giriş yaptınız.");
                }

            }
            else
            {
                MessageBox.Show("Geçersiz kilo formatı!");
            }

            KullaniciDetayManager kullaniciDetayManager = new KullaniciDetayManager();

            KullaniciManager kullaniciManager = new KullaniciManager();

            kullaniciDetayManager.Add(kullaniciDetayModel);

          
            kullaniciModel.KullaniciDetayId = kullaniciDetayModel.Id;
          

            
            kullaniciManager.Add(kullaniciModel);
                

        }

    }   
}
