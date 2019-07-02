using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ArticlesAPI.Models
{
    public class Headline
    {
        public string Main { get; set; }
        public string Kicker { get; set; }
        public object ContentKicker { get; set; }
        public string PrintHeadline { get; set; }
        public object Name { get; set; }
        public object Seo { get; set; }
        public object Sub { get; set; }
    }
}