using DietProject.DAL.Enums;
using DietProject.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.DAL.Entities
{
    public class Kullanici : Entity
    {
        public int Id { get; set; }
        public string Eposta { get; set; }
        public string Sifre { get; set; }
        public int KullaniciDetayId { get; set; }

        KullaniciDetay KullaniciDetay { get; set; }
        public UserStatus UserStatus { get; set; } = UserStatus.NormalKullanici;


        List<KullaniciOgunYemekPorsiyon> KullaniciOgunYemekPorsiyonlar { get; set; }

    }
}
