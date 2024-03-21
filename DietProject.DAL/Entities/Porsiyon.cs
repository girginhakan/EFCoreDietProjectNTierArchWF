using DietProject.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.DAL.Entities
{
    public class Porsiyon: Entity
    {
        public string PorsiyonBirim { get; set; }
        public double PorsiyonMiktari { get; set; }
        List<KullaniciOgunYemekPorsiyon> KullaniciOgunYemekPorsiyonlar { get; set; }

    }
}
