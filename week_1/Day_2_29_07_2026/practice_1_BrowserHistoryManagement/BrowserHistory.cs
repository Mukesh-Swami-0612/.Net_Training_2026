using System;

class BrowserHistory
{
    // Array used to store visited web pages.
    string[] history = new string[10];

    // Points to the most recently visited page.
    int top = -1;

    /// <summary>
    /// Initializes the browser history by adding
    /// a few default web pages.
    /// </summary>
    public BrowserHistory()
    {
        // Add Google to the history.
        VisitPage("google.com");

        // Add YouTube to the history.
        VisitPage("youtube.com");

        // Add GitHub to the history.
        VisitPage("github.com");
    }

    /// <summary>
    /// Adds a new web page to the browser history.
    /// </summary>
    public void VisitPage(string page)
    {
        // Check if the history array is full.
        if (top == history.Length - 1)
        {
            Console.WriteLine("History Full");
            return;
        }

        // Store the new page and move the top pointer.
        history[++top] = page;

        // Display the visited page.
        Console.WriteLine(page + " Visited");
    }

    /// <summary>
    /// Navigates back to the previous page by
    /// removing the current page from history.
    /// </summary>
    public void Back()
    {
        // Check if there is any page in history.
        if (top == -1)
        {
            Console.WriteLine("No History");
            return;
        }

        // Display the page being removed.
        Console.WriteLine("Back From: " + history[top]);

        // Move the top pointer back.
        top--;
    }

    /// <summary>
    /// Displays the currently opened web page.
    /// </summary>
    public void CurrentPage()
    {
        // Check if any page exists.
        if (top == -1)
            Console.WriteLine("No Current Page");
        else
            // Display the current page.
            Console.WriteLine("Current Page: " + history[top]);
    }

    /// <summary>
    /// Displays all visited pages from the
    /// most recent to the oldest.
    /// </summary>
    public void DisplayHistory()
    {
        // Check if history is empty.
        if (top == -1)
        {
            Console.WriteLine("History Empty");
            return;
        }

        // Display the history heading.
        Console.WriteLine("Browser History:");

        // Traverse the history from latest to oldest.
        for (int i = top; i >= 0; i--)
        {
            Console.WriteLine(history[i]);
        }
    }

    /// <summary>
    /// Clears all browser history.
    /// </summary>
    public void ClearHistory()
    {
        // Reset the top pointer.
        top = -1;

        // Display confirmation message.
        Console.WriteLine("History Cleared");
    }

    /// <summary>
    /// Displays the total number of
    /// pages currently stored in history.
    /// </summary>
    public void TotalPages()
    {
        // Display the total pages in history.
        Console.WriteLine("Total Pages: " + (top + 1));
    }
}