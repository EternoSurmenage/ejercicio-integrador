using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace ArticlesAPI.Models
{
    public class RootObject
    {
        public string Status { get; set; }
        public string Copyright { get; set; }
        public Response Response { get; set; }
    }
}