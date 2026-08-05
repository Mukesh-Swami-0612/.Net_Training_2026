using System;

/// <summary>
/// Represents an employee in the organization.
/// Stores employee information such as ID, Name,
/// Designation, Department and Manager ID.
/// </summary>
class Employee
{
    // Employee ID
    public int EmployeeId;

    // Employee Name
    public string Name;

    // Employee Designation
    public string Designation;

    // Employee Department
    public string Department;

    // Manager ID
    // 0 means CEO (No Manager)
    public int ManagerId;

    /// <summary>
    /// Initializes a new Employee object with all employee details.
    /// </summary>
    public Employee(
        int employeeId,
        string name,
        string designation,
        string department,
        int managerId)
    {
        EmployeeId = employeeId;
        Name = name;
        Designation = designation;
        Department = department;
        ManagerId = managerId;
    }
}