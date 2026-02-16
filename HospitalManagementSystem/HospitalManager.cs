using System;

namespace HospitalManagementSystem;

public class HospitalManager
{
    private Dictionary<int,Patient> _patients=new Dictionary<int,Patient>();
    private Queue<Patient> _appointmentQueue=new Queue<Patient>();

    public void RegisterPatient(int id,string name,int age,string condition)
    {
        Patient pObj=new Patient(id,name,age,condition);
       if(!_patients.Any(x=>x.Key==id))
        {
             _patients.Add(id,pObj);
        }
       

    }
    
    public void ScheduleAppointment(int patientId)
    {
        // TODO: Find patient and add to queue
       foreach(var item in _patients)
        {
            if(item.Key==patientId)
            {
                _appointmentQueue.Enqueue(item.Value);
            }
        }
    }
    public Patient ProcessNextAppointment()
    {
        // TODO: Return and remove next patient from queue
       
        Patient patient = _appointmentQueue.Dequeue();
        return patient;
    }
    public List<Patient> FindPatientsByCondition(string condition)
    {
        // TODO: Use LINQ to filter patients
        List<Patient> patientList=new List<Patient>();
        foreach(var item in _patients)
        {
            if(item.Value.Condition==condition)
            {
                patientList.Add(item.Value);
            }
        }
        return patientList;
    }
}
