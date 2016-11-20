using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnIoc.CastleWindsor.ClassLibrary
{
    class DependencyOne : IDependencyOne
    {
        public object SomeObject { get; set; }
    }
}
