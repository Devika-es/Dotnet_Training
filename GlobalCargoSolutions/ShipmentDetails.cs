using System;
using System.Text.RegularExpressions;

namespace GlobalCargoSolutions;

public class ShipmentDetails : Shipment
{
    
    public bool ValidateShipmentCode()
    {
      
        bool isValid=false;
        if(this.ShipmentCode.Length==7)
        {
            string pattern=@"^GC#\d{4}$";
            isValid=Regex.IsMatch(this.ShipmentCode,pattern);
        }
        return isValid;
    }
    public double CalculateTotalCost()
    {
        double ratePerKg=0;
        
        if(this.TransportMode=="Sea")
        {
            ratePerKg=15;
        }
        else  if(this.TransportMode=="Air")
        {
            ratePerKg=50;
        }
        else if(this.TransportMode=="Land")
        {
            ratePerKg=25;
        }
        double totalCost=this.Weight*ratePerKg+Math.Sqrt(this.StorageDays);
        return totalCost;
    }
}
