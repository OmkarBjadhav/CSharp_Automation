using System;
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
        public char empPerformanceType;
        public static string companyName = "Maveric";
        public static string companLocation = "Pune";
        public void PrintEmployeeDetails()
        {
           /* Console.WriteLine("Employee Id: "+empId);
            Console.WriteLine("Employee Name: "+empName);*/
           // Console.WriteLine("Employee Salary: " + empSalary);
            //Console.WriteLine("Employee Perforamnce:" + empPerformanceType);
            //Console.WriteLine("Company Name: " +Employee.companyName);
            //Console.WriteLine("Company Location: " + Employee.companLocation);
         
        }

        public void GetGrossSalaryWithBonus()
        {
            Console.WriteLine("Employee Id: " + empId);
            if (empPerformanceType == 'A')
            {
                Console.WriteLine(empSalary + (empSalary * 25 / 100.0));
            }
            else if (empPerformanceType == 'B')
            {
                Console.WriteLine(empSalary + (empSalary * 20 / 100.0));

            }
            else if (empPerformanceType == 'C')
            {
                Console.WriteLine(empSalary+(empSalary*10/100.0));

            }
            else Console.WriteLine("Not applicable for Bonus");
            Console.WriteLine("________________________________________");


        }
    }
}
