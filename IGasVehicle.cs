public interface IGasVehicle {
    //  public double BatteryKWh { get; set; }

     public int CurrentTankPercentage {get;set;}

     public string Name {get; set;}

    public void RefuelTank();
    
}