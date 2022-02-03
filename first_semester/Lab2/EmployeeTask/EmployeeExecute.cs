using System;

namespace EmployeeTask
{
    class EmployeeExecute
    {
        static void Main(string[] args)
        {
            var employee = Employee.CreateEmployee();
            employee.CalculateSalary(3);
            employee.PrintInfo();
        }
    }
}
