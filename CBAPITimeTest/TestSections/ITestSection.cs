using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;

namespace CBAPITimeTest.TestSections
{
    abstract class TestSectionBase
    {
        public IRestRequest Request
        {
            get
            {
                var request = new RestRequest();
                BuildRequest(request);
                return request;
            }
        }

        public virtual Boolean RequireHTTPS { get { return false; } }

        protected abstract void BuildRequest(IRestRequest request);
    }
}
