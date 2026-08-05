using System;

/// <summary>
/// This class stores employee information.
/// </summary>
class Employee
{
    // Employee ID
    public int EmployeeId;

    // Employee Name
    public string Name;

    // Department Name
    public string Department;

    // Employee Designation
    public string Designation;

    // Years of Experience
    public int Experience;

    // Employee Salary
    public double Salary;

    // Employee City
    public string City;

    /// <summary>
    /// Constructor to initialize employee details.
    /// </summary>
    public Employee(
        int employeeId,
        string name,
        string department,
        string designation,
        int experience,
        double salary,
        string city)
    {
        EmployeeId = employeeId;
        Name = name;
        Department = department;
        Designation = designation;
        Experience = experience;
        Salary = salary;
        City = city;
    }
}