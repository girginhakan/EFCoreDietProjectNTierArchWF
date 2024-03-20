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
        public int Id { get; set; }
        public string YemekAdi { get; set; }
        public string Aciklama { get; set; }
        public double Kalori { get; set; }
        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }
        List<KullaniciOgunYemekPorsiyon> KullaniciOgunYemekPorsiyonlar { get; set; }    

    }
}
