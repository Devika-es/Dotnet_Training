namespace PlaylistManager;
public class Program
{
    public static void Main()
    {
        Playlist manager=new Playlist();
        int N=Int32.Parse(Console.ReadLine());
        manager.processCommands(N);

    }
}