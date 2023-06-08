    public class Vehicle
    {
        public string MainColor { get; set; }

        public string Direction { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive(string vehicleColor)
        {
            Console.WriteLine($" The {vehicleColor} vehicle zips by you.Vrooom!");
        }

        public virtual void Turn(string direction)
        {
            Console.WriteLine($" The vehicle carefully turns {direction}.");
        }

        public virtual void Stop()
        {
            Console.WriteLine($" The vehicle gently rolls to a stop!");
        }
    }
