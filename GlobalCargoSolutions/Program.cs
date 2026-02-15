// See https://aka.ms/new-console-template for more information
namespace GlobalCargoSolutions;
public class Program
{
    public static void Main()
    {
        ShipmentDetails detailsObj=new ShipmentDetails();
        System.Console.Write("Input ID : ");
        detailsObj.ShipmentCode=Console.ReadLine();


   
        bool result=detailsObj.ValidateShipmentCode();
        if(result)
        {
            
            System.Console.Write("Mode : ");
            detailsObj.TransportMode=Console.ReadLine();

            System.Console.Write("Weight : ");
            detailsObj.Weight=double.Parse(Console.ReadLine());

            System.Console.Write("Storage : ");
            detailsObj.StorageDays=Int32.Parse(Console.ReadLine());

       
            double price=detailsObj.CalculateTotalCost();
            System.Console.WriteLine($"The total shipping cost is: {Math.Round(price,2):F2}");
        }
        else
        {
            System.Console.WriteLine("Invalid shipment code");
        }
    }
}