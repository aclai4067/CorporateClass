using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CorporateClass.Components
{
    public class Company
    {
        // Some properties
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a private property for holding a collection of current employees
        private List<Employee> _CurrentStaff;

        // Create a method that allows a caller to add an employee
        public void HireStaff(Employee employee)
        {
            if (_CurrentStaff.FirstOrDefault(e => e.Id == employee.Id) == null)
            {
                employee.HireDate = DateTime.Now;
                employee.Id = _CurrentStaff.Count() + 1;
                _CurrentStaff.Add(employee);
            }
        }

        // Create a method that allows a caller to remove an employee
        public void FireStaff(Employee employee)
        {
            if (_CurrentStaff.FirstOrDefault(e => e.Id == employee.Id) != null)
            {
                employee.TerminationDate = DateTime.Now;
                _CurrentStaff.Remove(employee);
            }
        }

        // Create a method that allows a caller to retrieve the list of employees
        public List<Employee> RetrieveStaff()
        {
            return _CurrentStaff;   
        }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */

        public Company(string companyName, DateTime creationDate)
        {
            Name = companyName;
            CreatedOn = creationDate;
            _CurrentStaff = new List<Employee>();
        }

        // Update the Company class to write the name of each employee to the console. Consider a method named ListEmployees().
       
        public void ListEmployees()
        {
            if (_CurrentStaff.Any())
            {
                var staffNames = new List<string>();
                foreach (var employee in _CurrentStaff)
                {
                    staffNames.Add(employee.EmployeeName);
                }
                Console.WriteLine(string.Join(", ", staffNames));
            }
            else
            {
                Console.WriteLine("No Staff Found. Hire someone!");
            }
        }
    }
}
