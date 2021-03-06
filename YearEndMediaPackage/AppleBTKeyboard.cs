﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearEndMediaPackage
{
    public class AppleBTKeyboard
    {
        public AppleBTKeyboard (string myItemName, string mySKU, Int64 myUPC)
        {
            itemName = myItemName;
            sku = mySKU;
            upc = myUPC;
        }

        public string itemName { get; set; }
        public string sku { get; set; }
        public Int64 upc { get; set; }

        public override string ToString()
        {
            return "  Apple Keyboard Info:\n" + "   Item Name: " + itemName + "\n   SKU: " + sku + "\n   UPC: " + upc;
        }

    }
}
