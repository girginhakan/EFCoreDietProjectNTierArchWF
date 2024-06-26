﻿using DietProject.DAL.Enums;
using DietProject.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.DAL.Entities
{
    public class Kullanici : Entity
    {

        
        public string Eposta { get; set; } 

        public string Sifre { get; set; }
        public int KullaniciDetayId { get; set; }


        public KullaniciDetay KullaniciDetay { get; set; }


        public UserStatus UserStatus { get; set; } = UserStatus.NormalKullanici;


        public List<KullaniciOgunYemekPorsiyon> KullaniciOgunYemekPorsiyonlar { get; set; }

    }
}
