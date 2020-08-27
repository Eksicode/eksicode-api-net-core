using System;
using Autofac;
using Autofac.Extras.DynamicProxy;
using EksiCodeBackend.Business.Abstract;
using EksiCodeBackend.Business.Concrete;
using EksiCodeBackend.Core.Utilities.Interceptors;
using EksiCodeBackend.DataAccess.Abstract;
using EksiCodeBackend.DataAccess.Concrete;

namespace EksiCodeBackend.Business.DependencyResolvers.AutoFac
{
    public class BusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<UserDal>().As<IUserDal>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new Castle.DynamicProxy.ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
