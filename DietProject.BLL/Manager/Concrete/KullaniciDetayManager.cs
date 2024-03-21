﻿using DietProject.BLL.Manager.Abstract;
using DietProject.BLL.Models;
using DietProject.DAL.Context;
using DietProject.DAL.Entities;
using DietProject.DAL.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.BLL.Manager.Concrete
{
    public class KullaniciDetayManager : Manager<KategoriModel, Kategori>
    {
        public KullaniciDetayManager()
        {
            _repository = new KategoriRepository(new DietProjectDbContext());
        }
    }
}