using System;

public class Program
{
    /// <summary>
    /// Main method where the application starts.
    /// </summary>
    public static void Main()
    {
        // Create an ElectricCar
        ElectricCar car = new ElectricCar
        {
            Model = "Tesla Model 3",
            BatteryPercent = 100
        };

        // Drive the car three times
        car.Drive();
        Console.WriteLine($"Battery after drive 1: {car.BatteryPercent}%");

        car.Drive();
        Console.WriteLine($"Battery after drive 2: {car.BatteryPercent}%");

        car.Drive();
        Console.WriteLine($"Battery after drive 3: {car.BatteryPercent}%");

        // Charge the car
        car.Charge();
        Console.WriteLine($"Battery after charge: {car.BatteryPercent}%");

        // Treat the same object as an IVehicle
        IVehicle vehicle = car;

        // IVehicle can access Model and Drive
        Console.WriteLine($"As IVehicle - Model: {vehicle.Model}");

        // Treat the same object as an IElectric
        IElectric electric = car;

        // IElectric can access BatteryPercent and Charge
        Console.WriteLine(
            $"As IElectric - BatteryPercent: {electric.BatteryPercent}%"
        );
    }
}