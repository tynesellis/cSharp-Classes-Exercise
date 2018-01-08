using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Company Bankish = new Company("Bankish Banq", DateTime.Now);
            Console.WriteLine(Bankish.CreatedOn);

            Employee Paul = new Employee("Paul", "Captain", DateTime.Now);
            Employee Pauly = new Employee("Pauly", "First Mate", DateTime.Now);
            Employee Pawl = new Employee("Pawl", "XO", DateTime.Now);
            

            Bankish.addEmployee(Paul);
            Bankish.addEmployee(Pauly);
            Bankish.addEmployee(Pawl);

            Bankish.ListEmployees();
        }
    }
}
