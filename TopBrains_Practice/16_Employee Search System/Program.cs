using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Get employee list
        List<Employee> employees = EmployeeData.GetEmployees();

        int choice;

        do
        {
            Console.WriteLine(" Employee Search Management System");
            

            Console.WriteLine("1. Display All Employees");
            Console.WriteLine("2. Search by Employee ID (Linear Search)");
            Console.WriteLine("3. Search by Employee ID (Binary Search)");
            Console.WriteLine("4. Search by Employee Name");
            Console.WriteLine("5. Search by Department");
            Console.WriteLine("6. Search by City");
            Console.WriteLine("7. Search by Experience");
            Console.WriteLine("8. Search by Salary Range");
            Console.WriteLine("9. Exit");

            Console.Write("\nEnter your choice : ");
            choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            switch (choice)
            {
                case 1:

                    // Display all employees
                    Display.DisplayEmployees(employees);

                    break;

                case 2:

                    // Search employee using Linear Search

                    Console.Write("Enter Employee ID : ");
                    int id1 = Convert.ToInt32(Console.ReadLine());

                    Employee emp1 = Search.LinearSearch(employees, id1);

                    Display.DisplayEmployee(emp1);

                    break;

                case 3:

                    // Search employee using Binary Search

                    Console.Write("Enter Employee ID : ");
                    int id2 = Convert.ToInt32(Console.ReadLine());

                    Employee emp2 = Search.BinarySearch(employees, id2);

                    Display.DisplayEmployee(emp2);

                    break;

                case 4:

                    // Search by Name

                    Console.Write("Enter Employee Name : ");
                    string name = Console.ReadLine();

                    List<Employee> nameList = Search.SearchByName(employees, name);

                    Display.DisplayEmployees(nameList);

                    break;

                case 5:

                    // Search by Department

                    Console.Write("Enter Department : ");
                    string department = Console.ReadLine();

                    List<Employee> departmentList =
                        Search.SearchByDepartment(employees, department);

                    Display.DisplayEmployees(departmentList);

                    break;

                case 6:

                    // Search by City

                    Console.Write("Enter City : ");
                    string city = Console.ReadLine();

                    List<Employee> cityList =
                        Search.SearchByCity(employees, city);

                    Display.DisplayEmployees(cityList);

                    break;

                case 7:

                    // Search by Experience

                    Console.Write("Enter Experience (Years) : ");
                    int experience = Convert.ToInt32(Console.ReadLine());

                    List<Employee> experienceList =
                        Search.SearchByExperience(employees, experience);

                    Display.DisplayEmployees(experienceList);

                    break;

                case 8:

                    // Search by Salary Range

                    Console.Write("Enter Minimum Salary : ");
                    double minSalary = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter Maximum Salary : ");
                    double maxSalary = Convert.ToDouble(Console.ReadLine());

                    List<Employee> salaryList =
                        Search.SearchBySalary(employees, minSalary, maxSalary);

                    Display.DisplayEmployees(salaryList);

                    break;

                case 9:

                    // Exit program

                    Console.WriteLine("Thank You!");
                    break;

                default:

                    // Invalid choice

                    Console.WriteLine("Invalid Choice!");
                    break;
            }

            // Wait before showing menu again
            if (choice != 9)
            {
                Console.WriteLine();
                Console.WriteLine("Press Any Key To Continue...");
                Console.ReadKey();
            }

        } while (choice != 9);
    }
}