using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main()
        {
            //AND operator
            Console.WriteLine(true && false);
            Console.WriteLine(true && true);
            Console.WriteLine(false && false);

            //OR operator
            Console.WriteLine(true || true);
            Console.WriteLine(true || false);
            Console.WriteLine(false || false);

            //== operator
            Console.WriteLine(true == true);
            Console.WriteLine(true == false);
            Console.WriteLine(false == false);

            //!= operator
            Console.WriteLine(true != true);
            Console.WriteLine(true != false);
            Console.WriteLine(false != false);

            //^(XOR) operator
            Console.WriteLine(true ^ true);
            Console.WriteLine(true ^ false);
            Console.WriteLine(false ^ false);

            Console.ReadLine();
        }
    }
}
