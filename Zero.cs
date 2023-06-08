    //**use a colon between the class name and the base class name when inheriting
    public class Zero: Vehicle,IElectricVehicle  // Electric motorcycle
    {
    public double BatteryKWh { get; set; }

    public string Name {get; set;}
    public int CurrentChargePercentage { get; set; }

    public override void Drive(string var)
        {
            Console.WriteLine($" The {var} Zero zips by you. Yeeeeooooowwww!");

        }

        public void ChargeBattery(){
            CurrentChargePercentage = 100;
        }
    }
