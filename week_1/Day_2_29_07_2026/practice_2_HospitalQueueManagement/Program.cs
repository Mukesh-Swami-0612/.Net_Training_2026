using System;

class Program
{
    /// <summary>
    /// Entry point of the Hospital Queue Management application.
    /// Displays a menu to register patients, call the next patient,
    /// view waiting patients, search for a patient,
    /// count waiting patients, and exit the application.
    /// </summary>
    static void Main()
    {
        // Create an object of the HospitalQueue class.
        HospitalQueue h = new HospitalQueue();

        // Variable to store the user's menu choice.
        int choice;

        // Repeat the menu until the user chooses to exit.
        do
        {
            // Display the menu options.
            Console.WriteLine("\n===== ABC Hospital Queue Management =====");
            Console.WriteLine("1. Register Patient");
            Console.WriteLine("2. Call Next Patient");
            Console.WriteLine("3. View Next Patient");
            Console.WriteLine("4. Display Waiting Patients");
            Console.WriteLine("5. Search Patient");
            Console.WriteLine("6. Count Waiting Patients");
            Console.WriteLine("7. Exit");
            Console.Write("Enter Choice: ");

            // Read the user's choice.
            choice = Convert.ToInt32(Console.ReadLine());

            // Perform the selected operation.
            switch (choice)
            {
                case 1:
                    // Read the patient's name and register them.
                    Console.Write("Enter Patient Name: ");
                    string name = Console.ReadLine();
                    h.RegisterPatient(name);
                    break;

                case 2:
                    // Call the next patient.
                    h.CallNextPatient();
                    break;

                case 3:
                    // Display the next waiting patient.
                    h.ViewNextPatient();
                    break;

                case 4:
                    // Display all waiting patients.
                    h.DisplayPatients();
                    break;

                case 5:
                    // Read the patient's name and search for them.
                    Console.Write("Enter Patient Name: ");
                    string search = Console.ReadLine();
                    h.SearchPatient(search);
                    break;

                case 6:
                    // Display the total number of waiting patients.
                    h.CountPatients();
                    break;

                case 7:
                    // Exit the application.
                    Console.WriteLine("Thank You");
                    break;

                default:
                    // Handle an invalid menu choice.
                    Console.WriteLine("Invalid Choice");
                    break;
            }

        } while (choice != 7); // Continue until Exit is selected.
    }
}