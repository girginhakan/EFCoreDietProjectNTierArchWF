using DietProject.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.DAL.Entities
{
    public class Kategori : Entity
    {
        public string KategoriAdi { get; set; }
        public string Aciklama { get; set; }
        public List<Yemek> Yemekler { get; set;}


    }
}
