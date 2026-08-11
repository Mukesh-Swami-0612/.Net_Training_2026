using System;
using System.Text;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Raw employee data
        const string rawData = @"
john smith|engineering|72000
MARY jones|sales|65000

ravi KUMAR|engineering|81000
";

        // Split the raw data into separate rows
        string[] rows = rawData.Split('\n');

        // List to store employee objects
        List<Employee> employees = new List<Employee>();

        // Read each row
        foreach (string row in rows)
        {
            // Skip blank rows
            if (string.IsNullOrWhiteSpace(row))
            {
                continue;
            }

            // Split the row into Name, Department, and Salary
            string[] fields = row.Trim().Split('|');

            // Create an Employee object
            string name = fields[0];
            string department = fields[1];
            decimal salary = decimal.Parse(fields[2]);

            employees.Add(new Employee(name, department, salary));
        }

        // Create StringBuilder for the final report
        StringBuilder sb = new StringBuilder();

        // Keep track of Append calls
        int appendCalls = 0;

        // Add report title
        sb.AppendLine("EMPLOYEE COMPENSATION REPORT");
        appendCalls++;

        // Add separator
        sb.AppendLine("--");
        appendCalls++;

        // Add table header
        sb.AppendLine(
            "Name".PadRight(20) +
            "Department".PadRight(20) +
            "Salary".PadLeft(12)
        );
        appendCalls++;

        // Add another separator
        sb.AppendLine("--");
        appendCalls++;

        decimal totalSalary = 0;

        // Add each employee to the report
        foreach (Employee employee in employees)
        {
            // Normalize employee name using StringToolkit
            string formattedName = StringToolkit.ToTitleCase(employee.Name);

            // Format one employee line
            string employeeLine =
                formattedName.PadRight(20) +
                employee.Department.PadRight(20) +
                employee.Salary.ToString("N0").PadLeft(12);

            // Add employee line
            sb.AppendLine(employeeLine);
            appendCalls++;

            // Add salary to total
            totalSalary += employee.Salary;
        }

        // Add separator before footer
        sb.AppendLine("--");
        appendCalls++;

        // Add employee count and total salary
        sb.AppendLine(
            $"# Employees: {employees.Count}    Total Salary: {totalSalary:N0}"
        );
        appendCalls++;

        // Print the complete report
        Console.WriteLine(sb.ToString());

        // Print StringBuilder and concatenation information
        Console.WriteLine($"StringBuilder Append calls: {appendCalls}");
        Console.WriteLine("String concatenations using += inside loop: 0");
    }
}