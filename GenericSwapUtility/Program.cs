namespace GenericSwapUtility;
public class Program
{
    public static void Main()
        {
            int a = 10;                   
            int b = 20;                   
            Console.WriteLine($"Before: a={a}, b={b}"); 

            Utils.Swap(ref a, ref b);    

            Console.WriteLine($"After : a={a}, b={b}"); 

            string x = "Hello";           
            string y = "World";           
            Console.WriteLine($"Before: x={x}, y={y}"); 

            Utils.Swap(ref x, ref y);    

            Console.WriteLine($"After : x={x}, y={y}"); 
        }
}