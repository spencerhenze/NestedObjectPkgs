using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearEndMediaPackage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("\nHere are this year's packages:\n");

            //Keyboards:
            AppleBTKeyboard keyboard01 = new AppleBTKeyboard("Apple Bluetooth Keyboard", "AP-BTK-2016", 123456789112);
            AppleBTKeyboard keyboard02 = new AppleBTKeyboard("Apple Bluetooth Keyboard (NumPad)", "AP-BTK-NP-2016", 123456789113);

            //Speaker Units:
            BeatsBTSpeaker speaker01 = new BeatsBTSpeaker("Beats Pill 2000", "BP-2K-01-2016", 567894568744);
            BeatsBTSpeaker speaker02 = new BeatsBTSpeaker("Beats Pill 5000", "BP-5K-01-2016", 567894568745);

            //iPads:
            iPad iPad01 = new iPad("iPad Mini (16GB)", "AP-IPM-16G-16", 254685134568);
            iPad iPad02 = new iPad("iPad Pro 13 inch (128GB)", "AP-IPP-128G-16", 254652331489);

            //Media Packages:
            MediaPackage package01 = new MediaPackage("Package A", "MP-01-2016", 599.99, keyboard01, speaker01, iPad01);
            MediaPackage package02 = new MediaPackage("Package B", "MP-02-2016", 899.99, keyboard02, speaker02, iPad02);

            //Display all the info:
            Console.WriteLine(package01);
            Console.WriteLine(package02);

            Console.ReadLine();
        }
    }
}
