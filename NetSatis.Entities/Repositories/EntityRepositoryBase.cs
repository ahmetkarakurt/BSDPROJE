﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation;
using NetSatis.Entities.Interfaces;
using NetSatis.Entities.Tools;
using NetSatis.Entities.Tools.LoadingTool;

namespace NetSatis.Entities.Repositories
{
    public class EntityRepositoryBase<TContext, TEntity, TValidator> : IEntityRepository<TContext, TEntity>
         where TContext : DbContext, new()
         where TEntity : class, IEntity, new()
         where TValidator : IValidator, new()

    {
        public List<TEntity> GetAll(TContext context, Expression<Func<TEntity, bool>> filter = null)
        {
     
            return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            
        }
      

        public TEntity GetByFilter(TContext context, Expression<Func<TEntity, bool>> filter)
        {//degisdi

            //    return context.Set<TEntity>().SingleOrDefault(filter);
            return context.Set<TEntity>().FirstOrDefault(filter);
        }

        public List<TEntity> GetSqL<TEntity>(TContext context,string sqL)
        {
            return context.Database.SqlQuery<TEntity>(sqL).ToList();
        }


        public bool AddOrUpdate(TContext context, TEntity entity)
        {


            LoadingTool animasyon = new LoadingTool();
            animasyon.AnimasyonBaslat();
            TValidator validator = new TValidator();

            var validationResult = ValidatorTool.Validate(validator, entity);

            if (validationResult)
            {
                context.Set<TEntity>().AddOrUpdate(entity);
            }
            animasyon.AnimasyonBitir();
            return validationResult;
        }
        public void Delete(TContext context, Expression<Func<TEntity, bool>> filter)
        {
            context.Set<TEntity>().RemoveRange(context.Set<TEntity>().Where(filter));
        }

        public void Save(TContext context)
        {
            LoadingTool animasyon = new LoadingTool();
            animasyon.AnimasyonBaslat();
            context.SaveChanges();
            animasyon.AnimasyonBitir();
        }

        public string OzelEkleGncle(TContext context, Expression<Func<TEntity, bool>> filter, TEntity entity)
        {
        
            var guncellenicek_makale = context.Set<TEntity>().FirstOrDefault(filter);

            if (guncellenicek_makale!=null)
            {
                context.Set<TEntity>().AddOrUpdate(entity);
               
               // context.Entry(entity).State
                return "var";
            }
            else
            {
                context.Set<TEntity>().AddOrUpdate(entity);
                //  context.Set<TEntity>().Add(entity);
                return "yok";
            }
        


        }


    }
}
