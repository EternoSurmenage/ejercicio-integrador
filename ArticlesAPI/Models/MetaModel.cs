using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ArticlesAPI.Models
{
    public class Meta
    {
        public int Hits { get; set; }
        public int Offset { get; set; }
        public int Time { get; set; }
    }
}
