namespace FitPulse;
public class MemberStats
{
    public string Name { get; set; }
    public int[] WeeklySteps { get; set; }

    // Static Leaderboard
    public static List<MemberStats> leaderboard = new List<MemberStats>();

    // Method to Register Member
    public static void RegisterMember(MemberStats record)
    {
        // TODO: Add record to leaderboard
        if(record!=null)
        {
            leaderboard.Add(record);
            System.Console.WriteLine("Member registered successfully");
        }
    }

    // Method to Get High Step Weeks
    public static Dictionary<string, int> GetHighStepWeeks(List<MemberStats> records, int stepThreshold)
    {
        // TODO: Return dictionary of member name and qualifying week count
        Dictionary<string,int> recordDict=new Dictionary<string,int>();
        
        foreach(var item in records)
        {
            int count=0;
            foreach(int step in item.WeeklySteps)
            {
                if(step>=stepThreshold)
                {
                    count++;
                }
            }
            if(count>0)
            {
                recordDict.Add(item.Name,count);
            }
        }
         return recordDict;
    }

    // Method to Calculate Average Steps
    public static double CalculateAverageSteps()
    {
        // TODO: Calculate overall average of all steps
       int total=0;
       int count=0;
       foreach(var member in MemberStats.leaderboard)
        {
            foreach(int item in member.WeeklySteps)
            {
                total+=item;
                count++;
            }
        }
        if(count==0)return 0;
        return (double)total/count;
    }

    
    public static void Main(string[] args)
    {
        while (true)
        {
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    string name = Console.ReadLine();
                    string[] stepsInput = Console.ReadLine().Split(' ');

                    int[] steps = new int[4];
                    for (int i = 0; i < 4; i++)
                    {
                        steps[i] = int.Parse(stepsInput[i]);
                    }

                    MemberStats member = new MemberStats
                    {
                        Name = name,
                        WeeklySteps = steps
                    };

                    RegisterMember(member);
                    break;

                case 2:
                    int threshold = int.Parse(Console.ReadLine());
                    var result = GetHighStepWeeks(MemberStats.leaderboard, threshold);

                    if (result.Count == 0)
                    {
                        Console.WriteLine("No high-step weeks recorded");
                    }
                    else
                    {
                        foreach (var item in result)
                        {
                            Console.WriteLine(item.Key + " " + item.Value);
                        }
                    }
                    break;

                case 3:
                    double avg = CalculateAverageSteps();
                    Console.WriteLine("Overall average weekly steps: " + avg);
                    break;

                case 4:
                    Console.WriteLine("Exiting FitPulse – Stay Active!");
                    return;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}

