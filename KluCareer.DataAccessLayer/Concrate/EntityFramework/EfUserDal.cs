using KluCareer.DataAccessLayer.Abstract;
using KluCareer.DataAccessLayer.Concrate.Contexts;
using KluCareer.DataAccessLayer.Concrate.EntityFramework.Repository;
using KluCareer.Entities.Concrate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace KluCareer.DataAccessLayer.Concrate.EntityFramework
{
    public class EfUserDal : EfRepository<User, KluCareerContext>, IUserDal
    {
        //diğer operasyonlar buradan yönetilir...

        public List<User> GetListFullInclude()
        {
            using (var context = new KluCareerContext())
            {
                return context.Users
                    .Include(i => i.Cvs)
                    .Select(i => new User { CreatedDate = i.CreatedDate, ModifiedDate = i.ModifiedDate, UserName = i.UserName, Id = i.Id ,Cvs = i.Cvs})
                    .ToList();
             
            }
        }

        public bool Any(string userName)
        {
            using (var context = new KluCareerContext())
            {
                return context.Users
                   .Any(i => i.UserName == userName);
            }
        }
        //ek olanlar buradan gelir....

    }
}
