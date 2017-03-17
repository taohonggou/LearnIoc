using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LearnIoc.Autofac.MVC.Repository.Interfaces;
using LearnIoc.Autofac.MVC.Models;

namespace LearnIoc.Autofac.MVC.Repository.Implementation
{
    public class TestTwoRepository : ITestTwoRepository
    {
        private DBContext _context;

        public TestTwoRepository(DBContext context)
        {
            _context = context;
        }

        public string GetGuid()
        {
            return _context.Guid.ToString();
        }
    }
}