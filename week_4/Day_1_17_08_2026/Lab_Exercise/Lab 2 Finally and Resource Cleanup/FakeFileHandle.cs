using System;

public class FakeFileHandle : IDisposable
{
    // Constructor runs when the resource is created.
    public FakeFileHandle()
    {
        Console.WriteLine("Handle opened");
    }


    // Dispose() is called automatically by using.
    public void Dispose()
    {
        Console.WriteLine("Handle closed");
    }
}