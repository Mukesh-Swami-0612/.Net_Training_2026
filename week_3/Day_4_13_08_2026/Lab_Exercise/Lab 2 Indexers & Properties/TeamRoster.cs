using System;
using System.Collections.Generic;

public class TeamRoster
{
    private readonly Dictionary<string, int> _numbers = new();

    public int this[string playerName]
    {
        get
        {
            if (_numbers.TryGetValue(playerName, out int number))
            {
                return number;
            }

            return -1;
        }
        set
        {
            _numbers[playerName] = value;
        }
    }
}