using Autofac;
using KluCareer.BusineesLayer.Abstract;
using KluCareer.BusineesLayer.Concrate;
using KluCareer.DataAccessLayer.Abstract;
using KluCareer.DataAccessLayer.Concrate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace KluCareer.BusineesLayer.DependencyModules.AutoFac
{
    public class AutoFacDependencyModule:Module
    {
        protected virtual void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserManager>().As<IUserManager>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

        }
    }
}
