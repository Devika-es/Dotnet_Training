using System;

namespace HotelBillingSystem;

public class HotelRoom:IRoom
{
    public string roomType{ get; set; }
    public double ratePerNight{get;set;}
    public string guestName{get;set;}

    public HotelRoom(string roomType,double ratePerNight,string guestName)
    {
        this.roomType=roomType;
        this.ratePerNight=ratePerNight;
        this.guestName=guestName;
    }
  
    public double calculateTotalBill(int nightsStayed,int joiningYear)
    {
        double totalBill=0;
        
        int memberShip=((IRoom)this).calculateMembershipYear(joiningYear);
        totalBill=nightsStayed*ratePerNight;
        if(memberShip>3)
        {
            totalBill=totalBill-totalBill*0.1;
        }
        double roundedBill=(int)Math.Round(totalBill);
        return roundedBill;
    }
    
}
