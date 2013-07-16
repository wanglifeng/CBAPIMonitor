using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CBAPITimeTest.TestSections
{
    public class JobSearch : ITestSection
    {

        public RestSharp.IRestRequest Request
        {
            get
            {
                var request = new RestRequest();
                request.Resource = "v1/jobsearch";
                request.Method = Method.GET;
                request.AddParameter("developerkey", "WD1B37Z74Y7BL07ZM89B", ParameterType.GetOrPost);
                request.AddParameter("countrycode", "CN", ParameterType.GetOrPost);
                return request;
            }
        }
    }
}