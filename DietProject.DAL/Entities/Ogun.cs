using DietProject.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.DAL.Entities
{
    public class Ogun : Entity
    {
        public string OgunAdi { get; set; }
        public string Aciklama { get; set; }
        public List<KullaniciOgunYemekPorsiyon> KullaniciOgunYemekPorsiyonlar { get; set; }

    }
}
