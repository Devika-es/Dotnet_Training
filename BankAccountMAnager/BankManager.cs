using System;

namespace BankAccountMAnager;

public class BankManager
{
    private Dictionary<string,long[]> myDict=new Dictionary<string,long[]>();
    
    public int createAccount(string id)
    {
        if(myDict.ContainsKey(id))
        {
            return 0;
        }
        myDict[id]=new long[]{0,0,0};
        return 1;
    }
     public int deposit(string id,long amount)
    {
        if(!myDict.ContainsKey(id))
        {
            return 0;
        }
        myDict[id][1]+=amount;
        myDict[id][0]+=amount;

        return 1;
    }
     public int withdraw(string id,long amount)
    {
        if(!myDict.ContainsKey(id))
        {
            return 0;
        }
        else if(amount<0 || myDict[id][0]<amount)
        {
            return 0;
        }
        myDict[id][2]+=amount;
        myDict[id][0]-=amount;
        return 0;
    }
     public string getDetails(string id)
    {
        if(!myDict.ContainsKey(id))
        {
            return "Account Not Found";
        }
        var details=myDict[id];
        return $"{id} {details[0]} {details[1]} {details[2]}";
    }
     public int processCommands(int N)
    {
         List<String> output=new List<String>();
        for(int i=0;i<N;i++)
        {
            string input=Console.ReadLine();
            var parts=input.Split(" ");
           
            if(parts[0]=="CREATE")
            {
                createAccount(parts[1]);
            }
            else if(parts[0]=="DEPOSIT")
            {
                deposit(parts[1],long.Parse(parts[2]));
            }
            else if(parts[0]=="WITHDRAW")
            {
                withdraw(parts[1],long.Parse(parts[2]));
            }
            else if(parts[0]=="DETAILS")
            {
                output.Add(getDetails(parts[1]));
            }
            
        }
        System.Console.WriteLine(" ");
        foreach(var item in output)
        {
            Console.WriteLine(item);
        }
        return 1;
    }
}
