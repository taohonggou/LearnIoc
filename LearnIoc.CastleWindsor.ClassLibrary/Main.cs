using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnIoc.CastleWindsor.ClassLibrary
{
    public class Main
    {
        private IDependencyOne dependencyOne;
        private IDependencyTwo dependencyTwo;

        public Main(IDependencyOne dependencyOne,IDependencyTwo dependencyTwo)
        {
            this.dependencyOne = dependencyOne;
            this.dependencyTwo = dependencyTwo;
        }

        public void DoSomeThing()
        {
            dependencyOne.SomeObject = "Hello World";
            dependencyTwo.SomeOtherObject="Hello Mars";
        }
    }
}
