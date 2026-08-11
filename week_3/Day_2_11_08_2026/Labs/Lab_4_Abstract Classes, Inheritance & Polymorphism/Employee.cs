using System;

public abstract class Employee
{
    // Employee name
    public string Name { get; }

    // Employee's basic salary
    public decimal BaseSalary { get; }

    /// <summary>
    /// Creates an Employee with name and base salary.
    /// </summary>
    protected Employee(string name, decimal baseSalary)
    {
        Name = name;
        BaseSalary = baseSalary;
    }

    /// <summary>
    /// Calculates the employee's total pay.
    /// Each child class must provide its own implementation.
    /// </summary>
    public abstract decimal CalculatePay();

    /// <summary>
    /// Prints the employee's name and calculated pay.
    /// </summary>
    public void PrintPaySlip()
    {
        Console.WriteLine($"{Name}: {CalculatePay():C}");
    }
}


// SalariedEmployee inherits from Employee
public class SalariedEmployee : Employee
{
    /// <summary>
    /// Creates a salaried employee.
    /// </summary>
    public SalariedEmployee(string name, decimal baseSalary)
        : base(name, baseSalary)
    {
    }

    /// <summary>
    /// Returns the base salary as the employee's pay.
    /// </summary>
    public override decimal CalculatePay()
    {
        return BaseSalary;
    }
}


// CommissionEmployee inherits from Employee
public class CommissionEmployee : Employee
{
    // Extra commission earned by the employee
    public decimal CommissionEarned;

    /// <summary>
    /// Creates a commission employee with salary and commission.
    /// </summary>
    public CommissionEmployee(
        string name,
        decimal baseSalary,
        decimal commission)
        : base(name, baseSalary)
    {
        CommissionEarned = commission;
    }

    /// <summary>
    /// Calculates pay by adding base salary and commission.
    /// </summary>
    public override decimal CalculatePay()
    {
        return BaseSalary + CommissionEarned;
    }
}