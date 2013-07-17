using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CBAPITimeTest.TestSections
{
    class JobSearch : TestSectionBase
    {

        protected override void BuildRequest(IRestRequest request)
        {
            request.Resource = "v1/jobsearch";
            request.Method = Method.GET;
            request.AddParameter("developerkey", "WD1B37Z74Y7BL07ZM89B", ParameterType.GetOrPost);
            request.AddParameter("countrycode", "CN", ParameterType.GetOrPost);
        }
    }
}