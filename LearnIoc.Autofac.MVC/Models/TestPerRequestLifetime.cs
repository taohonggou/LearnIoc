using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearnIoc.Autofac.MVC.Models
{
    public abstract class DBContext
    {
        public abstract Guid Guid { get; }

        public abstract string GetGuid();
    }

    public class EntityContext : DBContext
    {
        public override Guid Guid { get; }

        public EntityContext()
        {
            Guid = Guid.NewGuid();
        }

        public override string GetGuid()
        {
            return Guid.ToString();
        }
    }
}