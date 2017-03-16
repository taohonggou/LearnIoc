using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnIoc.Autofac.implementation
{

    public abstract class TestFather
    {
        public abstract Guid Guid { get; }

        public abstract string GetGuid();

    }

    public class TestSon : TestFather
    {
        public override Guid Guid { get; }

        public TestSon()
        {
            Guid = Guid.NewGuid();
        }

        public override string GetGuid()
        {
            return Guid.ToString();
        }
    }


}
