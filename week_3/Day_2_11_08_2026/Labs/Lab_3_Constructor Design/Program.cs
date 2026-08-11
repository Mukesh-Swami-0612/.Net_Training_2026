using System;

public class Program
{
    /// <summary>
    /// Main method where the program starts.
    /// Demonstrates constructor overloading and constructor chaining.
    /// </summary>
    public static void Main()
    {
       
        // 1. Full constructor
        Appointment fullAppointment = new Appointment(
            "Standup",
            new DateTime(2026, 8, 12, 9, 0, 0),
            TimeSpan.FromMinutes(30),
            "Room 4"
        );

        Console.WriteLine(
            $"Full: {fullAppointment.Title} @ " +
            $"{fullAppointment.Start:yyyy-MM-dd HH:mm}, " +
            $"{fullAppointment.Duration.TotalMinutes:0} min, " +
            $"{fullAppointment.Location}"
        );


        // 2. Two-argument constructor
        Appointment twoArgAppointment = new Appointment(
            "Client Call",
            new DateTime(2026, 8, 12, 14, 0, 0)
        );

        Console.WriteLine(
            $"Two-arg: {twoArgAppointment.Title} @ " +
            $"{twoArgAppointment.Start:yyyy-MM-dd HH:mm}, " +
            $"{twoArgAppointment.Duration.TotalMinutes:0} min, " +
            $"{twoArgAppointment.Location}"
        );


        // 3. One-argument constructor

        Appointment oneArgAppointment = new Appointment(
            "Follow Up"
        );

        Console.WriteLine(
            $"One-arg: {oneArgAppointment.Title} @ " +
            $"{oneArgAppointment.Start:yyyy-MM-dd}, " +
            $"{oneArgAppointment.Duration.TotalMinutes:0} min, " +
            $"{oneArgAppointment.Location}"
        );


        // Display static field
        Console.WriteLine(
            $"DefaultDurationMinutes: {Appointment.DefaultDurationMinutes}"
        );

        // 4. Bonus - clone and reschedule

        Appointment clonedAppointment =
            new Appointment(fullAppointment);

        Console.WriteLine();

        Console.WriteLine(
            $"Bonus: {clonedAppointment.Title} @ " +
            $"{clonedAppointment.Start:yyyy-MM-dd HH:mm}, " +
            $"{clonedAppointment.Duration.TotalMinutes:0} min, " +
            $"{clonedAppointment.Location}"
        );
    }
}