using Enumerations;
using NonMotorizedVehicles;

namespace Structures
{
    public struct Tricycle : INonMotorizedVehicle
    {
        private bool isMoving;
        public TerrainType TerrainType { get; set; }
        public int NoOfTires { get; set; }
        public string Brakes { get; set; }
        public bool HasPedals { get; set; }
        public int NoOfWheels { get; set; }
        public bool Riding(bool isMoving)
        {
            this.isMoving = isMoving;
            return this.isMoving;
        }
        public bool Moving(bool isMoving)
        {
            return Moving(this.isMoving);
        }
    }
}
