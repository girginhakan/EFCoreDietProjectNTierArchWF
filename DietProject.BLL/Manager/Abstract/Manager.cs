using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using DietProject.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.BLL.Manager.Abstract
{

    public abstract class Manager<TModel,TEntity, TMapperProfile> : IManager<TModel> //, TMapperProfile>
        where TModel : class 
        where TEntity : class
        where TMapperProfile : Profile, new()
    {
        private IMapper _mapper;
        protected IRepository< TEntity> _repository;
        protected MapperConfiguration _config;

        public Manager()
        {
           

            _config = new MapperConfiguration(cfg =>
            {
                cfg.AddExpressionMapping().CreateMap<TModel, TEntity>().ReverseMap();//sad
                cfg.AddProfile<TMapperProfile>();

            });

            _mapper = new Mapper(_config);
        }

        public void Add(TModel model)
        {
            

            TEntity cevirilenEntity = _mapper.Map<TEntity>(model);
            _repository.Add(cevirilenEntity);
        }

        public void Delete(TModel model)
        {
            TEntity convertedEntity = _mapper.Map<TEntity>(model);
            _repository.Delete(convertedEntity);
        }

        public List<TModel> GetAll()
        {
            List<TEntity> EntitiesFromDb = _repository.GetAll().ToList();
                
            List<TModel> models = new List<TModel>();

            foreach (TEntity entity in EntitiesFromDb)
            {
                TModel model = _mapper.Map<TModel>(entity);
                models.Add(model);
            }
            return models;
        }

        public List<TModel> GetAllWithIncludes()
        {
            List<TEntity> entities = _repository.GetAllWithIncludes().ToList();

            List<TModel> models = _mapper.Map<List<TModel>>(entities);

            return models;
        }

        public List<TModel> GetAllWithIncludes(params string[] navigationProperties)
        {
            //önce repository'deki GetAllWithIncludes metodunu çağır
            //Ama çağırınca TEntity tipinde gelir tabi.
            //Bİz de bunu yine yukarıda yaptığımız gibi bu listeyi TModel listesine döndüreceğiz.

            List<TEntity> entities = _repository.GetAllWithIncludes(navigationProperties).ToList();

            List<TModel> models = _mapper.Map<List<TModel>>(entities);

            return models;
        }


        public TModel GetById(int id)
        {
            TEntity entity = _repository.GetById(id);

            TModel model = _mapper.Map<TModel>(entity);

            return model;
        }

        public void Remove(TModel model)
        {
            TEntity cevirilenEntity = _mapper.Map<TEntity>(model);
            _repository.Remove(cevirilenEntity);
        }

        public List<TModel> Search(Expression<Func<TModel, bool>> predicate)
        {
            Expression<Func<TEntity, bool>> predicateEntities = _mapper.Map<Expression<Func<TEntity, bool>>>(predicate);

            List<TEntity> entities = _repository.Search(predicateEntities).ToList();

            List<TModel> models = new List<TModel>();

            foreach (TEntity entity in entities)
            {
                TModel model = _mapper.Map<TModel>(entity);
                models.Add(model);
            }
            return models;
        }

        public void Update(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);
            _repository.Update(entity);
        }

        
    }
}
