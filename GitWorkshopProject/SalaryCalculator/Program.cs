﻿using System;

namespace SalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var engineerSalary = EmployeeService.CalculateSalary(EmployeeType.Engineer, 2);

            var managerSalary = EmployeeService.CalculateSalary(EmployeeType.Engineer, 2);


            Console.WriteLine(string.Format("Engineer's Salary: {0}", engineerSalary));

             Console.WriteLine(string.Format("Manager's Salary: {0}", managerSalary));

            Console.ReadLine();
        }
    }
}
