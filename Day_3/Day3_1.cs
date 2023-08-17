using System;

namespace EmployeeHierarchy
{
    abstract class Employee
    {
        public string Name { get; }
        public string EmployeeID { get; }
        public double Salary { get; }

        public Employee(string name, string employeeID, double salary)
        {
            Name = name;
            EmployeeID = employeeID;
            Salary = salary;
        }

        public abstract double CalculateBonus();

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Employee ID: {EmployeeID}");
            Console.WriteLine($"Salary: ${Salary}");
        }
    }

    class Manager : Employee
    {
        public Manager(string name, string employeeID, double salary)
            : base(name, employeeID, salary)
        {
        }

        public override double CalculateBonus()
        {
            return Salary * 0.1;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Calculated Bonus: ${CalculateBonus():F2}");
        }
    }

    class Developer : Employee
    {
        public Developer(string name, string employeeID, double salary)
            : base(name, employeeID, salary)
        {
        }

        public override double CalculateBonus()
        {
            return Salary * 0.08;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Calculated Bonus: ${CalculateBonus():F2}");
        }
    }

    class SalesPerson : Employee
    {
        public SalesPerson(string name, string employeeID, double salary)
            : base(name, employeeID, salary)
        {
        }

        public override double CalculateBonus()
        {
            return Salary * 0.05;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Calculated Bonus: ${CalculateBonus():F2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("John Doe", "M001", 50000);
            Developer developer = new Developer("Jane Smith", "D001", 60000);
            SalesPerson salesPerson = new SalesPerson("Alice Johnson", "S001", 45000);

            manager.DisplayDetails();
            Console.WriteLine();
            developer.DisplayDetails();
            Console.WriteLine();
            salesPerson.DisplayDetails();
        }
    }
}
