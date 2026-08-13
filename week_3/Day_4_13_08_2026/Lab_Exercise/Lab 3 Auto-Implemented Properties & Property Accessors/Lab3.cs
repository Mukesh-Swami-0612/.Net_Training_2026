using System;

public class Subscription
{
    // Get-only auto-property
    // Can be assigned in the constructor.
    public string Id { get; }

    // Fully get/set auto-property
    public string PlanName { get; set; } = string.Empty;

    // Init-only property
    // Can only be assigned during object initialization.
    public DateTime StartedAt { get; init; }

    // Public get, private set
    // Everyone can read it, but only this class can change it.
    public bool IsActive { get; private set; } = true;

    // Computed expression-bodied property
    // Calculates the number of complete months between StartedAt and now.
    public int MonthsActive =>
        (DateTime.Now.Year - StartedAt.Year) * 12
        + DateTime.Now.Month - StartedAt.Month
        - (DateTime.Now.Day < StartedAt.Day ? 1 : 0);

    // Constructor
    public Subscription(string id)
    {
        Id = id;
    }

    // Changes IsActive using the private setter.
    public void Cancel()
    {
        IsActive = false;
    }
}