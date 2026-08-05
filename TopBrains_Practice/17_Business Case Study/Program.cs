using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Get employee list
        List<Employee> employees = EmployeeData.GetEmployees();

        // Store user's menu choice
        int choice;

        do
        {
            
            Console.WriteLine("        ABC TECHNOLOGIES");
            Console.WriteLine("Organization Hierarchy Management System");
            

            Console.WriteLine("1. Display Complete Organization Chart");
            Console.WriteLine("2. Find Employee by ID");
            Console.WriteLine("3. Find Employee by Name");
            Console.WriteLine("4. Display Employees under a Manager");
            Console.WriteLine("5. Count Total Employees under a Manager");
            Console.WriteLine("6. Display Hierarchy Level");
            Console.WriteLine("7. Exit");

            Console.Write("\nEnter Your Choice : ");
            choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            switch (choice)
            {
                case 1:

                    // Display CEO
                    foreach (Employee emp in employees)
                    {
                        if (emp.ManagerId == 0)
                        {
                            Console.WriteLine(emp.Name + " (" + emp.Designation + ")");

                            // Display complete hierarchy
                            Organization.DisplayOrganization(
                                employees,
                                emp.EmployeeId,
                                "    ");
                        }
                    }

                    break;

                case 2:

                    // Search employee using ID
                    Console.Write("Enter Employee ID : ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Employee empById =
                        Organization.FindEmployeeById(employees, id);

                    Display.DisplayEmployee(empById);

                    break;

                case 3:

                    // Search employee using Name
                    Console.Write("Enter Employee Name : ");
                    string name = Console.ReadLine();

                    Employee empByName =
                        Organization.FindEmployeeByName(employees, name);

                    Display.DisplayEmployee(empByName);

                    break;

                case 4:

                    // Display employees under manager
                    Console.Write("Enter Manager ID : ");
                    int managerId =
                        Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();

                    Organization.DisplayEmployeesUnderManager(
                        employees,
                        managerId);

                    break;

                case 5:

                    // Count employees under manager
                    Console.Write("Enter Manager ID : ");
                    int managerId2 =
                        Convert.ToInt32(Console.ReadLine());

                    int total =
                        Organization.CountEmployees(
                            employees,
                            managerId2);

                    Console.WriteLine();
                    Console.WriteLine("Total Employees : " + total);

                    break;

                case 6:

                    // Display hierarchy level
                    Console.Write("Enter Employee ID : ");
                    int employeeId =
                        Convert.ToInt32(Console.ReadLine());

                    int level =
                        Organization.FindLevel(
                            employees,
                            employeeId);

                    if (level == -1)
                    {
                        Console.WriteLine("Employee Not Found.");
                    }
                    else
                    {
                        Console.WriteLine("Hierarchy Level : " + level);
                    }

                    break;

                case 7:

                    // Exit application
                    Console.WriteLine("Thank You!");
                    break;

                default:

                    // Invalid menu choice
                    Console.WriteLine("Invalid Choice.");
                    break;
            }

            // Wait before showing menu again
            if (choice != 7)
            {
                Console.WriteLine();
                Console.WriteLine("Press Any Key To Continue...");
                Console.ReadKey();
            }

        } while (choice != 7);
    }
}