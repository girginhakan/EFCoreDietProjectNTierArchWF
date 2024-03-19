using DietProject.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.DAL.Entities
{
    public class KullaniciDetay : Entity
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public double Boy { get; set; }
        public double Kilo { get; set; }
        public Kullanici kullanici { get; set; }
    }
}
