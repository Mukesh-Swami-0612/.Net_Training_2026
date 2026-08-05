using System;
using System.Collections.Generic;

/// <summary>
/// This class is used to display employee details.
/// </summary>
class Display
{
    /// <summary>
    /// Displays all employee details.
    /// </summary>
    public static void DisplayEmployees(List<Employee> employees)
    {
        // Check if the list is empty
        if (employees.Count == 0)
        {
            Console.WriteLine("\nNo Employee Found.");
            return;
        }

        Console.WriteLine();

        Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("ID\tName\t\tDepartment\tDesignation\t\tExperience\tSalary\t\tCity");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------");

        // Display each employee
        foreach (Employee emp in employees)
        {
            Console.WriteLine(
                emp.EmployeeId + "\t" +
                emp.Name + "\t" +
                emp.Department + "\t\t" +
                emp.Designation + "\t" +
                emp.Experience + "\t\t" +
                emp.Salary + "\t\t" +
                emp.City);
        }

    
    }

    /// <summary>
    /// Displays one employee.
    /// </summary>
    public static void DisplayEmployee(Employee emp)
    {
        // Check if employee exists
        if (emp == null)
        {
            Console.WriteLine("\nEmployee Not Found.");
            return;
        }

        Console.WriteLine("\nEmployee Details");

        Console.WriteLine("Employee ID : " + emp.EmployeeId);
        Console.WriteLine("Name : " + emp.Name);
        Console.WriteLine("Department : " + emp.Department);
        Console.WriteLine("Designation : " + emp.Designation);
        Console.WriteLine("Experience : " + emp.Experience + " Years");
        Console.WriteLine("Salary : " + emp.Salary);
        Console.WriteLine("City : " + emp.City);
    }
}