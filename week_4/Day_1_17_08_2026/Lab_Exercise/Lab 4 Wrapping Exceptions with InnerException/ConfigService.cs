using System;

class ConfigService
{
    // Reads a raw configuration value.
    // It simulates a low-level configuration failure.
    public static string ReadRawConfigValue(string key)
    {
        // Simulate an invalid timeout value.
        if (key == "timeout")
        {
            throw new FormatException(
                "Value 'abc' is not a valid integer"
            );
        }

        // Return a dummy value for other keys.
        return "dummy-value";
    }


    // Gets the timeout setting and converts it into an integer.
    // It wraps the low-level exception into a higher-level exception.
    public static int GetTimeoutSetting()
    {
        try
        {
            // Read the raw configuration value.
            string raw = ReadRawConfigValue("timeout");

            // Convert the value into an integer.
            return int.Parse(raw);
        }
        catch (FormatException ex)
        {
            // Wrap the original FormatException inside
            // an InvalidOperationException.
            throw new InvalidOperationException(
                "Application configuration is invalid",
                ex
            );
        }
    }
}