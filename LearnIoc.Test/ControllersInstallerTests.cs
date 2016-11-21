using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Castle.Windsor;

namespace LearnIoc.Test
{
    [TestClass]
    public class ControllersInstallerTests
    {
        private IWindsorContainer containerWithControllers;

        public ControllersInstallerTests()
        {
            containerWithControllers=new WindsorContainer().Install(new )

        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
