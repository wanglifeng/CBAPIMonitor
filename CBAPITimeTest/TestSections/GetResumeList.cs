using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;

namespace CBAPITimeTest.TestSections
{
    class GetResumeList : TestSectionBase
    {
        protected override void BuildRequest(RestSharp.IRestRequest request)
        {
            request.Resource = "v1/resume/ownall?developerkey=WD1B37Z74Y7BL07ZM89B&externaluserid=XRHS24M726DYPBFJDY7D";
            request.Method = RestSharp.Method.GET;
        }

        public override bool RequireHTTPS { get { return true; } }
    }
}