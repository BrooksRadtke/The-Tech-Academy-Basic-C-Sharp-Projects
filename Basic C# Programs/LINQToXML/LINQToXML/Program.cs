using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQToXML
{
    class Program
    {
        static void Main(string[] args)
        {
            // **Example of Chain Queries**
            string[] stringArray = { "abc", "def", "ghi" };

            IEnumerable<string> q1 =
                from s in stringArray.ConvertCollectionToUpperCase()
                select s;

            IEnumerable<string> q2 =
                from s in q1.AppendString("!!!")
                select s;

            foreach(string str in q2)
            {
                Console.WriteLine("Main: str >{0}<", str);
            }

            Console.Read();
        }
        // **END Example of Chain Queries**
    }

    // **Example of Chain Queries Logic**
    public static class LocalExtensions
    {
        public static IEnumerable<string>
            ConvertCollectionToUpperCase(this IEnumerable<string> source)
        {
            foreach(string str in source)
            {
                Console.WriteLine("To Upper: source >{0}<", str);
                yield return str.ToUpper();
            }
        }

        public static IEnumerable<string>
            AppendString(this IEnumerable<string> source, string stringToAppend)
        {
            foreach(string str in source.ToList())
            {
                Console.WriteLine("AppendString: source >{0}<", str);
                yield return str + stringToAppend;
            }
        }
    }
}
