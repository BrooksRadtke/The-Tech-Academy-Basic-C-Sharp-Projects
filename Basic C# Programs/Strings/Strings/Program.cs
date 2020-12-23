using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main()
        {
            //string name = "Brooks";
            //string fileName = @"C:\Users\brooks";   //includes all escape symbols

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;               //when called, shows number of char

            //name = name.ToLower();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Brooks");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
