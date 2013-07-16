using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;

namespace CBAPITimeTest.TestSections
{
    interface ITestSection
    {
        IRestRequest Request { get; }
    }
}
