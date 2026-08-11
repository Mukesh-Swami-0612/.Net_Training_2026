using System;

public class Appointment
{
    // Read-only properties
    public string Title { get; }
    public DateTime Start { get; }
    public TimeSpan Duration { get; }
    public string Location { get; }

    // Static variable shared by all Appointment objects
    public static int DefaultDurationMinutes;

    /// <summary>
    /// Static constructor runs only once when the Appointment
    /// type is used for the first time.
    /// </summary>
    static Appointment()
    {
        Console.WriteLine(
            "Appointment type initialized. Default duration set to 30 minutes."
        );

        DefaultDurationMinutes = 30;
    }

    /// <summary>
    /// Full constructor that initializes all appointment details.
    /// </summary>
    public Appointment(
        string title,
        DateTime start,
        TimeSpan duration,
        string location)
    {
        Title = title;
        Start = start;
        Duration = duration;
        Location = location;
    }

    /// <summary>
    /// Constructor that takes title and start time.
    /// It uses the full constructor with default duration and location.
    /// </summary>
    public Appointment(string title, DateTime start)
        : this(
            title,
            start,
            TimeSpan.FromMinutes(DefaultDurationMinutes),
            "TBD")
    {
    }

    /// <summary>
    /// Constructor that takes only the appointment title.
    /// It uses the two-argument constructor and sets the start
    /// time to tomorrow.
    /// </summary>
    public Appointment(string title)
        : this(title, DateTime.Now.AddDays(1))
    {
    }

    /// <summary>
    /// Creates a copy of an existing appointment and moves it
    /// one day forward.
    /// </summary>
    public Appointment(Appointment appointment)
        : this(
            appointment.Title,
            appointment.Start.AddDays(1),
            appointment.Duration,
            appointment.Location)
    {
    }
}