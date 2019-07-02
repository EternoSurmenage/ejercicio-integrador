using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace ArticlesAPI.Models
{
    public class Doc
    {
        public string Web_URL { get; set; }
        public string Snippet { get; set; }
        public Headline Headline { get; set; }
        public System.DateTime Pub_Date { get; set; }
        public bool StatusAvailable { get; set; } = true;
    }
}