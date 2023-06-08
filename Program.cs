using System;

/*Part 1 exercise*/

class Program {
        static void Main (string[] args)
        {
            Zero fxs = new Zero();
            fxs.CurrentChargePercentage = 45;
            fxs.Name = "fsx";
            Zero fx = new Zero();
            fx.CurrentChargePercentage = 65;
            fx.Name = "fs";
            Tesla modelS = new Tesla();
            modelS.CurrentChargePercentage = 85;
            modelS.Name = "modelS";

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($" The {ev.Name} current charge is:{ev.CurrentChargePercentage}");
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"After charging, the {ev.Name} current charge is now:{ev.CurrentChargePercentage}");
            }

            /***********************************************/

            Ram ram = new Ram ();
            ram.CurrentTankPercentage = 75;
            ram.Name = "ram";
            Cessna cessna150 = new Cessna ();
            cessna150.CurrentTankPercentage = 95;
            cessna150.Name = "cessna150";

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
                ram, cessna150
            };

            Console.WriteLine("Gas Vehicles");
            foreach(IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"The {gv.Name} tank is at {gv.CurrentTankPercentage} percent");
            }

            foreach(IGasVehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach(IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"After refuel, the {gv.Name} tank is now {gv.CurrentTankPercentage} percent full.");
            }
        }
    }





/*Part 1 exercise*/
// class Program{
//     static void Main () {

//     //create instance of each vehivles
//     Cessna mx410 = new Cessna();
//     Tesla modelS = new Tesla ();
//     Ram classic = new Ram ();
//     Zero fsx = new Zero();

//     //assign values for each vehicles properties
//     mx410.MainColor = "White";
//     mx410.Direction = "Right";
    
//     modelS.MainColor = "Burgundy";
//     modelS.Direction = "Right";
    
//     classic.MainColor = "Fire-Red";
//     classic.Direction = "Right";
    
//     fsx.MainColor = "Midnight-Blue";
//     fsx.Direction = "Right";
 
//  //print to console
//     fsx.Drive(fsx.MainColor);
//     fsx.Turn(fsx.Direction);
//     fsx.Stop();
//     Console.WriteLine();

    
//     modelS.Drive(modelS.MainColor);
//     modelS.Turn(modelS.Direction);
//     modelS.Stop();
//     Console.WriteLine();

//     classic.Drive(classic.MainColor);
//     classic.Turn(classic.Direction);
//     classic.Stop();

//     Console.WriteLine();
    
//     mx410.Drive(mx410.MainColor);
//     mx410.Turn(mx410.Direction);
//     mx410.Stop();
//     Console.WriteLine();
//     }
// }
