using System.Collections.Generic;

/// <summary>
/// Stores the default employee data.
/// </summary>
class EmployeeData
{
    /// <summary>
    /// Returns the list of all employees.
    /// </summary>
    public static List<Employee> GetEmployees()
    {
        // Create employee list
        List<Employee> employees = new List<Employee>();

        // CEO
        employees.Add(new Employee(1001, "John Smith", "CEO", "Management", 0));

        // Managers
        employees.Add(new Employee(1002, "Michael Johnson", "IT Manager", "IT", 1001));
        employees.Add(new Employee(1003, "Sarah Williams", "HR Manager", "HR", 1001));
        employees.Add(new Employee(1004, "David Brown", "Finance Manager", "Finance", 1001));

        // IT Department
        employees.Add(new Employee(1005, "Robert Davis", "Team Lead", "IT", 1002));
        employees.Add(new Employee(1006, "Jennifer Miller", "QA Lead", "IT", 1002));
        employees.Add(new Employee(1007, "William Wilson", "Senior Developer", "IT", 1005));
        employees.Add(new Employee(1008, "Emma Moore", "Senior Developer", "IT", 1005));
        employees.Add(new Employee(1009, "Daniel Taylor", "QA Engineer", "IT", 1006));
        employees.Add(new Employee(1010, "Sophia Anderson", "QA Engineer", "IT", 1006));

        // HR Department
        employees.Add(new Employee(1011, "James Thomas", "Recruiter", "HR", 1003));
        employees.Add(new Employee(1012, "Olivia Jackson", "Recruiter", "HR", 1003));

        // Finance Department
        employees.Add(new Employee(1013, "Benjamin White", "Accountant", "Finance", 1004));
        employees.Add(new Employee(1014, "Charlotte Harris", "Accountant", "Finance", 1004));

        // Developers
        employees.Add(new Employee(1015, "Lucas Martin", "Developer", "IT", 1007));
        employees.Add(new Employee(1016, "Ethan Walker", "Developer", "IT", 1007));
        employees.Add(new Employee(1017, "Mia Hall", "UI Developer", "IT", 1008));
        employees.Add(new Employee(1018, "Alexander Young", "Business Analyst", "IT", 1005));

        // HR Executive
        employees.Add(new Employee(1019, "Harper King", "HR Executive", "HR", 1011));

        // Finance Executive
        employees.Add(new Employee(1020, "Jack Scott", "Finance Executive", "Finance", 1013));

        // Return employee list
        return employees;
    }
}