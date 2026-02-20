namespace LibraryManagementsystem;
public class Program
{
    public static void Main()
    {
        LibraryManager manager=new LibraryManager();
        int N=Int32.Parse(Console.ReadLine());
        manager.processCommands(N);

    }
}
