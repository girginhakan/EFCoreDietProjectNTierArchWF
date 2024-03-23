﻿using AutoMapper;
using DietProject.BLL.Models;
using DietProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.BLL.MappingProfile
{
    public class KullaniciMapProfile : Profile
    {
        public KullaniciMapProfile()
        {
            CreateMap<KullaniciOgunYemekPorsiyonModel, KullaniciOgunYemekPorsiyon>().
                ForMember(y => y.Kullanici, k => k.MapFrom(src => src.Kullanici)).ReverseMap();
        }
    }
}
