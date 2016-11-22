using System;
using Castle.Windsor;
using LearnIoc.CastleWindsor.MVC2013.Installers;
using LearnIoc.CastleWindsor.MVC2013.Controllers;
using Xunit;
using Castle.MicroKernel;
using System.Web.Mvc;
using System.Linq;
using Castle.Core.Internal;

namespace LearnIoc.Test
{

    public class ControllersInstallerTests
    {
        private IWindsorContainer containerWithControllers;

        public ControllersInstallerTests()
        {
            containerWithControllers = new WindsorContainer().Install(new ControllersInstaller());
        }

        [Fact]
        public void AllControllerImplementIController()
        {
            var allHandlers = GetAllHandlers(containerWithControllers);
            var controllerHandlers = GetHandlersFor(typeof(IController), containerWithControllers);

            Assert.NotEmpty(allHandlers);
            Assert.Equal(allHandlers, controllerHandlers);
        }

        [Fact]
        public void AllControllerAreRegisted()
        {
            var allControllers = GetPublicClassFromApplicationAssembly(c => c.Is<IController>());
            var registerController = GetImplementationTypesFor(typeof(IController), containerWithControllers);
            Assert.Equal(allControllers, registerController);
        }

        private IHandler[] GetAllHandlers(IWindsorContainer container)
        {
            return GetHandlersFor(typeof(object), container);
        }

        private IHandler[] GetHandlersFor(Type type, IWindsorContainer container)
        {
            return container.Kernel.GetAssignableHandlers(type);
        }

        private Type[] GetImplementationTypesFor(Type type, IWindsorContainer container)
        {
            return GetHandlersFor(type, container)
                      .Select(h => h.ComponentModel.Implementation)
                      .OrderBy(t => t.Name)
                      .ToArray();
        }

        private Type[] GetPublicClassFromApplicationAssembly(Predicate<Type> where)
        {
            return typeof(HomeController).Assembly.GetExportedTypes()
                .Where(t => t.IsClass)
                .Where(t => t.IsAbstract == false)
                .Where(where.Invoke)
                .OrderBy(t => t.Name)
                .ToArray();
        }
    }
}
