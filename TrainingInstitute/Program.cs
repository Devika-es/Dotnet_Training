namespace TrainingInstitute;
class Program
{
    public static Dictionary<int,Student> studentDetails;
    static void Menu()
    {

        System.Console.WriteLine("1. Get Student Details");
        System.Console.WriteLine("2. Update Marks");
        System.Console.WriteLine("3. Exit");
    }
    public static void Main()
    {
        studentDetails=new Dictionary<int, Student>();
        Student s1=new Student
        {
            Id="ST01",
            Name="Alice",
            Course="DataScience",
            Marks=90
        };
        studentDetails.Add(1,s1);
        try
        {
            do
            {
                StudentUtility utilityObj=new StudentUtility();
                Menu();
                System.Console.Write("Enter your choice: ");
                int choice=Int32.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        {
                            
                            System.Console.Write("Enter the student id: ");
                            string id=Console.ReadLine();
                            var getDict=utilityObj.GetStudentDetails(id);
                            if(getDict!=null)
                            {
                                foreach(var item in getDict)
                                {
                                    System.Console.WriteLine($"{item.Key}\t{item.Value}");
                                }
                            }
                            else
                            {
                                System.Console.WriteLine("Student id not found");
                            }
                            break;
                        }
                    case 2:
                        {
                            System.Console.Write("Enter id whose marks need to be updated: ");
                            string id=Console.ReadLine();
                            System.Console.Write("Enter updated marks: ");
                            int updatedMarks=Int32.Parse(Console.ReadLine());
                            var updatedict=utilityObj.UpdateStudentMarks(id,updatedMarks);
                            if(updatedict.Count==0)
                            {
                                System.Console.WriteLine("Student id not found");
                            }
                            else
                            {
                                System.Console.WriteLine("Marks updated successfully");
                            }
                            break;

                        }
                    case 3:
                        {
                            System.Console.WriteLine("Exiting..");
                            return;
                        }
                }
                
            }while(true);
            
        }catch(Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
    }
}