using KluCareer.Entities.Concrate.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KluCareer.DataAccessLayer.Abstract.Repository
{
    //tablolar için crud işlemleri yapılacak.
    // create read update delete 


    public interface IRepository<TEntity>
    {
        TEntity GetById(Guid Id);
        int GetCount(Guid Id);
        bool Any(Guid Id);
        bool Remove(TEntity entity);
        bool Add(TEntity entity);
        bool Update(TEntity entity);
        List<TEntity> GetList();
      // Task <List<TEntity>> GetList();
    }
}
