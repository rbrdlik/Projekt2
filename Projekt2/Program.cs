using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2
{
    enum Department
    {
        NoobProgrammer,
        MidProgrammer,
        ProfesionalProgrammer,
        Company
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee pepa = new Employee("Pepa", "Novák", 200000, Department.MidProgrammer);
            Manager jenda = new Manager("Jenda", "Fukinci", 300000, Department.ProfesionalProgrammer, 500);
            Boss bara = new Boss("Bara", "Slavikova", 500000, Department.Company, 500, 1000);

            pepa.DisplayInformation();
            jenda.DisplayInformation();
            bara.DisplayInformation();

            Console.ReadKey();
        }
    }
    class Employee
    {
        public string name;
        public string surname;
        public int Salary;
        public Department department;

        public Employee(string name, string surname, int salary, Department department)
        {
            if (name == null || name == "")
            {
                this.name = "DefaultFranta";
                if (surname == null || surname == "")
                {
                    this.surname = "Default";
                }
                else
                {
                    this.surname = surname;
                }
            }
            else
            {
                this.name = name;
            }
            this.Salary = salary;
            this.department = department;
        }

        public int CalculateMonthlySalary()
        {
            return this.Salary / 12;
        }

        public void DisplayInformation()
        {
            Console.WriteLine($"Name: {this.name}");
            Console.WriteLine($"Salary: {this.Salary}");
            Console.WriteLine($"Deparment: {this.department}");
            Console.WriteLine($"Monthly salary: {CalculateMonthlySalary()}");
        }
    }
    class Manager : Employee
    {
        public int bonus;

        public Manager(string name, string surname, int salary, Department department, int bonus) : base(name, surname, salary, department)
        {
            this.bonus = bonus;
        }
        public int CalculateMonthlySalary()
        {
            return (this.Salary + this.bonus) / 12;
        }

        public void DisplayInformation()
        {
            Console.WriteLine($"Name: {this.name}");
            Console.WriteLine($"Salary: {this.Salary + this.bonus}");
            Console.WriteLine($"Deparment: {this.department}");
            Console.WriteLine($"Monthly salary: {CalculateMonthlySalary()}");
        }
    }
    class Boss : Manager
    {
        public int StockOptions;

        public Boss(string name, string surname, int salary, Department department, int bonus, int StockOptions) : base(name, surname, salary, department, bonus)
        {
            this.StockOptions = StockOptions;
        }
        public int CalculateMonthlySalary()
        {
            return (this.Salary + this.bonus + this.StockOptions) / 12;
        }

        public void DisplayInformation()
        {
            Console.WriteLine($"Name: {this.name}");
            Console.WriteLine($"Salary: {this.Salary + this.bonus + this.StockOptions}");
            Console.WriteLine($"Deparment: {this.department}");
            Console.WriteLine($"Monthly salary: {CalculateMonthlySalary()}");
        }
    }
}
