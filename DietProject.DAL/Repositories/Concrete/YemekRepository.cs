using DietProject.DAL.Context;
using DietProject.DAL.Entities;
using DietProject.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.DAL.Repositories.Concrete
{
    public class YemekRepository : Repository<Yemek>
    {
        public YemekRepository(DietProjectDbContext db) : base(db)
        {
        }
    }
}
