using System;
using System.Collections.Generic;
using System.Text;

namespace CorporateClass.Components
{
    public class Employee
    {
        public string EmployeeName { get; set; }
        public string JobTitle { get; set; }
        public int Id { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime TerminationDate { get; set; }

        public Employee(string name, string title)
        {
            EmployeeName = name;
            JobTitle = title;
        }
    }
}
