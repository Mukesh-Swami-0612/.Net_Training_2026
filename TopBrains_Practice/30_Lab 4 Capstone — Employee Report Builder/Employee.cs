// Represents an employee
class Employee
{
    // Name property
    public string Name { get; set; }

    // Department property
    public string Department { get; set; }

    // Salary property
    public decimal Salary { get; set; }


    // Constructor
    public Employee(string name, string department, decimal salary)
    {
        Name = name;
        Department = department;
        Salary = salary;
    }
}