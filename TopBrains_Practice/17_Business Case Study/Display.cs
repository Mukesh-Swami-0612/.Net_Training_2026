using System;
using System.Collections.Generic;

/// <summary>
/// Contains methods used to display employee information.
/// </summary>
class Display
{
    /// <summary>
    /// Displays the details of a single employee.
    /// </summary>
    public static void DisplayEmployee(Employee emp)
    {
        // Check if employee is not found
        if (emp == null)
        {
            Console.WriteLine("\nEmployee Not Found.");
            return;
        }

        // Display employee details
        Console.WriteLine("\nEmployee Details");
        

        Console.WriteLine("Employee ID : " + emp.EmployeeId);
        Console.WriteLine("Name : " + emp.Name);
        Console.WriteLine("Designation : " + emp.Designation);
        Console.WriteLine("Department  : " + emp.Department);
        Console.WriteLine("Manager ID  : " + emp.ManagerId);

        
    }


    /// <summary>
    /// Displays a list of employees.
    /// </summary>
    public static void DisplayEmployees(List<Employee> employees)
    {
        // Check if the list is empty
        if (employees.Count == 0)
        {
            Console.WriteLine("\nNo Employees Found.");
            return;
        }

        Console.WriteLine();

        
        Console.WriteLine("ID\tName\t\t\tDesignation\t\tDepartment");
        

        // Display each employee
        foreach (Employee emp in employees)
        {
            Console.WriteLine(
                emp.EmployeeId + "\t" +
                emp.Name + "\t\t" +
                emp.Designation + "\t\t" +
                emp.Department
            );
        }


    }


    /// <summary>
    /// Displays the basic information of an employee.
    /// </summary>
    public static void DisplaySimple(Employee emp)
    {
        // Display employee name and designation
        Console.WriteLine(
            emp.Name + " (" + emp.Designation + ")"
        );
    }
}