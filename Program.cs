using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {

        public class Company
        {
            /*
                Some readonly properties
            */
            public string Name { get; }
            public DateTime CreatedOn { get; }

            // Create a property for holding a list of current employees
            public List<Employee> employees { get; set; }
            // Create a method that allows external code to add an employee
            public void addEmployee(Employee NewEmployee)
            {
                employees.Add(NewEmployee);
            }
            // Create a method that allows external code to remove an employee
            public void deleteEmployee(Employee BadEmployee)
            {
                employees.Remove(BadEmployee);
            }
            /*
                Create a constructor method that accepts two arguments:
                    1. The name of the company
                    2. The date it was created

                The constructor will set the value of the public properties
            */
            public Company(string name, DateTime date)
            {
                Name = name;
                CreatedOn = date;
                List<Employee> BankEmployees = new List<Employee>();
                employees = BankEmployees;
            }

            public void ListEmployees() 
            {
                employees.ForEach(e => Console.WriteLine($"{e.Name}"));
            }
        }

        public class Employee
        {
            public string Name { get; set; }
            public string Role { get; set; }
            public DateTime Started { get; set; }

            public Employee(string name, string role, DateTime started)
            {
                Name = name;
                Role = role;
                Started = started;
            }

            public void changeName(string newName)
            {
                Name = newName;
            }

            public void newRole(string newRole)
            {
                Role = newRole;
            }
        }

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
