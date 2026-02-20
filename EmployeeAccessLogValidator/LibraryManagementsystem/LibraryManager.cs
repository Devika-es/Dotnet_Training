using System;

namespace LibraryManagementsystem;

public class LibraryManager
{
    private Dictionary<string,long[]> memberMap=new Dictionary<string,long[]>();
    public int addMember(string memberId)
    {
        if(memberMap.ContainsKey(memberId))
        {
            return 0;
        }
        memberMap[memberId]=new long[]{0,0,0};
        return 1;
    }
    public int imposeFine(string memberId,long amount)
    {
        if(!memberMap.ContainsKey(memberId))
        {
            return 0;
        }
        
        memberMap[memberId][0]+=amount;
        memberMap[memberId][1]+=amount;
        
        return 1;
    }
    public int payFine(string memberId,long amount)
    {
        if(!memberMap.ContainsKey(memberId))
        {
            return 0;
        }
        else if(amount>memberMap[memberId][0])
        {
            long pay=Math.Min(memberMap[memberId][0],memberMap[memberId][1]);
            memberMap[memberId][0]-=pay;
            memberMap[memberId][2]+=pay;
        }
        else
        {
            
            memberMap[memberId][2]+=amount;
            memberMap[memberId][0]= memberMap[memberId][1]- memberMap[memberId][2];
        }
       
       
        return 1;
    
    }
    public string getDetails(string memberId)
    {
        if(!memberMap.ContainsKey(memberId))
        {
            return "Member Not Found";
        }
        var details=memberMap[memberId];
        return $"{memberId} {details[0]} {details[1]} {details[2]}";
    }
    public int processCommands(int N)
    {
        List<String> detailsList=new List<String>();
        for(int i=0;i<N;i++)
        {
            string input=Console.ReadLine();
            string[] arr=input.Split(" ");
            
            switch(arr[0])
            {
                case "ADD":
                    {
                        addMember(arr[1]);
                        break;
                    }
                case "IMPOSE":
                    {
                        imposeFine(arr[1],long.Parse(arr[2]));
                        break;
                    }
                case "PAY":
                    {
                        payFine(arr[1],long.Parse(arr[2]));
                        break;
                    }
                case "DETAILS":
                    {

                        detailsList.Add(getDetails(arr[1]));
                        break;
                    }
            }
        }
        foreach(var item in detailsList)
        {
            System.Console.WriteLine(item);
        }
        return 1;
    }

}
