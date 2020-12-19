using KluCareer.DataAccessLayer.Abstract;
using KluCareer.DataAccessLayer.Concrate.Contexts;
using KluCareer.DataAccessLayer.Concrate.EntityFramework.Repository;
using KluCareer.Entities.Concrate.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KluCareer.DataAccessLayer.Concrate.EntityFramework
{
    public class EfUserDal:EfRepository<User,KluCareerContext>,IUserDal
    {
        //diğer operasyonlar buradan yönetilir...
        //ek olanlar buradan gelir....
    }
}
