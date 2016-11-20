using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnIoc.CastleWindsor.ClassLibrary
{
    class DependencyTwo : IDependencyTwo
    {
        public object SomeOtherObject { get; set; }
    }
}
