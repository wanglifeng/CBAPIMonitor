using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CBAPITimeTest.TestSections
{
    class RetrieveResume : TestSectionBase
    {
        protected override void BuildRequest(RestSharp.IRestRequest request)
        {
            request.Resource = "v2/resume/retrieve?developerkey=WD1B37Z74Y7BL07ZM89B&externaluserid=XRHS24M726DYPBFJDY7D&externalid=XRHL00T6LRHSH3VCY5BD";
            request.Method = RestSharp.Method.GET;
        }

        public override bool RequireHTTPS { get { return true; } }
    }
}