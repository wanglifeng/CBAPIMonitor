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
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    var response = client.Execute((section as TestSectionBase).Request);
                    sw.Stop();
                    System.IO.File.AppendAllText(Server.MapPath("~/logs/logs.txt"), String.Format("Class:{0}\tTime:{1}\tDate:{2}{3}", testSection, sw.ElapsedMilliseconds, DateTime.Now, System.Environment.NewLine));
                    if (Request.QueryString["debug"] == "true")
                    {
                        return new ContentResult() { Content = response.Content };
                    }
                    else
                    {
                        return new ContentResult() { Content = "Call API successfully" };
                    }
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
