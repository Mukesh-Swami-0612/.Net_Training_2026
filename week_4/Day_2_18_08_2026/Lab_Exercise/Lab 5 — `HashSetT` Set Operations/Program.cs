using System;
using System.Collections.Generic;

/// <summary>
/// Runs the Customer Overlap Analyzer and displays all HashSet operations.
/// </summary>
class Program
{
    /// <summary>
    /// Starts the application and prints the calculated customer sets.
    /// </summary>
    static void Main()
    {
        // Create the CustomerOverlapAnalyzer object.
        CustomerOverlapAnalyzer analyzer = new CustomerOverlapAnalyzer();

        // Get customers who are present in both groups.
        HashSet<string> commonCustomers =
            analyzer.GetCommonCustomers();

        // Display the common customers.
        Console.WriteLine("=== Customers in Both Groups ===");

        foreach (string email in commonCustomers)
        {
            // Print each common customer email.
            Console.WriteLine(email);
        }

        // Get newsletter subscribers who are not app users.
        HashSet<string> newsletterOnly =
            analyzer.GetNewsletterOnlyCustomers();

        // Display newsletter-only customers.
        Console.WriteLine("\n=== Newsletter Subscribers Only ===");

        foreach (string email in newsletterOnly)
        {
            // Print each newsletter-only customer email.
            Console.WriteLine(email);
        }

        // Get all unique customers from both groups.
        HashSet<string> allCustomers =
            analyzer.GetAllCustomers();

        // Display all unique customers.
        Console.WriteLine("\n=== All Unique Customers ===");

        foreach (string email in allCustomers)
        {
            // Print each unique customer email.
            Console.WriteLine(email);
        }

        // Check whether newsletter subscribers are a subset of app users.
        bool isSubset =
            analyzer.AreNewsletterSubscribersSubsetOfAppUsers();

        // Display the subset result.
        Console.WriteLine(
            "\n=== Is NewsletterSubscribers a Subset of AppUsers? ===");

        Console.WriteLine(isSubset);

        // Create a list for 100 randomly generated emails.
        List<string> randomEmails = new List<string>();

        // Create a Random object for generating customer numbers.
        Random random = new Random();

        // Generate 100 emails.
        // Only 70 possible customer numbers are used intentionally,
        // which creates duplicate email addresses.
        for (int i = 0; i < 100; i++)
        {
            // Generate a customer number between 1 and 70.
            int customerNumber = random.Next(1, 71);

            // Create the email using the generated customer number.
            randomEmails.Add(
                $"customer{customerNumber}@gmail.com"
            );
        }

        // Convert the list into a HashSet to remove duplicates.
        HashSet<string> uniqueEmails =
            analyzer.RemoveDuplicates(randomEmails);

        // Calculate how many duplicate emails were removed.
        int duplicatesRemoved =
            randomEmails.Count - uniqueEmails.Count;

        // Display the duplicate removal results.
        Console.WriteLine("\n=== Duplicate Removal ===");

        // Display the original number of emails.
        Console.WriteLine(
            $"Original emails: {randomEmails.Count}");

        // Display the number of unique emails.
        Console.WriteLine(
            $"Unique emails: {uniqueEmails.Count}");

        // Display the number of duplicates removed.
        Console.WriteLine(
            $"Duplicates removed: {duplicatesRemoved}");
    }
}