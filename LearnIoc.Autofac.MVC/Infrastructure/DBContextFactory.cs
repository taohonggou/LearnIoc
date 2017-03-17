using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LearnIoc.Autofac.MVC.Models;

namespace LearnIoc.Autofac.MVC.Infrastructure
{
    public static class DBContextFactory
    {
        public static DBContext GetDBContext()
        {
            var context = HttpContext.Current.Items["context"] as DBContext;
            if (context == null)
            {
                context = new EntityContext();
                HttpContext.Current.Items["context"] = context;
            }
            return context;
        }
    }
}