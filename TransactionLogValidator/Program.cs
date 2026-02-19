using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace TransactionLogValidator;
public class Program
{
    public static string validateTransaction(string record)
    {
        string pattern=@"^TXN-([1-9]\d{5})\|(\d{4}-\d{2}-\d{2})\|(USD|EUR|INR|GBP|AUD|CAD)\|((0|[1-9]\d{0,5})(\.\d{1,2})?)\|(SUCCESS|FAILED|PENDING)$";
        Match m=Regex.Match(record,pattern);
        if(!m.Success)
        {
            return "INVALID LOG";
        }
        string id=m.Groups[1].Value;
        if(Regex.IsMatch(id,@"(\d)\1\1\1"))
        {
            return "INVALID LOG";
        }
        DateTime dt;
        if(!DateTime.TryParse(m.Groups[2].Value,out dt))
        {
            return "INVALID LOG";
        }
        if(dt.Year<2000 || dt.Year>2999)
        {
            return "INVALID LOG";
        }
        decimal dmt=decimal.Parse(m.Groups[4].Value);
        if(dmt>999999.99m)
        {
            return "INVALID LOG";
        }
        return "VALID LOG";
    }
    public static void Main()
    {
       int n=Int32.Parse(Console.ReadLine());
        List<String> list1=new List<string>();
       for(int i=0;i<n;i++)
        {
            string input=Console.ReadLine();
           
            list1.Add(validateTransaction(input));
        }
       foreach(var item in list1)
        {
            System.Console.WriteLine(item);
        }
    }
}