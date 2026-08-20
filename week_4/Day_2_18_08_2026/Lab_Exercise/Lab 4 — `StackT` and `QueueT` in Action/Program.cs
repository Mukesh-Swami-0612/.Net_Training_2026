using System;

class Program
{
    // Summary: Main class that runs both Lab 4 simulations.
    static void Main()
    {
        // 4A - Balanced Parentheses Checker

        Console.WriteLine("===== 4A - BALANCED PARENTHESES CHECKER =====");

        // Test a balanced expression.
        string expression1 = "{[a+(b*c)]-d}";

        Console.WriteLine($"Expression: {expression1}");
        Console.WriteLine(
            $"Balanced: {ParenthesesChecker.IsBalanced(expression1)}"
        );

        Console.WriteLine();

        // Test an unbalanced expression.
        string expression2 = "{[a+(b*c)]-d";

        Console.WriteLine($"Expression: {expression2}");
        Console.WriteLine(
            $"Balanced: {ParenthesesChecker.IsBalanced(expression2)}"
        );


        // 4B - Print Job Queue

        Console.WriteLine();
        Console.WriteLine("===== 4B - PRINT JOB QUEUE =====");

        // Create the printer queue.
        PrinterQueue printer = new PrinterQueue();

        // Add five normal print jobs.
        printer.AddJob(new PrintJob("Report.pdf", 10));
        printer.AddJob(new PrintJob("Assignment.docx", 5));
        printer.AddJob(new PrintJob("Resume.pdf", 3));
        printer.AddJob(new PrintJob("ProjectReport.pdf", 20));
        printer.AddJob(new PrintJob("Notes.txt", 4));

        Console.WriteLine("\nInitial print jobs added.");

        // Add a high-priority print job.
        Console.WriteLine("\nA HIGH-PRIORITY job arrives!");

        printer.AddPriorityJob(
            new PrintJob("Urgent.pdf", 2)
        );

        // Process all print jobs.
        Console.WriteLine("\nProcessing print jobs:");

        printer.ProcessJobs();

       
    }
}