    //**use a colon between the class name and the base class name when inheriting
    public class Cessna: Vehicle, IGasVehicle   // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public string Name {get; set;}

        public int CurrentTankPercentage {get;set;}

        public void RefuelTank(){
            CurrentTankPercentage = 100;
        }

         public override void Drive(string var)
        {
            Console.WriteLine($" The {var} Cessna flashes by you. Zzzooooommmmm!");

        }

          public override void Stop()
        {
            Console.WriteLine($" The {MainColor} Cessna rolls down the runway for a mile and stops.");
        }
    }
