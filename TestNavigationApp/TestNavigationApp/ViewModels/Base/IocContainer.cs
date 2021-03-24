using System.Threading;
using Autofac;
using TestNavigationApp.Services;

namespace TestNavigationApp.ViewModels.Base
{
    public static class IocContainer
    {
        public static IContainer Container { get; private set; }

        public static void SetupContainer()
        {
            var builder = new ContainerBuilder();
 
            // Register Services
            builder.RegisterType<NavigationService>().As<INavigationService>().SingleInstance();
            
            // Register ViewModels
            builder.RegisterType<FirstViewModel>();
            builder.RegisterType<SecondViewModel>();
            builder.RegisterType<ThirdViewModel>();
            builder.RegisterType<FourthViewModel>();
            builder.RegisterType<StartViewModel>();
            builder.RegisterType<ModalViewModel>();
 
            Container = builder.Build();
        }
        
    }
}
