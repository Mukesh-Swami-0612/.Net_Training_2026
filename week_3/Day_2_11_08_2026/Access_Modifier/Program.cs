using System;

public class Employee
{
    private decimal _salary;

    public string Name = string.Empty;

    protected string Department = "General";

    internal string EmpId = "E-1001";

    protected internal void SetDepartment(string department)
    {
        Department = department;
    }

    public void ShowSalary()
    {
        Console.WriteLine($"Salary: {_salary}");
    }

    private protected void AdjustSalary(decimal salary)
    {
        _salary = salary;
    }
}

public class Manager : Employee
{
    public void PrintDetails()
    {
        Name = "Mukesh";

        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Department: {Department}");

        SetDepartment("Engineering");

        AdjustSalary(80000);

        Console.WriteLine($"Employee ID: {EmpId}");

        ShowSalary();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Manager manager = new Manager();

        manager.PrintDetails();

    }
}