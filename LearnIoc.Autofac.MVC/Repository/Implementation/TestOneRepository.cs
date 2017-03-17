using LearnIoc.Autofac.MVC.Repository.Interfaces;
using LearnIoc.Autofac.MVC.Models;

namespace LearnIoc.Autofac.MVC.Repository.Implementation
{
    public class TestOneRepository : ITestOneRepository
    {
        private DBContext _context;

        public TestOneRepository(DBContext context)
        {
            _context = context;
        }

        public string GetGuid()
        {
            return _context.Guid.ToString();
        }
    }
}
