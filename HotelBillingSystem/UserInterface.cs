using System;
namespace HotelBillingSystem;
public class UserInterface
{
    public static void Main()
    {
        
        System.Console.WriteLine("Enter Deluxe Room Details: ");
        string roomType="Deluxe";
        System.Console.Write("Guest Name: ");
        string guestName=Console.ReadLine();
        System.Console.Write("Rate per Night: ");
        double  ratePerNight=double.Parse(Console.ReadLine());
        System.Console.Write("Nights Stayed: ");
        int nightsStayed=Int32.Parse(Console.ReadLine());
        System.Console.Write("Joining Year: ");
        int joiningYear=Int32.Parse(Console.ReadLine());
        HotelRoom roomObj1=new HotelRoom(roomType,ratePerNight,guestName);

        System.Console.WriteLine("\n\nEnter Suite Room Details: ");
        string roomType2="Suite";
        System.Console.Write("Guest Name: ");
        string guestName2=Console.ReadLine();
        System.Console.Write("Rate per Night: ");
        double  ratePerNight2=double.Parse(Console.ReadLine());
        System.Console.Write("Nights Stayed: ");
        int nightsStayed2=Int32.Parse(Console.ReadLine());
        System.Console.Write("Joining Year: ");
        int joiningYear2=Int32.Parse(Console.ReadLine());
        HotelRoom roomObj2=new HotelRoom(roomType2,ratePerNight2,guestName2);


        System.Console.WriteLine("\n\nRoom Summary:");
        IRoom room1 = roomObj1;
        int memberShip1 = room1.calculateMembershipYear(joiningYear);
        double bill1=roomObj1.calculateTotalBill(nightsStayed,joiningYear);
        System.Console.WriteLine($"Deluxe Room: {roomObj1.guestName}, {roomObj1.ratePerNight:F1} per night, Membership: {memberShip1} years");

        IRoom room2 = roomObj2;
        int memberShip2 = room2.calculateMembershipYear(joiningYear2);

        double bill2=roomObj2.calculateTotalBill(nightsStayed2,joiningYear2);
        System.Console.WriteLine($"Suite Room: {roomObj2.guestName}, {roomObj2.ratePerNight:F1} per night, Membership: {memberShip2} years");

        System.Console.WriteLine("\nTotal bill:");
        System.Console.WriteLine($"For {roomObj1.guestName} (Deluxe): {bill1:F1}");
        System.Console.WriteLine($"For {roomObj2.guestName} (Suite): {bill2:F1}");
        


       


    }
}