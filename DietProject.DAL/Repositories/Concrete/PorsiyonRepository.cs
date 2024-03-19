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
    public class PorsiyonRepository : Repository<Porsiyon>
    {
        public PorsiyonRepository(DietProjectDbContext db) : base(db)
        {
        }
    }
}
