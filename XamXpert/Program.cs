namespace XamXpert;
class Program
{
    public static void Main()
    {
        OnlineTest testObj=new OnlineTest();
        System.Console.WriteLine("Enter Exam Details:");
        System.Console.Write("Student Name: ");
        testObj.studentName=Console.ReadLine();
        System.Console.Write("Question Type (MCQ/Coding): ");
        testObj.questionType=Console.ReadLine();
        System.Console.Write("Total Questions: ");
        testObj.totalQuestions=Int32.Parse(Console.ReadLine());
        System.Console.Write("Correct Answers: ");
        testObj.correctAnswers=Int32.Parse(Console.ReadLine());
        System.Console.Write("Wrong Answers: ");
        testObj.wrongAnswers=Int32.Parse(Console.ReadLine());
        System.Console.WriteLine("Exam Summary");
        double score=testObj.calculateScore();
        System.Console.WriteLine($"{testObj.questionType} Test:{testObj.studentName}, Total Score : {score:F1}, Result: {IExam.EvaluateResult(testObj.calculateScore())}");
        

    }
}