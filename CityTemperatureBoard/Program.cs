using System;
using System.Collections.Generic;
namespace CityTemperatureBoard;
class Program
{
    static void Main()
    {
        Dictionary<string, int> temperature = new Dictionary<string, int>
        {
            { "Chennai", 38 },
            { "Delhi", 41 },
            { "Bengaluru", 29 }
        };

        // TODO: Iterate and find max temperature city
        var hottest=temperature.MaxBy(p=>p.Value);
        Console.WriteLine($"{hottest.Key} - {hottest.Value}");
    }
}