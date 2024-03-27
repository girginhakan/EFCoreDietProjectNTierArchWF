using DietProject.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.DAL.Entities
{
    public class Yemek:Entity
    {
        public string YemekAdi { get; set; }
        public string Aciklama { get; set; }
        public int Kalori { get; set; }

        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }
        public List<KullaniciOgunYemekPorsiyon> KullaniciOgunYemekPorsiyonlar { get; set; }    

    }
}
