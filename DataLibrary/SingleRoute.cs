using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary
{
    public class SingleRoute
    {
        string chain;
        string subPaste;
        string baseItem;
        string item1;
        string item2;
        string item3;
        string item4;
        string item5;
        string location1;        
        string location2;        
        string location3;        
        string location4;        
        string location5;
        string location6;        
        

        public string Chain
        {
            get { return chain; }
            set { chain = value; }
        }

        public string SubPaste
        {
            get { return subPaste; }
            set { subPaste = value; }
        }

        public string BaseItem
        {
            get { return baseItem; }
            set { baseItem = value; }
        }

        public string Item1
        {
            get { return item1; }
            set { item1 = value; }
        }

        public string Item2
        {
            get { return item2; }
            set { item2 = value; }
        }

        public string Item3
        {
            get { return item3; }
            set { item3 = value; }
        }

        public string Item4
        {
            get { return item4; }
            set { item4 = value; }
        }

        public string Item5
        {
            get { return item5; }
            set { item5 = value; }
        }

        public string Location1
        {
            get { return location1; }
            set { chain = value; }
        }

        public string Location2
        {
            get { return location2; }
            set { location2 = value; }
        }

        public string Location3
        {
            get { return location3; }
            set { location3 = value; }
        }

        public string Location4
        {
            get { return location4; }
            set { location4 = value; }
        }

        public string Location5
        {
            get { return location5; }
            set { location5 = value; }
        }

        public string Location6   
        {
            get { return location6; }
            set { location6 = value; }
        }

        public string OutputString()
        {
            return string.Join(",", new string[] { chain, subPaste, baseItem, Item1, Item2, Item3, Item4, Item5, location1, location2, location3, location4, location5, location6 });
        }
    }
}
