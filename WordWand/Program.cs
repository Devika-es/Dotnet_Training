using System.Runtime.CompilerServices;
using System.Text;

namespace WordWand;
class Program
{
    public static  void Main()
    {
        System.Console.Write("Enter the sentence: ");
        string input=Console.ReadLine();
        foreach (char ch in input)
        {
            if (!char.IsLetter(ch) && ch != ' ')
            {
                Console.WriteLine("Invalid Sentence");
                return; 
            }
        }

        string[] arr=input.Split(" ");
        int length=arr.Length;
        if(length%2==0)
        {
            Array.Reverse(arr);
            Console.WriteLine(string.Join(" ",arr));
        }
        else if(length%2!=0)
        {
            
            StringBuilder sb=new StringBuilder();
            foreach(string word in arr)
            {
                for(int i=word.Length-1;i>=0;i--)
                {
                    sb.Append(word[i]);
                }
                sb.Append(" ");
            }
            Console.WriteLine(sb.ToString());
            }
        }
        
  }  


            
        
        

