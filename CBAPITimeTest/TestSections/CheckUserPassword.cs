using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;
using CBAPITimeTest.Serializer;

namespace CBAPITimeTest.TestSections
{
    class CheckUserPassword : TestSectionBase
    {
        protected override void BuildRequest(RestSharp.IRestRequest request)
        {
            request.Resource = "v2/user/checkexisting";
            request.XmlSerializer = new NonSerializer();
            request.RequestFormat = DataFormat.Xml;
            request.Method = Method.POST;
            request.AddBody("<Request><DeveloperKey>WD1B37Z74Y7BL07ZM89B</DeveloperKey><Email>tytc011@163.com</Email><Password>tysyjsj1</Password><Test>false</Test></Request>");
            
        }

        public override bool RequireHTTPS { get { return true; } }
    }
}