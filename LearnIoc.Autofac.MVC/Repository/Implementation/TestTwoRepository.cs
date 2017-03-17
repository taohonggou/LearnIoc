using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LearnIoc.Autofac.MVC.Repository.Interfaces;
using LearnIoc.Autofac.MVC.Models;
using LearnIoc.Autofac.MVC.Infrastructure;
using System.Threading.Tasks;

namespace LearnIoc.Autofac.MVC.Repository.Implementation
{
    public class TestTwoRepository : ITestTwoRepository
    {
        private DBContext _context;

        public TestTwoRepository(DBContext context)
        {
            _context = context;
        }

        //public TestTwoRepository()
        //{
        //    _context = DBContextFactory.GetDBContext();
        //}

        public string GetGuid()
        {
            Task<string> task = new Task<string>(() =>
            {
                return _context.Guid.ToString();
            });

            task.Start();
            return task.Result;
        }

        //public string GetGuid()
        //{
        //    return _context.Guid.ToString();
        //}

        /// <summary>
        /// 会报错
        /// </summary>
        /// <returns></returns>
        public string GetGuidAsync()
        {
            Task<string> task = new Task<string>(() =>
            {
                DBContext context = DBContextFactory.GetDBContext();
                return context.Guid.ToString();
            });

            task.Start();
            return task.Result;

        }
    }
}