    //**use a colon between the class name and the base class name when inheriting
    public class Ram: Vehicle, IGasVehicle   // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public string Name {get; set;}

         public int CurrentTankPercentage {get;set;}

        public void RefuelTank(){
            CurrentTankPercentage = 100;
        }

         public override void Drive(string var)
        {
            Console.WriteLine($" The {var} Ram growls by you. Rummmbbbleeee!");

        }
    }
