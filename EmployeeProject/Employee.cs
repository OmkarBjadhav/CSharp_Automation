

namespace EmployeeProject
{
    public class Employee
    {
        public int empId;
        public string empName;
        private double _empSalary;
        public char empPerformanceType;
        public static string companyName = "Maveric";
        public static string companLocation = "Pune";


       
        public double EmpSalary
        {

            get
            {
                return _empSalary;
            }
            set
            {
                if(value>3000)
                {
                    _empSalary = value;
                }
                else
                {
                    Console.WriteLine("Invalid  Salary");
                }
            }
            
        }

        public void PrintEmployeeDetails()
        {
            Console.WriteLine("Employee Id: " + empId);
            Console.WriteLine("Employee Name: " + empName);
            Console.WriteLine("Employee Salary: " + _empSalary);
            Console.WriteLine("Employee Perforamnce:" + empPerformanceType);
            Console.WriteLine("Company Name: " + Employee.companyName);
            Console.WriteLine("Company Location: " + Employee.companLocation);
            Console.WriteLine("-----------------------------------------------");

        }

        public void GetGrossSalaryWithBonus()
        {
            Console.WriteLine("Employee Id: " + empId);
            if (empPerformanceType == 'A')
            {
                Console.WriteLine(_empSalary + (_empSalary * 25 / 100.0));
            }
            else if (empPerformanceType == 'B')
            {
                Console.WriteLine(_empSalary + (_empSalary * 20 / 100.0));

            }
            else if (empPerformanceType == 'C')
            {
                Console.WriteLine(_empSalary+(_empSalary*10/100.0));

            }
            else Console.WriteLine("Not applicable for Bonus");
            Console.WriteLine("________________________________________");


        }
    }
}
