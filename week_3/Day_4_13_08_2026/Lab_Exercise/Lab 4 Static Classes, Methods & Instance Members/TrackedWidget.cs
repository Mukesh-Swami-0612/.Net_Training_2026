using System;

public class TrackedWidget
{
    public Guid InstanceId { get; }

    public static int LiveCount { get; private set; }

    public TrackedWidget()
    {
        InstanceId = Guid.NewGuid();

        LiveCount++;
    }

    public void Dispose()
    {
        LiveCount--;
    }

    public void PrintInfo()
    {
        Console.WriteLine(
            $"Widget {InstanceId}: LiveCount={LiveCount}"
        );
    }
}