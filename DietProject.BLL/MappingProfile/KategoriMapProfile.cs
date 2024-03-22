using AutoMapper;
using DietProject.BLL.Models;
using DietProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.BLL.MappingProfile
{
    public class KategoriMapProfile :Profile
    {
        public KategoriMapProfile()
        {
            CreateMap<YemekModel, Yemek>().
          ForMember(y => y.Kategori, b => b.MapFrom(src => src.Kategori)).ReverseMap();

        }
    }
}
