using System;
using System.Collections.Generic;

namespace Inheritance15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pay an hourly employee Bob who works for 40 hours
            // Bob's hourly rate is $27.50
            HourlyEmployee bob = new HourlyEmployee() { Name = "Bob" };
            //bob.PayEmployee();


            // Pay a salaried employee Steve who works one week.
            // Steve's yearly salary is $50,000
            SalaryEmployee steve = new SalaryEmployee() { Name = "Steve" };
            //steve.PayEmployee();

            var employees = new List<Employee>();
            employees.Add(bob);
            employees.Add(steve);

            PayEmployees(employees);


        }

        static void PayEmployees(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                employee.PayEmployee();
            }
        }
    }

    abstract class Employee
    {
        public string Name { get; set; }

        public abstract void PayEmployee();
    }

    class HourlyEmployee : Employee
    {
        public override void PayEmployee()
        {
            double hourlyPay = 40 * 27.5;
            Console.WriteLine($"This is {Name}'s pay for 40 hours of work = ${hourlyPay}");
        }
    }

    class SalaryEmployee : Employee
    {
        public override void PayEmployee()
        {
            int salaryPayPerWeek = 50000 / 52;
            int hourlyPay = salaryPayPerWeek / 40;
            Console.WriteLine($"{Name}'s salary pay is $50,000. This equates to ${salaryPayPerWeek} per week and ${hourlyPay} per hour");
        }
    }
}
