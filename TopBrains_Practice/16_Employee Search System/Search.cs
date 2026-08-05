using System;
using System.Collections.Generic;

/// <summary>
/// This class contains different search methods.
/// </summary>
class Search
{
    /// <summary>
    /// Searches employee using Linear Search.
    /// </summary>
    public static Employee LinearSearch(List<Employee> employees, int id)
    {
        // Check each employee one by one
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
    /// Searches employee using Binary Search.
    /// </summary>
    public static Employee BinarySearch(List<Employee> employees, int id)
    {
        // Sort the list by Employee ID
        employees.Sort((a, b) => a.EmployeeId.CompareTo(b.EmployeeId));

        int low = 0;
        int high = employees.Count - 1;

        // Repeat until search is complete
        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (employees[mid].EmployeeId == id)
            {
                return employees[mid];
            }
            else if (id < employees[mid].EmployeeId)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }

        // Employee not found
        return null;
    }

    /// <summary>
    /// Searches employees by name.
    /// </summary>
    public static List<Employee> SearchByName(List<Employee> employees, string name)
    {
        List<Employee> result = new List<Employee>();

        // Compare entered name with employee names
        foreach (Employee emp in employees)
        {
            if (emp.Name.ToLower().Contains(name.ToLower()))
            {
                result.Add(emp);
            }
        }

        return result;
    }

    /// <summary>
    /// Searches employees by department.
    /// </summary>
    public static List<Employee> SearchByDepartment(List<Employee> employees, string department)
    {
        List<Employee> result = new List<Employee>();

        // Check department
        foreach (Employee emp in employees)
        {
            if (emp.Department.ToLower() == department.ToLower())
            {
                result.Add(emp);
            }
        }

        return result;
    }

    /// <summary>
    /// Searches employees by city.
    /// </summary>
    public static List<Employee> SearchByCity(List<Employee> employees, string city)
    {
        List<Employee> result = new List<Employee>();

        // Check city
        foreach (Employee emp in employees)
        {
            if (emp.City.ToLower() == city.ToLower())
            {
                result.Add(emp);
            }
        }

        return result;
    }

    /// <summary>
    /// Searches employees by experience.
    /// </summary>
    public static List<Employee> SearchByExperience(List<Employee> employees, int experience)
    {
        List<Employee> result = new List<Employee>();

        // Check experience
        foreach (Employee emp in employees)
        {
            if (emp.Experience == experience)
            {
                result.Add(emp);
            }
        }

        return result;
    }

    /// <summary>
    /// Searches employees within a salary range.
    /// </summary>
    public static List<Employee> SearchBySalary(List<Employee> employees, double minSalary, double maxSalary)
    {
        List<Employee> result = new List<Employee>();

        // Check salary range
        foreach (Employee emp in employees)
        {
            if (emp.Salary >= minSalary && emp.Salary <= maxSalary)
            {
                result.Add(emp);
            }
        }

        return result;
    }
}