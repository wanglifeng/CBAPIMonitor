using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CBAPITimeTest.Serializer
{
    public class NonSerializer : ISerializer
    {
        public string ContentType { get; set; }

        public string DateFormat { get; set; }

        public string Namespace { get; set; }

        public string RootElement { get; set; }

        public string Serialize(object obj)
        {
            return obj.ToString();
        }
    }
}