using System;

// Interface for common vehicle behavior
public interface IVehicle
{
    // Read-only property
    string Model { get; }

    // Method for driving
    void Drive();
}

// Interface for electric vehicle behavior
public interface IElectric
{
    // Property for battery percentage
    int BatteryPercent { get; set; }

    // Method for charging
    void Charge();
}

// Combines both vehicle and electric contracts
public interface IElectricVehicle : IVehicle, IElectric
{
}

// ElectricCar implements both interfaces through IElectricVehicle
public class ElectricCar : IElectricVehicle
{
    // Private backing field for battery
    private int _batteryPercent;

    // Model can only be assigned during object creation
    public string Model { get; init; }

    // BatteryPercent property
    public int BatteryPercent
    {
        get
        {
            return _batteryPercent;
        }
        set
        {
            // Clamp value between 0 and 100
            if (value < 0)
            {
                _batteryPercent = 0;
            }
            else if (value > 100)
            {
                _batteryPercent = 100;
            }
            else
            {
                _batteryPercent = value;
            }
        }
    }

    /// <summary>
    /// Drives the electric car and reduces battery by 10%.
    /// </summary>
    public void Drive()
    {
        // Reduce battery by 10
        BatteryPercent -= 10;

        // BatteryPercent property prevents it from going below 0
    }

    /// <summary>
    /// Charges the battery completely.
    /// </summary>
    public void Charge()
    {
        // Set battery to 100%
        BatteryPercent = 100;
    }
}