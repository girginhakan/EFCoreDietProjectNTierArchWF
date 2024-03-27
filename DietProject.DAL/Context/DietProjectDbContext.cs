using DietProject.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;

namespace DietProject.DAL.Context
{
    public class DietProjectDbContext:DbContext
    {
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set;}
        public DbSet<Ogun> Ogunler { get; set; }
        public DbSet<Porsiyon> Porsiyonlar { get; set; }
        public DbSet<Yemek> Yemekler { get; set; }
        public DbSet<KullaniciOgunYemekPorsiyon> KullaniciOgunYemekPorsiyonlar { get; set; }


        public static string Sha256Hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=HAKANPC;Initial Catalog=DietProjectDb;Integrated Security=true;Encrypt=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Kullanici>().HasData(
                new Kullanici()
                {
                    Id=16,
                    Adi = "Admin Adı",
                    Soyadi = "Admin Soyadı",
                    Eposta = "admin",
                    Sifre = Sha256Hash("1234"),
                    Boy = 175,
                    Kilo = 75,
                    UserStatus = Enums.UserStatus.Admin,
                    CreatedDate = DateTime.Now,
                    
                    
                }
                );
        }
    }
}
