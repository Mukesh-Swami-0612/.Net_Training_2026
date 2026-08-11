using System;
using System.Collections.Generic;

public class Program
{
    /// <summary>
    /// Main method where the program starts.
    /// Demonstrates inheritance and polymorphism.
    /// </summary>
    public static void Main()
    {
        // Create a list using the Employee base class
        List<Employee> employees = new List<Employee>();

        // Add different types of employees
        employees.Add(
            new SalariedEmployee("Alice", 4500m)
        );

        employees.Add(
            new CommissionEmployee("Bob", 3000m, 200m)
        );

        employees.Add(
            new CommissionEmployee("Carla", 3500m, 650m)
        );


        // Process all employees using the Employee reference
        foreach (Employee employee in employees)
        {
            employee.PrintPaySlip();
        }


        // ----------------------------------------
        // TESTING ABSTRACT CLASS
        // ----------------------------------------

        // The following code will NOT compile because
        // Employee is an abstract class.

        // Employee employee = new Employee("John", 4000m);
    }
}