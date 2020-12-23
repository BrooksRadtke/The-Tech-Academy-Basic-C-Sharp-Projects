using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            ////Long way of array input
            //int[] numArray = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;

            ////More efficient way of input
            //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

            ////Efficient shortcut
            //int[] numArray2 = { 5, 2, 10, 200, 5000 };

            ////changing values of an index
            //numArray2[2] = 234987;

            //Console.WriteLine(numArray2[2]);
            //Console.ReadLine();
            
            //List using int
            List<int> intList = new List<int>();
            intList.Add(4);
            intList.Add(10);
            intList.Remove(10);

            Console.WriteLine(intList[0]);
            Console.ReadLine();
        }
    }
}
