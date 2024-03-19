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
        public int Id { get; set; }
        public string OgunAdi { get; set; }
        public string Aciklama { get; set; }
        List<KullaniciOgunYemekPorsiyon> KullaniciOgunYemekPorsiyonlar { get; set; }

    }
}
