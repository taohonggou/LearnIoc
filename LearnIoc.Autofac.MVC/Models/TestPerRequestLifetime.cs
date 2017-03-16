using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearnIoc.Autofac.MVC.Models
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

    public class Test
    {
        public  TestFather TestFather;

        public Test (TestFather testFather)
        {
            TestFather = testFather;
        }
    }
}