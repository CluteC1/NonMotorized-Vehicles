using Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonMotorizedVehicles
{
    public class Coupe : BaseNonMotorizedVehicle
    {
        public TerrainType TerrtainType { get; set; }
        public int NoOfTires { get; set; }
    }
    public class Bicycle : BaseNonMotorizedVehicle
    {
        public TerrainType TerrtainType { get; set; }
        public int NoOfTires { get; set; }
    }
}
