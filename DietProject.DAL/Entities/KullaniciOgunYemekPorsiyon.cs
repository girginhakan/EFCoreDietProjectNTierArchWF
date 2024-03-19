using DietProject.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.DAL.Entities
{
    public class KullaniciOgunYemekPorsiyon:Entity
    {
        public int YemekId { get; set; }
        public int KullaniciId { get; set; }
        public int OgunId { get; set; }
        public int PorsiyonId { get; set; }

        public Kullanici Kullanici { get; set; }
        public Ogun Ogun { get; set; }
        public Porsiyon Porsiyon { get; set; }
        public Yemek Yemek { get; set; }
    }
}
