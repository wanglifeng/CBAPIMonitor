using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using RestSharp;

namespace CBAPITimeTest.TestSections
{
    class JobDetail : TestSectionBase
    {

        protected override void BuildRequest(RestSharp.IRestRequest request)
        {
            request.Resource = "v1/job";
            request.Method = Method.GET;
            request.AddParameter("developerkey", "WD1B37Z74Y7BL07ZM89B", ParameterType.GetOrPost);
            request.AddParameter("DID", "J3F5PF74M0WN18N4FB5", ParameterType.GetOrPost);
        }
    }
}