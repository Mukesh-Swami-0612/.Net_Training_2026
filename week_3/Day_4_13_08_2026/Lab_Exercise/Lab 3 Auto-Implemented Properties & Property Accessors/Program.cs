using System;

class Program
{
    static void Main()
    {
        Subscription subscription = new Subscription("SUB-1")
        {
            PlanName = "Pro",
            StartedAt = new DateTime(2026, 1, 1)
        };

        Console.WriteLine($"Id={subscription.Id}");
        Console.WriteLine($"Plan={subscription.PlanName}");
        Console.WriteLine($"Started={subscription.StartedAt:yyyy-MM-dd}");
        Console.WriteLine($"Active={subscription.IsActive}");
        Console.WriteLine($"MonthsActive={subscription.MonthsActive}");

        subscription.Cancel();

        Console.WriteLine($"After Cancel(): Active={subscription.IsActive}");

    }
}