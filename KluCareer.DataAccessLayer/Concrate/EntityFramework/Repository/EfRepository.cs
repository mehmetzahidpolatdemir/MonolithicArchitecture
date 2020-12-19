using KluCareer.DataAccessLayer.Abstract.Repository;
using KluCareer.DataAccessLayer.UnitOfWork;
using KluCareer.Entities.Abstract;
using KluCareer.Entities.Concrate.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;

namespace KluCareer.DataAccessLayer.Concrate.EntityFramework.Repository
{
    public class EfRepository<TEntity, TContext> : IRepository<TEntity>,IUnitOfWork
        where TEntity:BaseEntity
        where TContext : DbContext, new()
    {
        TContext context;
        IDbContextTransaction _transaction = null;

        public EfRepository()
        {
            _transaction = context.Database.BeginTransaction();
            context = new TContext();
        }

        public bool Add(TEntity entity)
        {

            DateTime now = DateTime.Now;
            entity.CreatedDate = now;
            entity.ModifiedDate = now;

            context.Set<TEntity>().Add(entity);
            return Commit();
        }

        public bool Any(Guid Id)
        {
            return context.Set<TEntity>().Any(i => i.Id == Id);
        }

        public int Save() => context.SaveChanges();
        public bool Commit(bool state = true)
        {
            state = Save() > 0 ? true : false;
            if (state)
            {
                _transaction.Commit();
            }
            else
                _transaction.Rollback();
            Dispose();
            return state;
        }

        public void Dispose()
        {
           context.Dispose();
        }

        public TEntity GetById(Guid Id)
        {
            return context.Set<TEntity>().FirstOrDefault(i => i.Id == Id);
        }

        public int GetCount(Guid Id)
        {
            return context.Set<TEntity>().Count(i=>i.Id==Id);
        }

        public List<TEntity> GetList()
        {
           var list =  context.Set<TEntity>().ToList();
            return list;
        }

        public bool Remove(TEntity entity)
        {
           
           context.Set<TEntity>().Remove(entity);
            return Commit();
        }

        public bool Update(TEntity entity)
        {

                DateTime now = DateTime.Now;
            entity.ModifiedDate = now;

            context.Set<TEntity>().Update(entity);

           return Commit();
        }

    }
}
