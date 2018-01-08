using System;
using System.Collections.Generic;

namespace classes
{
   

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
    
}
