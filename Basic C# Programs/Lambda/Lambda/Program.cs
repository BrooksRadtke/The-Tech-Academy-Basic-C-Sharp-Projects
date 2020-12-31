using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of 10 employees with f/lname, and ID
            // At least 2 employees have fname Joe

            var employeeList = new List<T>();
            Employee emp1;

            emp1.firstName = "Joe";
            emp1.lastName = "Furguson";
            emp1.ID = 2212;
            employeeList.Add(emp1);

            //var employees = new List<Tuple<string, string, int>>();
            //employees.Add(Tuple.Create("Joe", "Furguson", 2212));
            //employees.Add(Tuple.Create("Margaret", "Thatcher", 194));
            //employees.Add(Tuple.Create("John", "Jacob", 789));
            //employees.Add(Tuple.Create("Jing", "Le", 188));
            //employees.Add(Tuple.Create("Heimer", "Schmitt", 103));
            //employees.Add(Tuple.Create("Joe", "Smith", 023));
            //employees.Add(Tuple.Create("Joe", "Seph", 321));
            //employees.Add(Tuple.Create("Joe", "Hood", 91829));
            //employees.Add(Tuple.Create("Red", "Hood", 14793));
            //employees.Add(Tuple.Create("Erik", "Gross", 1));
        }

        public struct Employee
        {
            public string firstName;
            public string lastName;
            public int ID;
        }
    }
}
