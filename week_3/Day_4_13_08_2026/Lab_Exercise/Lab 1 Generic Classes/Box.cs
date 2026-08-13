using System;

public class Box<T>
{
    private T _value;

    public Box(T value)
    {
        _value = value;
    }

    public T GetValue()
    {
        return _value;
    }

    public void Replace(T newValue)
    {
        _value = newValue;
    }

    public static Box<T> CreateEmpty<T>() where T : new()
    {
        return new Box<T>(new T());
    }
}