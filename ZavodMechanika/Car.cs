using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artzavod
{
    public class Car
    {
        //public List<Car> NotFinishCar = new List<Car>();
        public List<Car> FinishCar = new List<Car>();
        public Car(int wheelcount, int enginecount, int seatcount, int ruddercount)
        {
            WheelCount = wheelcount;
            EngineCount = enginecount;
            SeatCount = seatcount;
            RudderCount = ruddercount;
        }
        public int WheelCount { get; set; }
        public int EngineCount { get; set; }
        public int SeatCount { get; set; }
        public int RudderCount { get; set; }

        public override string ToString()
        {
            return $"Wheel {WheelCount}: Engine - {EngineCount}: Seat - {SeatCount}: Rudder - {RudderCount}";
        }
    }
}
