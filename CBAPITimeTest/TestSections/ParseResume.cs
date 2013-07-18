using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;
using CBAPITimeTest.Serializer;

namespace CBAPITimeTest.TestSections
{
    class ParseResume : TestSectionBase
    {
        protected override void BuildRequest(IRestRequest request)
        {
            request.XmlSerializer = new NonSerializer();
            request.Method = Method.POST;
            request.Resource = "v2/resume/parse";
            request.RequestFormat = DataFormat.Xml;
            var str = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes("helloworld".ToCharArray()));
            request.AddBody("<Request><DeveloperKey>WD1B37Z74Y7BL07ZM89B</DeveloperKey><Test>true</Test><FileName>a.txt</FileName><FileBytes>" + str + "</FileBytes></Request>");
        }

        public override bool RequireHTTPS { get { return true; } }
    }
}