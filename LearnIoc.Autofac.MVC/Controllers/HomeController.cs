using LearnIoc.Autofac.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearnIoc.Autofac.MVC.Repository.Interfaces;

namespace LearnIoc.Autofac.MVC.Controllers
{
    public class HomeController : Controller
    {
        private ITestTwoRepository _testTwoRepository;
        private ITestOneRepository _testOneRepository;

        public HomeController(ITestOneRepository testOneRepository, ITestTwoRepository testTwoRepository)
        {
            _testOneRepository = testOneRepository;
            _testTwoRepository = testTwoRepository;
        }

        public ActionResult Index()
        {
            string one = _testOneRepository.GetGuid();
            string two = _testTwoRepository.GetGuid();

            return Content($"One={one}  Two={two} \r\n one=two:{one==two}");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}