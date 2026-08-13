using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Represents a generic notification channel.
/// </summary>
public abstract class NotificationChannel
{
    /// <summary>
    /// Sends a message safely.
    /// Returns false if any exception occurs.
    /// </summary>
    public bool TrySend(string message)
    {
        try
        {
            return Send(message);
        }
        catch
        {
            return false;
        }
    }

    /// <summary>
    /// Sends the message.
    /// Must be implemented by derived classes.
    /// </summary>
    protected abstract bool Send(string message);
}

/// <summary>
/// Represents an Email notification channel.
/// </summary>
public class EmailChannel : NotificationChannel
{
    /// <summary>
    /// Sends an email.
    /// Email always succeeds.
    /// </summary>
    protected override bool Send(string message)
    {
        return true;
    }
}

/// <summary>
/// Represents an SMS notification channel.
/// </summary>
public class SmsChannel : NotificationChannel
{
    /// <summary>
    /// Sends an SMS.
    /// Throws an exception if the message exceeds 160 characters.
    /// </summary>
    protected override bool Send(string message)
    {
        if (message.Length > 160)
        {
            throw new Exception("SMS message is too long.");
        }

        return true;
    }
}

/// <summary>
/// Driver class.
/// </summary>
public class Program
{
    /// <summary>
    /// Application entry point.
    /// </summary>
    public static void Main()
    {
        // Create notification channels
        List<NotificationChannel> channels = CreateChannels();

        // Short message
        Console.WriteLine("----- Short Message -----");
        ProcessNotifications(channels, "Hello! Welcome.");

        Console.WriteLine();

        // Long message (more than 160 characters)
        string longMessage = new string('A', 170);

        Console.WriteLine("----- Long Message -----");
        ProcessNotifications(channels, longMessage);
    }

    /// <summary>
    /// Creates and returns a list of notification channels.
    /// </summary>
    static List<NotificationChannel> CreateChannels()
    {
        return new List<NotificationChannel>
        {
            new EmailChannel(),
            new SmsChannel(),
            new EmailChannel(),
            new SmsChannel()
        };
    }

    /// <summary>
    /// Sends the given message through all channels
    /// and prints the report.
    /// </summary>
    static void ProcessNotifications(List<NotificationChannel> channels, string message)
    {
        // Create anonymous-type report using LINQ
        var report = channels.Select(channel => new
        {
            ChannelType = channel.GetType().Name,
            Success = channel.TrySend(message)
        });

        // Print each result
        foreach (var item in report)
        {
            Console.WriteLine($"{item.ChannelType}: {(item.Success ? "Success" : "Failed")}");
        }

        // Count successful sends
        int successCount = report.Count(x => x.Success);

        // Count failed sends
        int failedCount = report.Count(x => !x.Success);

        // Print summary
        Console.WriteLine();
        Console.WriteLine($"Succeeded: {successCount}, Failed: {failedCount}");
    }
}