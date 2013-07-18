using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using RestSharp;

namespace CBAPITimeTest.TestSections
{
    class CreateResume : TestSectionBase
    {
        protected override void BuildRequest(IRestRequest request)
        {
            throw new NotImplementedException();
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