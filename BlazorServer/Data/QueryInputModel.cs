using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Data
{
    public class QueryInputModel
    {
        public string baseResource { get; set; }
        public string t1Resource { get; set; }
        public string t2Resource { get; set; }
        public string location1 { get; set; }
        public string location2 { get; set; }
    }
}