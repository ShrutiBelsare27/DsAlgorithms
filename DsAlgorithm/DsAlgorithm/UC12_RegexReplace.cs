using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DsAlgorithm
{
   public  class UC12_RegexReplace
    {
        public static void Regex1()
        {
            string input = "Hello <<name>>,name as << full name >> in our system.\nyour contact number is 91 - xxxxxxxxxx.\nPlease, let us know in case of any clarification Thank you BridgeLabz 01 / 01 / 2016.";
            Console.WriteLine(input);

            input = Regex.Replace(input, @"<<name>>", "Shruti");
            input = Regex.Replace(input, @"<< full name >>", "Shruti Belsare");
            input = Regex.Replace(input, @"9493375895", "");
            input = Regex.Replace(input, @"01 / 01 / 2016", "11 / 11/ 2021");

            Console.WriteLine("\n");
            Console.WriteLine("Replace Details Using Regex");
            Console.WriteLine("\n");
            Console.WriteLine(input);
        }
    }
}
