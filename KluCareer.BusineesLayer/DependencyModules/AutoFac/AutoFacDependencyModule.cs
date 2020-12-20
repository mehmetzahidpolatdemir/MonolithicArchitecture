using Autofac;
using KluCareer.BusineesLayer.Abstract;
using KluCareer.BusineesLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace KluCareer.BusineesLayer.DependencyModules.Autofac
{
    public class AutofacDependencyModule:Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserManager>().As<IUserManager>();
        }

    }
}
