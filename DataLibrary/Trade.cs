using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary
{
    class Trade
    {
        public string ID;
        public string subPaste;
        public string location;
        public string give;
        public string receive;
        public string tier;
        public string quantity;

        public string OutputString()
        {
            return string.Join(",", new string[] { ID, subPaste, location, give, receive, tier, quantity });
        }
    }
}
