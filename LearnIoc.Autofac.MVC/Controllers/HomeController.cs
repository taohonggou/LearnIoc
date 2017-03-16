using LearnIoc.Autofac.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearnIoc.Autofac.MVC.Controllers
{
    public class HomeController : Controller
    {
        private TestFather _testFather;
        private Test _test;

        public HomeController(TestFather testFather/*, Test test*/)
        {
            _testFather = testFather;
            //_test = test;
        }

        public ActionResult Index()
        {
            string _testGuid = _test.TestFather.Guid.ToString();
            string _testFatherGuid = _testFather.Guid.ToString();


            return Content($"_testGuid={_testGuid}||_testFatherGuid={_testFatherGuid},\n 结果:{_testGuid== _testFatherGuid}");
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