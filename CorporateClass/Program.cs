using CorporateClass.Components;
using System;

namespace CorporateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // In the Main method, create a company, and three employees, and then assign the employees to the company.
            var fakeBusines = new Company("Fictionally Yours", DateTime.Now);
            fakeBusines.ListEmployees();
            var employee1 = new Employee("Snoop Dogg", "rapper");
            var employee2 = new Employee("Dr. Dre", "rapper");
            var employee3 = new Employee("Eminem", "rapper");
            fakeBusines.HireStaff(employee1);
            fakeBusines.HireStaff(employee2);
            fakeBusines.HireStaff(employee3);
            fakeBusines.HireStaff(employee3);
            fakeBusines.ListEmployees();

            fakeBusines.FireStaff(employee3);
            fakeBusines.HireStaff(new Employee("Martha Stewart", "host"));
            fakeBusines.ListEmployees();
        }
    }
}
