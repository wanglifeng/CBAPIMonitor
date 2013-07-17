using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;

namespace CBAPITimeTest.TestSections
{
    public class UserCreate :ITestSection 
    {

        public IRestRequest Request
        {
            get 
            {
                var request = new RestRequest();
                request.Resource = "v2/user/create";
                request.Method = Method.POST;
                request.AddParameter("developerkey", "WD1B37Z74Y7BL07ZM89B", ParameterType.GetOrPost);
                request.AddParameter("Password", "ruby4ever", ParameterType.GetOrPost);
                request.AddParameter("Email", "shijie.shao@careerbuilder.com", ParameterType.GetOrPost);
                request.AddParameter("FirstName", "shijie", ParameterType.GetOrPost);
                request.AddParameter("LastName", "shao", ParameterType.GetOrPost);
                request.AddParameter("City", "shanghai", ParameterType.GetOrPost);
                request.AddParameter("CountryCode", "sh", ParameterType.GetOrPost);
                request.AddParameter("Test", true, ParameterType.GetOrPost);
                request.AddParameter("AllowEventMails", false, ParameterType.GetOrPost);
                request.AddParameter("AllowPartnerEmails", false, ParameterType.GetOrPost);
                return request;
            }
        }
    }
}