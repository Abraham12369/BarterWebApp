using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Models
{
    public class ItemRoutes
    {
        public string Chain { get; set; }
        public string Tier { get;set; }
        public string Location { get; set; }
        public string ItemActual { get; set; }
        public string ItemTo { get; set; }
        public int ChainID { get; set; }
        public int ChainSubID { get; set; }
        public int Amount { get; set; }
        public int TraderLocation { get; set; }

    }
}
