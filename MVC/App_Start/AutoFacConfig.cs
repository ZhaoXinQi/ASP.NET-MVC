using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Autofac.Integration.Mvc;
using System.Reflection;//程序及引用
using System.Web.Mvc;

namespace MVC.App_Start
{
    public class AutoFacConfig
    {
        public static void SautoDepence()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired();
            var idal = Assembly.Load("IDAL");
            var ibll = Assembly.Load("IBLL");
            var dal = Assembly.Load("DAL");
            var bll = Assembly.Load("BLL");
            builder.RegisterAssemblyTypes(idal, dal).Where(
                t => t.Name.EndsWith("DAL")).AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(ibll, bll).Where(
              t => t.Name.EndsWith("BLL")).AsImplementedInterfaces();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}