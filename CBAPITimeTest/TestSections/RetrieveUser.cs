using CBAPITimeTest.Serializer;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CBAPITimeTest.TestSections
{
    class RetrieveUser : TestSectionBase
    {
        protected override void BuildRequest(RestSharp.IRestRequest request)
        {
            request.Resource = "v2/user/retrieve";
            request.XmlSerializer = new NonSerializer();
            request.RequestFormat = DataFormat.Xml;
            request.Method = Method.POST;
            request.AddBody("<Request><DeveloperKey>WD1B37Z74Y7BL07ZM89B </DeveloperKey><Password>tysyjsj1</Password><Test>false</Test><ExternalID>XRHS24M726DYPBFJDY7D </ExternalID></Request>");
            
        }

        public override bool RequireHTTPS { get { return true; } }
    }
}