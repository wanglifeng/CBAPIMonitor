using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace CBAPITimeTest.TestSections
{
    public class ParseResume : ITestSection
    {

        public IRestRequest Request
        {
            get
            {
                var request = new RestRequest();
                request.Resource = "v2/resume/upload";
                request.Method = RestSharp.Method.POST;
                request.RequestFormat = RestSharp.DataFormat.Xml;

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("<Request>");
                sb.AppendLine("<DeveloperKey></DeveloperKey>");
                sb.AppendLine("<Test>true</Test>");
                sb.AppendLine("<FileName>demoresume.txt</FileName>");
                sb.AppendLine("<FileBytes>" + System.IO.File.ReadAllText(HttpContext.Current.Server.MapPath("~/attachments/demoresume.txt")) + "</FileBytes>");
                sb.AppendLine("</Request>");
                request.AddBody(sb.ToString());
                return request;
            }
        }

        public bool RequireHTTPS
        {
            get
            {
                return true;
            }
        }
    }
}