using Enumerations;

namespace NonMotorizedVehicles
{
    public class BaseNonMotorizedVehicle
    {
        private bool isMoving;
        public BaseNonMotorizedVehicle()
        {
            isMoving = false;
        }
        public bool HasPedals { get;set;}
        public int NoOfWheels { get; set; }
        public TerrainType TerrainType { get; set; } // For this issue you have to apply a public accessor for other classes to call it

        public bool Moving(bool isMoving)
        {
            return Moving(this.isMoving);
        }
        public bool Driving(bool isMoving)
        {
            this.isMoving = isMoving;
            return this.isMoving; // the program needed a semicolon to close out the statement
        }
    }
}
