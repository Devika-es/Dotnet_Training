using System;
using System.Collections.Generic;
namespace DigitalPettyCash;
class Program
{
    // static void Menu()
    // {
    //     System.Console.WriteLine("Digital Petty Cash");
    //     System.Console.WriteLine("1. Add to Income Ledger");
    //     System.Console.WriteLine("2. Add to Expense Ledger");
    // }
    static void Main()
    {
       
        Ledger<IncomeTransaction> incomeLedger = new Ledger<IncomeTransaction>();
        // do{
        //     Menu();
        //     System.Console.Write("Enter option: ");
        //     int option=Int32.Parse(Console.ReadLine());
        //     switch(option)
        //     {
        //         case 1:
        //             {
        //                 System.Console.Write("enter ID: ");
        //                 incomeLedger.Id=Int32.Parse
        //                 break;
        //             }
        //     }

        incomeLedger.AddEntry(new IncomeTransaction(
            1,
            500,
            "Petty cash replenishment",
            "Main Cash"
        ));

        
        Ledger<ExpenseTransaction> expenseLedger = new Ledger<ExpenseTransaction>();

        expenseLedger.AddEntry(new ExpenseTransaction(
            1,        
            20,
            "Stationary",
            "Office"
        ));

        expenseLedger.AddEntry(new ExpenseTransaction(
            2,
            15,
            "Team Snacks",
            "Food"
        ));

       
        double totalIncome = incomeLedger.CalculateTotal();
        double totalExpense = expenseLedger.CalculateTotal();
        double netBalance = totalIncome - totalExpense;


        List<Transaction> result = new List<Transaction>();
        result.AddRange(incomeLedger.GetAll());
        result.AddRange(expenseLedger.GetAll());

        foreach (Transaction t in result)
        {
            Console.WriteLine(t.GetSummary()); 
        }


        Console.WriteLine($"Total Income  : {totalIncome}");
        Console.WriteLine($"Total Expense : {totalExpense}");
        Console.WriteLine($"Net Balance   : {netBalance}");
    
    // }while(true);
    }
}
