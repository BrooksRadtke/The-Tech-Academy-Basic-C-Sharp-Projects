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

            List<Employee> empList = new List<Employee>();
            Employee emp1 = new Employee() { firstName = "Joe", lastName = "Furguson", ID = 1 };
            Employee emp2 = new Employee() { firstName = "Margaret", lastName = "Thatcher", ID = 2 };
            Employee emp3 = new Employee() { firstName = "John", lastName = "Jacob", ID = 7 };
            Employee emp4 = new Employee() { firstName = "Jing", lastName = "Le", ID = 8 };
            Employee emp5 = new Employee() { firstName = "Heimer", lastName = "Schmitt", ID = 3 };
            Employee emp6 = new Employee() { firstName = "Joe", lastName = "Smith", ID = 4 };
            Employee emp7 = new Employee() { firstName = "Joe", lastName = "Seph", ID = 6 };
            Employee emp8 = new Employee() { firstName = "Joe", lastName = "Hood", ID = 5 };
            Employee emp9 = new Employee() { firstName = "Red", lastName = "Hood", ID = 9 };
            Employee emp10 = new Employee() { firstName = "Erik", lastName = "Gross", ID = 1 };
            empList.Add(emp1);
            empList.Add(emp2);
            empList.Add(emp3);
            empList.Add(emp4);
            empList.Add(emp5);
            empList.Add(emp6);
            empList.Add(emp7);
            empList.Add(emp8);
            empList.Add(emp9);
            empList.Add(emp10);

            // Uses a foreach loop to create a new list of Joes
            //List<Employee> joeList = new List<Employee>();

            // Checks through the employee list for any fnames of joe
            // if found, is added to new list
            //foreach (Employee employee in empList)
            //{
            //    if (employee.firstName == "Joe")
            //    {
            //        joeList.Add(employee);
            //    }
            //}

            //// Prints name and information for each item in list
            //foreach(Employee joe in joeList)
            //{
            //    Console.WriteLine(joe.firstName + " " + joe.lastName + " " + joe.ID);
            //}

            //Console.ReadLine();

            // Uses a lambda to create list of Joes
            List<Employee> joeList = new List<Employee>();
            joeList = empList.Where(x => x.firstName == "Joe").ToList();
            foreach(Employee joe in joeList)
            {
                Console.WriteLine(joe.firstName + " " + joe.lastName + " " + joe.ID);
            }
            Console.ReadLine();

            // Checks for employees with id over 5, and adds them to list
            // Prints each item in the list
            List<Employee> idCheckList = new List<Employee>();
            idCheckList = empList.Where(x => x.ID > 5).ToList();
            foreach(Employee emp in idCheckList)
            {
                Console.WriteLine(emp.firstName + " " + emp.lastName + " " + emp.ID);
            }
            Console.ReadLine();
        }

        public struct Employee
        {
            public string firstName;
            public string lastName;
            public int ID;
        }
    }
}
