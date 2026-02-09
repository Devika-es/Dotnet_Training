using System;

namespace XamXpert;

public interface IExam
{
    public double calculateScore();
    public static String EvaluateResult(double percentage)
    {
        string result="";
        if(percentage>=85)
        {
            result="Merit";
        }
        else if(percentage>=60 && percentage<85)
        {
            result="Pass";
        }
        else
        {
            result="Fail";
        }
        return result;
    }
}
