using System;

namespace XamXpert;

public class OnlineTest:IExam
{
    public String studentName{get;set;}
    public int totalQuestions{get;set;}
    public int correctAnswers{get;set;}
    public int wrongAnswers{ get; set; }
    public String questionType { get; set; }
    public double calculateScore()
    {
        double totalScore=0;
        double percentage=0;
        int marksMCQ=2;
        int marksCoding=5;
        if(questionType=="MCQ")
        {
            totalScore=(correctAnswers*marksMCQ)-(wrongAnswers*(marksMCQ*0.10));
            percentage=(totalScore/((totalQuestions*marksMCQ)))*100;
        }else if(questionType=="Coding")
        {
            totalScore=(correctAnswers*marksCoding)-(wrongAnswers*(marksCoding*0.10));
            percentage=(totalScore/((totalQuestions*marksCoding)))*100;
        }
        return percentage;
       
    }

    
}
