using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearEndMediaPackage
{
    public class MediaPackage
    {
        public MediaPackage (string myPackageName, string mySKU, double myPrice, AppleBTKeyboard myKeyboard, BeatsBTSpeaker mySpeaker, iPad myiPad)
        {
            packageName = myPackageName;
            sku = mySKU;
            price = myPrice;
            mpKeyboard = myKeyboard;
            mpSpeaker = mySpeaker;
            mpiPad = myiPad;

        }

        public AppleBTKeyboard mpKeyboard { get; set; }
        public BeatsBTSpeaker mpSpeaker { get; set; }
        public iPad mpiPad { get; set; }

        //new variables:
        public string packageName { get; set; }
        public string sku { get; set; }
        public double price { get; set; }

        public override string ToString()
        {
            return string.Format("\nPackage Info for " + packageName + ":" + " Price: $" + price + "  --  SKU: " + sku + "\n" + mpiPad + "\n" + mpKeyboard + "\n" + mpSpeaker);

        }

    }
}
