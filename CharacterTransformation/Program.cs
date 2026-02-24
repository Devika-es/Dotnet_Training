namespace CharacterTransformation;
public class Program
{
    public static string TransformString(string input)
    {
        int length=input.Length;
        if(length<=4)
        {
            return "The string "+input+" has minimum length";
        }
        else if(input.Contains(" "))
        {
            return "The string "+input+" should not contain space";
        }
        string result="";
        foreach(char c in input)
        {
            char newchar=(char)((int)c-length);
            result+=newchar;
        }
        return result;
    }
    public static void Main()
    {
        System.Console.Write("Enter Input: ");
        string input=Console.ReadLine();
        Console.WriteLine("Encoded Message: "+TransformString(input));
    }
}