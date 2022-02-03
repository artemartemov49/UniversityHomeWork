using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ParserUtils.ParserUtil;

namespace EmployeeTask
{
    class Employee
    {
        private readonly string _name;
        private readonly string _surname;
        public int TotalDays { get; set; }
        public string Grade { get; set; }
        public double Salary { get; set; }

        public static readonly IDictionary<string, int> Grades = new Dictionary<string, int>()
        {
            {"Programmer", 1000},
            {"SEO", 750},
            {"Office clerk", 600},
        };

        public Employee(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }

        private int GetSalary()
        {
            return Grades[Grade];
        }

        private double SubtractTax(int taxPercentage)
        {
            return GetSalary() * (1 - taxPercentage / 100.0);
        }

        public void CalculateSalary(int taxPercentage)
        {
            double workExperienceMultiplier = 1;
            if (TotalDays > 50)
            {
                workExperienceMultiplier = TotalDays * 0.02;
            }
            Salary = SubtractTax(taxPercentage) * workExperienceMultiplier;
            if (Salary > 20_000)
            {
                Salary = 20_000;
            }
            
           
        }

        public static Employee CreateEmployee()
        {
            var name = ValidateAndParseRegex(NameRegex, "Name");
            var surname = ValidateAndParseRegex(NameRegex, "Surname");
            return new Employee(name, surname)
            {
                TotalDays = ValidateAndParseIntRange("work experience in total days",0, 50_000),
                Grade = ValidateAndParseExactWordList("grade", Grades.Keys.ToList())
            };
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {_name}, Surname: {_surname}, TotalDays: {TotalDays}, Grade: {Grade}, Salary: {Salary}");
        }
    }
}