    //**use a colon between the class name and the base class name when inheriting
    public class Tesla: Vehicle, IElectricVehicle   // Electric car
    {
        public double BatteryKWh { get; set; }

        public string Name {get; set;}

        public int CurrentChargePercentage { get; set; }

         public override void Drive(string var)
        {
            Console.WriteLine($" The {var} Tesla blazes by you. Rrrmmmmmmmm!");

        }

         public override void Turn(string direction)
        {
            Console.WriteLine($" The {MainColor} Tesla squeals around a  {direction} turn.");
        }

        public override void Stop()
        {
            Console.WriteLine($" The {MainColor} Tesla silently stops as if it never moved.");
        }

      public void ChargeBattery(){
        CurrentChargePercentage = 100;
      }
    }
