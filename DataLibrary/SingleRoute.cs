using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary
{
    public class SingleRoute
    {
        string chain;
        int tier;
        string location;
        string itemActual;
        string itemTo;
        double chainID;
        string subPaste;
        int amount;
        int verified;
        int locationIndex;

        public string Chain
        {
            get { return chain; }
            set { chain = value; }
        } 
        public int Tier
        {
            get { return tier; }
            set { tier = value; }
        } 
        public string Location
        {
            get { return location; }
            set { location = value; }
        } 
        public string ItemActual
        {
            get { return itemActual; }
            set { itemActual = value; }
        } 
        public string ItemTo
        {
            get { return itemTo; }
            set { itemTo = value; }
        } 
        public double ChainID
        {
            get { return chainID; }
            set { chainID = value; }
        } 
        public string SubPaste
        {
            get { return subPaste; }
            set { subPaste = value; }
        } 
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        } 
        public int Verified
        {
            get { return verified; }
            set { verified = value; }
        } 
        public int LocationIndex
        {
            get { return locationIndex; }
            set { locationIndex = value; }
        } 

    }
}
