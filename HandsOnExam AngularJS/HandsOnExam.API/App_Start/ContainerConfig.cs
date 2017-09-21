using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using HandsOnExam.Business.Managers;
using HandsOnExam.Data.Repositories;

namespace HandsOnExam
{
    public class ContainerConfig
    {
        public static void Configure()
        {
            // var builder = new ContainerBuilder();

            //var x = new ApplicationDbContext();
            //builder.Register<ApplicationDbContext>(c => x);
            //builder.Register<UserStore<ApplicationUser>>(c => new UserStore<ApplicationUser>(x)).AsImplementedInterfaces();
            //builder.Register<IdentityFactoryOptions<IdentityConfig.ApplicationUserManager>>(c => new IdentityFactoryOptions<IdentityConfig.ApplicationUserManager>()
            //{
            //    DataProtectionProvider = new Microsoft.Owin.Security.DataProtection.DpapiDataProtectionProvider("ApplicationName")
            //});
            //builder.RegisterType<IdentityConfig.ApplicationUserManager>();
            //--
            //builder.RegisterType<NootBaseContext>().AsSelf().SingleInstance();
            //builder.Register<IdentityFactoryOptions<IdentityConfig.ApplicationUserManager>>(c => new IdentityFactoryOptions<IdentityConfig.ApplicationUserManager>() { DataProtectionProvider = new DpapiDataProtectionProvider("your app name") });
            //builder.RegisterType<IdentityConfig.ApplicationUserManager>().AsSelf().SingleInstance();
            //// to resolve applicationUserManager
            //builder.Register(c => new ApplicationOAuthProvider("self",c.Resolve<IAuthManager>())).AsImplementedInterfaces().SingleInstance();
            //builder.Register(c => new UserStore<ApplicationUser>(c.Resolve<NootBaseContext>())).AsImplementedInterfaces().SingleInstance();
            //builder.Register(c => HttpContext.Current.GetOwinContext().Authentication).As<IAuthenticationManager>();
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(typeof(ContainerConfig).Assembly).InstancePerLifetimeScope();
            //This registers 'A'
            builder.RegisterAssemblyModules(typeof(ContainerConfig).Assembly);

            var container = builder.Build();

            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        //This is 'A'
        public class RegisterServices : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                //___Managers____
                builder.RegisterType<CustomerManager>().As<ICustomerManager>();

                //____Repositories____
                builder.RegisterType<CustomerRepository>().As<ICustomerRepository>();
            }
        }
    }
}