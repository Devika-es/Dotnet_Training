using System;

namespace TrainingInstitute;

public class StudentUtility
{
    public Dictionary<string,string> GetStudentDetails(string id)
    {
        Dictionary<string,string> result=new Dictionary<string,string>();
        foreach(var detail in Program.studentDetails)
        {
            if(detail.Value.Id==id)
            {
                string value=detail.Value.Name+"_"+detail.Value.Course;
                result.Add(id,value);
            }
           
        }
        return result;
    }

    public Dictionary<string,Student> UpdateStudentMarks(string id,int marks)
    {
        Dictionary<string,Student> updateStudent=new Dictionary<string,Student>();
        foreach(Student student in Program.studentDetails.Values)
        {
            if(student.Id==id)
            {
                student.Marks=marks;
                updateStudent.Add(student.Id,student);
                break;
            }
        }
        return updateStudent;
    }

}
