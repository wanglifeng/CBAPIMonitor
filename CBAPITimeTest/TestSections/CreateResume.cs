using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using RestSharp;

namespace CBAPITimeTest.TestSections
{
    public class CreateResume : ITestSection
    {
        public IRestRequest Request
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool RequireHTTPS
        {
            get
            {
                return true;
            }
        }
    }
}