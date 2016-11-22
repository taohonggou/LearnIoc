using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Castle.Windsor;
using LearnIoc.CastleWindsor.MVC2013.Installers;
using Castle.MicroKernel;
using System.Web.Mvc;
namespace LearnIoc.Test
{
    [TestClass]
    public class LearnTest
    {
        private IWindsorContainer containerWithControllers;
       public LearnTest()
        {
            containerWithControllers = new WindsorContainer().Install(new ControllersInstaller());
        }


       [TestMethod]
       public void AllControllerImplementIController()
       {
           var allHandlers = GetAllHandlers(containerWithControllers);
           var controllerHandlers = GetHandlersFor(typeof(IController), containerWithControllers);

           Assert.IsNotNull(allHandlers);
           //Assert.NotEmpty(allHandlers);
           Assert.AreEqual(allHandlers, controllerHandlers);
       }

       private IHandler[] GetAllHandlers(IWindsorContainer container)
       {
           return GetHandlersFor(typeof(object), container);
       }

       private IHandler[] GetHandlersFor(Type type, IWindsorContainer container)
       {
           return container.Kernel.GetAssignableHandlers(type);
       }
    }
}
