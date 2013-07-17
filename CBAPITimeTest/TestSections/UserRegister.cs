using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;

namespace CBAPITimeTest.TestSections
{
    public class UserRegister : ITestSection
    {
        public RestSharp.IRestRequest Request
        {
            get 
            {
                var request = new RestRequest();
                request.Resource = "v2/user/create";
                request.Method = Method.POST;
                request.AddParameter("developerkey", "WD1B37Z74Y7BL07ZM89B", ParameterType.GetOrPost);
                request.AddParameter("", "", ParameterType.GetOrPost);
                request.AddParameter("countrycode", "CN", ParameterType.GetOrPost);
                return request;
            }

        }
    }
}