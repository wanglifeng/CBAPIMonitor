using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestSharp;
using System.Diagnostics;
using CBAPITimeTest.TestSections;
using System.Reflection;

namespace CBAPITimeTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return new ContentResult() { Content = "Hello World" };
        }

        public ActionResult Monitor(String testSection)
        {
            var client = new RestClient();
            client.BaseUrl = "http://api.careerbuilder.com";


            ITestSection section = null;

            try
            {
                Assembly asm = Assembly.GetExecutingAssembly();
                section = asm.CreateInstance("CBAPITimeTest.TestSections." + testSection, true) as ITestSection;                
                var response = client.Execute(section.Request);

                return new ContentResult() { Content = "Monitor" };
            }
            catch (Exception e)
            {
                return new ContentResult() { Content = String.Format("CLASS: {0} NOT FOUND", testSection) };
            }
        }

    }
}
