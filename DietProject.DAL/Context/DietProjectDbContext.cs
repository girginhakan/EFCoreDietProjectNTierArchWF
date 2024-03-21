using DietProject.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.DAL.Context
{
    public class DietProjectDbContext:DbContext
    {
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set;}
        public DbSet<KullaniciDetay> KullaniciDetaylar { get; set; }
        public DbSet<Ogun> Ogunler { get; set; }
        public DbSet<Porsiyon> Porsiyonlar { get; set; }
        public DbSet<Yemek> Yemekler { get; set; }
        public DbSet<KullaniciOgunYemekPorsiyon> KullaniciOgunYemekPorsiyonlar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-MCJPB0C;Initial Catalog=DietProjectDb;Integrated Security=true;Encrypt=False");
        }
    }
}
