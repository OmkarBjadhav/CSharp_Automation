﻿using EmployeeProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maveric.Runner
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("**********Employee Dashboard****************");


            Employee emp=new Employee();
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            Employee emp3 = new Employee();
            emp.empId = 101;
            emp.empName = "saul";
            emp.empSalary = 9000;

            emp1.empId = 102;
            emp1.empName = "kim";
            emp1.empSalary = 12000.2;

            emp2.empId = 103;
            emp2.empName = "Jack";
            emp2.empSalary = 6000.2;
            /*Console.WriteLine(emp2.empId);
            Console.WriteLine(emp2.empId);
            Console.WriteLine(emp2.empId);*/

            emp.PrintEmployeeDetails();
            emp1.PrintEmployeeDetails();
            emp2.PrintEmployeeDetails();
            emp3.PrintEmployeeDetails();
        }
    }
}
