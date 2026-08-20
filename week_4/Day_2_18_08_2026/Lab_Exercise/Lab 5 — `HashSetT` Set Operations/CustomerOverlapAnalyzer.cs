using System;
using System.Collections.Generic;

/// <summary>
/// Stores customer email sets and performs HashSet set operations.
/// </summary>
public class CustomerOverlapAnalyzer
{
    // Stores customers who subscribed to the newsletter.
    public HashSet<string> NewsletterSubscribers { get; set; }

    // Stores customers who use the application.
    public HashSet<string> AppUsers { get; set; }

    /// <summary>
    /// Initializes the newsletter subscribers and app users with sample data.
    /// </summary>
    public CustomerOverlapAnalyzer()
    {
        // Create the newsletter subscriber HashSet.
        NewsletterSubscribers = new HashSet<string>
        {
            "alice@gmail.com",
            "bob@gmail.com",
            "charlie@gmail.com",
            "david@gmail.com",
            "emma@gmail.com"
        };

        // Create the application user HashSet.
        AppUsers = new HashSet<string>
        {
            "bob@gmail.com",
            "charlie@gmail.com",
            "emma@gmail.com",
            "frank@gmail.com",
            "grace@gmail.com"
        };
    }

    /// <summary>
    /// Returns customers who are both newsletter subscribers and app users.
    /// </summary>
    public HashSet<string> GetCommonCustomers()
    {
        // Create a copy so the original set is not modified.
        HashSet<string> result = new HashSet<string>(NewsletterSubscribers);

        // Keep only customers present in both sets.
        result.IntersectWith(AppUsers);

        // Return the common customers.
        return result;
    }

    /// <summary>
    /// Returns newsletter subscribers who are not app users.
    /// </summary>
    public HashSet<string> GetNewsletterOnlyCustomers()
    {
        // Create a copy so the original set is not modified.
        HashSet<string> result = new HashSet<string>(NewsletterSubscribers);

        // Remove customers who are also app users.
        result.ExceptWith(AppUsers);

        // Return newsletter-only customers.
        return result;
    }

    /// <summary>
    /// Returns all unique customers from both customer sets.
    /// </summary>
    public HashSet<string> GetAllCustomers()
    {
        // Create a copy so the original set is not modified.
        HashSet<string> result = new HashSet<string>(NewsletterSubscribers);

        // Add all app users while automatically removing duplicates.
        result.UnionWith(AppUsers);

        // Return all unique customers.
        return result;
    }

    /// <summary>
    /// Checks whether all newsletter subscribers are also app users.
    /// </summary>
    public bool AreNewsletterSubscribersSubsetOfAppUsers()
    {
        // Check whether NewsletterSubscribers is a subset of AppUsers.
        return NewsletterSubscribers.IsSubsetOf(AppUsers);
    }

    /// <summary>
    /// Converts a list of emails into a HashSet to remove duplicates.
    /// </summary>
    public HashSet<string> RemoveDuplicates(List<string> emails)
    {
        // HashSet automatically removes duplicate email addresses.
        return new HashSet<string>(emails);
    }
}