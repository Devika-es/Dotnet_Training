using System.Collections.Generic;

namespace BankAccountMAnager;
public class Program
{
   
    public static void Main()
    {
        
        int N=Int32.Parse(Console.ReadLine());
        BankManager manager=new BankManager();
        manager.processCommands(N);
    }
}