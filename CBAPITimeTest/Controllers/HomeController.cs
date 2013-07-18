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
            client.BaseUrl = "https://api.careerbuilder.com";

            object section = null;

            try
            {
                Assembly asm = Assembly.GetExecutingAssembly();
                section = asm.CreateInstance("CBAPITimeTest.TestSections." + testSection, true);
            }
            catch 
            {
                return new ContentResult() { Content = String.Format("CLASS: {0} NOT FOUND", testSection) };
            }
            if (section is TestSectionBase)
            {
                if ((section as TestSectionBase).RequireHTTPS) client.BaseUrl = "https://api.careerbuilder.com";
                try
                {
                    var response = client.Execute((section as TestSectionBase).Request);
                    return new ContentResult() { Content = "Call API successfully" };
                }
                catch (Exception e)
                {
                    return new ContentResult() { Content = String.Format("Exception: {0}", e.Message) };
                }
            }
            else
            {
                return new ContentResult() { Content = string.Format("{0} doesn't implement ITestSection!!") };
            }

        }

    }
}
