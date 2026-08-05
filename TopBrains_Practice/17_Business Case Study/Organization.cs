using System;
using System.Collections.Generic;

/// <summary>
/// Contains all organization hierarchy operations.
/// </summary>
class Organization
{
    /// <summary>
    /// Finds an employee using Employee ID.
    /// </summary>
    public static Employee FindEmployeeById(List<Employee> employees, int id)
    {
        // Check every employee
        foreach (Employee emp in employees)
        {
            if (emp.EmployeeId == id)
            {
                return emp;
            }
        }

        // Employee not found
        return null;
    }

    /// <summary>
    /// Finds an employee using employee name.
    /// </summary>
    public static Employee FindEmployeeByName(List<Employee> employees, string name)
    {
        // Check every employee
        foreach (Employee emp in employees)
        {
            if (emp.Name.ToLower() == name.ToLower())
            {
                return emp;
            }
        }

        // Employee not found
        return null;
    }

    /// <summary>
    /// Displays the complete organization hierarchy using recursion.
    /// </summary>
    public static void DisplayOrganization(List<Employee> employees, int managerId, string space)
    {
        // Check every employee
        foreach (Employee emp in employees)
        {
            // Find employees working under the given manager
            if (emp.ManagerId == managerId)
            {
                // Display employee
                Console.WriteLine(space + emp.Name + " (" + emp.Designation + ")");

                // Display employees under this employee
                DisplayOrganization(employees, emp.EmployeeId, space + "    ");
            }
        }
    }

    /// <summary>
    /// Displays all employees working under a manager.
    /// </summary>
    public static void DisplayEmployeesUnderManager(List<Employee> employees, int managerId)
    {
        // Check every employee
        foreach (Employee emp in employees)
        {
            if (emp.ManagerId == managerId)
            {
                Console.WriteLine(emp.EmployeeId + " - " + emp.Name + " (" + emp.Designation + ")");
            }
        }
    }

    /// <summary>
    /// Counts total employees working under a manager using recursion.
    /// </summary>
    public static int CountEmployees(List<Employee> employees, int managerId)
    {
        // Store total employees
        int count = 0;

        // Check every employee
        foreach (Employee emp in employees)
        {
            if (emp.ManagerId == managerId)
            {
                // Count current employee
                count++;

                // Count employees under current employee
                count += CountEmployees(employees, emp.EmployeeId);
            }
        }

        return count;
    }

    /// <summary>
    /// Finds the hierarchy level of an employee using recursion.
    /// </summary>
    public static int FindLevel(List<Employee> employees, int employeeId)
    {
        // Find employee
        Employee emp = FindEmployeeById(employees, employeeId);

        // Employee not found
        if (emp == null)
        {
            return -1;
        }

        // CEO level
        if (emp.ManagerId == 0)
        {
            return 1;
        }

        // Find next level recursively
        return 1 + FindLevel(employees, emp.ManagerId);
    }
}