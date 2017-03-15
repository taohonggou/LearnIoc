using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using LearnLoc.CastleWindsor.Interfaces;
namespace LearnLoc.CastleWindsor
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();
            IWindsorContainer IocContainer = container.Install();

            IocContainer.Register(
                Classes.FromAssembly(Assembly.GetExecutingAssembly())
                    .IncludeNonPublicTypes()
                    .BasedOn<IDependency>()
                    .WithService.Self()
                    .WithService.DefaultInterfaces()
                    .LifestyleTransient()
                );

            IUserServices userService = container.Resolve<IUserServices>();
            Console.WriteLine(userService.GetUserName("123"));

        }
    }
}
