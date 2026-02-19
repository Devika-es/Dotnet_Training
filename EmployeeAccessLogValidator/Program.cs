using System;
using System.Text.RegularExpressions;
namespace EmployeeAccessLogValidator;
public class Program
{
    public static string validateEmployee(string id)
    {
        string pattern=@"^EMP-([A-Z]{5})\|(\d{4}-\d{2}-\d{2})\|([01]\d|2[0-3]):[0-5]\d\|(HR|IT|FINANCE|ADMIN|SALES)\|(LEVEL1|LEVEL2|LEVEL3)$";
        Match m=Regex.Match(id,pattern);
        if(!m.Success)
        {
            return "INVALID LOG";
        }
        string string1=m.Groups[1].Value;
        if(Regex.IsMatch(string1,@"([A-Z])\1\1"))
        {
            return "INVALID LOG";
        }
        DateTime dt;
        if(!DateTime.TryParse(m.Groups[2].Value,out dt))
        {
            return "INVALID LOG";
        }
        if(dt.Year<2010 || dt.Year>2025)
        {
            return "INVALID LOG";
        }
        
        return "VALID LOG";
    }
    public static void Main()
    {
       int n=Int32.Parse(Console.ReadLine());
       List<String> list1=new List<String>();
       for(int i=0;i<n;i++)
        {
            string input=Console.ReadLine();
            list1.Add(validateEmployee(input));
        }
       foreach(var item in list1)
        {
            System.Console.WriteLine(item);
        }
    }
}