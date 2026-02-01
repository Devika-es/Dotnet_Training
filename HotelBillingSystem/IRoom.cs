using System;
using System.ComponentModel;

namespace HotelBillingSystem;

public interface IRoom
{
    public double calculateTotalBill(int nightsStayed,int joiningYear);
    public  int calculateMembershipYear(int joiningYear)
    {
        return DateTime.Now.Year-joiningYear;
    }
 
    
}
