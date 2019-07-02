using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace ArticlesAPI.Models
{
    public class Response
    {
        public List<Doc> Docs { get; set; }
        public Meta Meta { get; set; }
    }
}