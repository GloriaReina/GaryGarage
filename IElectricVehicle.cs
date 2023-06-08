public interface IElectricVehicle {
    //  public double BatteryKWh { get; set; }

     public int CurrentChargePercentage {get;set;}

     public string Name {get; set;}

    public void ChargeBattery();
    
}

