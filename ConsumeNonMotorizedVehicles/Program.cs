using Enumerations;
using NonMotorizedVehicles;
using Structures;//structures was spelled incorrectly therefore the using directive was not understanding the command
using System;

namespace ConsumeNonMotorizedVehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Bicycle bike = new Bicycle
                {
                    TerrainType = TerrainType.Beach,
                    NoOfTires = 2
                };

                Tricycle trike = new Tricycle
                {
                    TerrainType = TerrainType.City,
                    NoOfTires = 3
                };// you must include the ;

                Bicycle bikeTwin = bike;
                bikeTwin.TerrainType = TerrainType.AllTerrain;
                Console.WriteLine($"bike has terrain type {bike.TerrainType}");

                Tricycle trikeTwin = trike;
                trikeTwin.TerrainType = TerrainType.Mountain;
                Console.WriteLine($"trike has terrain type {trike.TerrainType}");
            }
            catch (Exception e)
            { throw e; }

           
        }
    }
}
