using DietProject.DAL.Context;
using DietProject.DAL.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.DAL.Repositories.Abstract
{
    public abstract class Repository<T> : IRepository<T> where T : Entity, new()
    {
        private readonly DietProjectDbContext _db;
        private DbSet<T> entities;

        public Repository(DietProjectDbContext db)
        {
            _db = db;
            entities = _db.Set<T>();
        }
        public void Add(T entity)
        {
            entity.EntityStatus = EntityStatus.Created;
            entity.CreatedDate = DateTime.Now;
            entities.Add(entity);
            _db.SaveChanges();

        }

        public void Delete(T entity)
        {
            entity.DeletedDate = DateTime.Now;
            entity.EntityStatus= EntityStatus.Deleted;
            Update(entity);
        }

        public void Remove(T entity)
        {
            entities.Remove(entity);
            //_db.Entry(entity).State = EntityState.Detached;
            _db.SaveChanges();

        }
        public IQueryable<T> GetAll()
        {
            return entities.Where(e=>e.EntityStatus != EntityStatus.Deleted).AsNoTracking();
        }

        public T GetById(int id)
        {
            return entities.AsNoTracking().FirstOrDefault(e => e.Id == id && e.EntityStatus != EntityStatus.Deleted);
        }

        

        public IQueryable<T> Search(Expression<Func<T, bool>> predicate)
        {
            var all= entities.AsNoTracking().Where(E=>E.EntityStatus != EntityStatus.Deleted);
            return all.Where(predicate);
        }

        public void Update(T entity)
        {
            entity.UpdatedDate = DateTime.Now;
            entity.CreatedDate= GetById(entity.Id).CreatedDate;
            if (entity.EntityStatus!=EntityStatus.Deleted)
                entity.EntityStatus = EntityStatus.Updated;


            //_db.Entry(entity).State = EntityState.Modified;
            //var x = _db.ChangeTracker.Entries();
            //if (!x.Any(e => e.Entity.GetType() == entity.GetType()))
            //{
               
            //}
                entities.Update(entity);
            _db.SaveChanges();
           
            
        }

        public IQueryable<T> GetAllWithIncludes()
        {
            IQueryable<T> query =_db.Set<T>().AsNoTracking();
            T instance = new T();

            Type type = instance.GetType();

            PropertyInfo[] properties = type.GetProperties();

            foreach (PropertyInfo propInfo in properties.Where(pl => pl.PropertyType.GetInterfaces().Where(i => i.Name == "IEntity").Any()).ToList())
            {
                query = query.Include(propInfo.Name);
            }

            return query;

        }
        public IQueryable<T> GetAllWithIncludes(params string[] navigationProperties)
        {
            //burada navigation prop.ları include edeceğiz.

            IQueryable<T> query = _db.Set<T>();

            foreach (var navigationProperty in navigationProperties)
            {
                query = query.Include(navigationProperty);
            }

            return query;
        }
    }
}
