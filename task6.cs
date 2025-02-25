// Task 6: Employee Payroll System
// Task: Create an Employee class with:
// Name, Position, SalaryPerHour, and HoursWorked.
// A method CalculateSalary() that returns SalaryPerHour * HoursWorked.
// In Main(), create 3 employees, calculate their salaries, and display them.
// If an employee works over 40 hours, pay overtime (1.5x rate).

using System;

class Employee {
    public string Name {get; set;}
    public string Position{get; set;}
    public double SalaryPerHour {get; set;}
    public double HoursWorked {get; set;}

    public Employee (string name, string position, double salaryPerHour, double hoursworked) {
        Name = name;
        Position = position;
        SalaryPerHour = salaryPerHour;
        HoursWorked = hoursworked;
    }
    public void CalculateSalary (Employee obj) {
        double sum = 0f;
        if (obj.HoursWorked > 40) {
            sum = obj.SalaryPerHour * obj.HoursWorked * 1.5;
            Console.WriteLine ($"{obj.Name} Salary is {sum}");
            return;
        }
        sum = obj.SalaryPerHour * obj.HoursWorked;
        Console.WriteLine ($"{obj.Name} is {sum}");
        
    }

}

class Program {
    static void Main (string[] args) {

        Employee[] Employees = new Employee[3];
        bool Flag = true;

        Console.WriteLine("Please Enter your Emplotees");

        for (int i = 0; i < Employees.Length; ++i) {
            Console.Write("Please Enter Name ");
            string name = Console.ReadLine();
            Console.Write("Please Enter Position ");
            string position = Console.ReadLine();
            Console.Write ("Please Enter Saylar Per Hour ");
            int salaryPerHour = int.Parse(Console.ReadLine());
            Console.Write ("Please Enter Hours Worked ");
            int HoursWorked = int.Parse(Console.ReadLine());
            Employees[i] = new Employee(name, position, salaryPerHour, HoursWorked);

        }

        while (true) {

            Console.Write ("Whose Salary do you want to see?\nEnter the name\nto Exit write Exit ");
            string name =Console.ReadLine();
            if (name.Equals("Exit")) {
                break;
            }

            for (int i = 0; i < Employees.Length; ++i) {
                if (Employees[i].Name.Equals(name)) {
                    Employees[i].CalculateSalary (Employees[i]);
                    Flag = false;
                }
            }
            if (Flag) {
                Console.WriteLine ($"The name {name} does not existed");
            }
            Flag = true;
        } 
        
    }
}