﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProject
{
    public class Employee
    {
        public int empId;
        public string empName;
        public double empSalary;
        public static string companyName = "Maveric";
        public static string companLocation = "Pune";
        public void PrintEmployeeDetails()
        {
            Console.WriteLine("Employee Id: "+empId);
            Console.WriteLine("Employee Name: "+empName);
            Console.WriteLine("Employee Salary: " + empSalary);
            Console.WriteLine("Company Name: " +Employee.companyName);
            Console.WriteLine("Company Location: " + Employee.companLocation);
            Console.WriteLine("________________________________________");
        }
    }
}
