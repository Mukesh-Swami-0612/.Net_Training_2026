using System;

class Program
{
    /// <summary>
    /// Entry point of the Browser History application.
    /// Displays a menu to perform browser history operations
    /// such as visiting pages, going back, viewing history,
    /// clearing history, and counting total pages.
    /// </summary>
    static void Main()
    {
        // Create an object of the BrowserHistory class.
        BrowserHistory b = new BrowserHistory();

        // Variable to store the user's menu choice.
        int choice;

        // Repeat the menu until the user chooses to exit.
        do
        {
            // Display the menu options.
            Console.WriteLine("\n===== Browser History System =====");
            Console.WriteLine("1. Visit Page");
            Console.WriteLine("2. Back");
            Console.WriteLine("3. Current Page");
            Console.WriteLine("4. Display History");
            Console.WriteLine("5. Clear History");
            Console.WriteLine("6. Total Pages");
            Console.WriteLine("7. Exit");
            Console.Write("Enter Choice: ");

            // Read the user's choice.
            choice = Convert.ToInt32(Console.ReadLine());

            // Perform the selected operation.
            switch (choice)
            {
                case 1:
                    // Read the page name and visit it.
                    Console.Write("Enter Page Name: ");
                    string page = Console.ReadLine();
                    b.VisitPage(page);
                    break;

                case 2:
                    // Go back to the previous page.
                    b.Back();
                    break;

                case 3:
                    // Display the current page.
                    b.CurrentPage();
                    break;

                case 4:
                    // Display the browser history.
                    b.DisplayHistory();
                    break;

                case 5:
                    // Clear the browser history.
                    b.ClearHistory();
                    break;

                case 6:
                    // Display the total number of pages.
                    b.TotalPages();
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