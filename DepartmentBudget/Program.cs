using System;
using System.Collections.Generic;
namespace DepartmentBudget;
class Program
{
    static void Main()
    {
        Dictionary<string, double> budget = new Dictionary<string, double>
        {
            { "IT", 12.5 },
            { "HR", 6.2 },
            { "Finance", 9.1 }
        };

        // TODO: Calculate and print total budget
       Console.WriteLine($"Total Budget: {budget.Sum(p=>p.Value):F2}");
    }
}