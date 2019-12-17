using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artzavod
{
    class Zavod
    {
        private  List<Wheel> wheels = new List<Wheel>();
        private  List<Engine> engines = new List<Engine>();
        private  List<Seat> seats = new List<Seat>();
        private  List<Rudder> rudders = new List<Rudder>();
        private int prosraliCounter = 0;
        private int amountCounter = 0;
        public bool wheelflag = false;
        public bool engineflag = false;
        public bool seatflag = false;
        public bool rudderflag = false;
        public int[] rec = new int[4] { 0, 0, 0, 0 };
        private int amountcars = 0;
        public void Add(Detal detal)
        {
            var record = new Car(wheels.Count, engines.Count, seats.Count, rudders.Count);
            if (detal == null)
                throw new ArgumentNullException("detail");
            if (detal.Price == 0)
                return;
            if (detal is Wheel wheel)
            {
                if (wheels.Count < 4)
                {
                    wheels.Add(wheel);
                    rec[0]++;
                    this.amountCounter += detal.Price;
                }
                else
                {
                    if (wheels.Count >= 4)
                    
                        this.prosraliCounter += detal.Price;
                        record.WheelCount++;
                        rec[0]++;
                    
                }
            }
            if (detal is Engine engine)
            {
                if (engines.Count < 2)
                {
                    engines.Add(engine);
                    rec[1]++;
                    this.amountCounter += detal.Price;
                }
                else
                {
                    if (engines.Count >= 2)
                    
                        this.prosraliCounter += detal.Price;
                        record.EngineCount++;
                        rec[1]++;
                    
                }
            }
            if (detal is Seat seat)
            {
                if (seats.Count < 2)
                {
                    seats.Add(seat);
                    rec[2]++;
                    this.amountCounter += detal.Price;
                }
                else
                {
                    if (seats.Count >= 2)
                    
                        this.prosraliCounter += detal.Price;
                        record.SeatCount++;
                        rec[2]++;
                    
                }
            }
            if (detal is Rudder rudder)
            {
                if (rudders.Count < 1)
                {
                    rudders.Add(rudder);
                    rec[3]++;
                    this.amountCounter += detal.Price;
                }
                else
                {
                    if (rudders.Count >= 1)
                    
                        this.prosraliCounter += detal.Price;
                        record.RudderCount++;
                        rec[3]++;
                    
                }
            }
            if (wheels.Count >= 4) wheelflag = true;
            if (engines.Count >= 2) engineflag = true;
            if (seats.Count >= 2) seatflag = true;
            if (rudders.Count >= 1) rudderflag = true;
            record.ToString();
            //for (int i = 0; i < rec[0]-4; i++)
            //{
            //    this.amountCounter += detal.Price;
            //}
            //for (int i = 0; i < rec[1]-2; i++)
            //{
            //    this.amountCounter += detal.Price;
            //}
            //for (int i = 0; i < rec[2]-2; i++)
            //{
            //    this.amountCounter += detal.Price;
            //}
            //for (int i = 0; i < rec[3]-1; i++)
            //{
            //    this.amountCounter += detal.Price;
            //}
        }

        public void ShowState()
        {
            if (wheelflag == true && engineflag == true && seatflag == true && rudderflag == true)
            {

                Console.WriteLine($"Car is done!!!!!");//, poterali: {prosraliCounter}");
                amountcars++;
               //amountCounter =0;
                wheels.Clear();
                engines.Clear();
                seats.Clear();
                rudders.Clear();
                wheelflag = false;
                rec[0] = rec[0] - 4;
                engineflag = false;
                rec[1] = rec[1] - 2;
                seatflag = false;
                rec[2] = rec[2] - 2;
                rudderflag = false;
                rec[3] = rec[3] - 1;
                //for (int i=0; i<rec[0];i++) 
                //{
                //    this.amountCounter += det
                //}
            }
            else
            {
                Console.WriteLine($"Wheels: {wheels.Count}, Engine: {engines.Count}, Seats: {seats.Count}, Rudder: {rudders.Count}");
                Console.WriteLine($"{wheelflag},{engineflag},{seatflag},{rudderflag}");
                
            }
        }

        public void ShowAllDetal() 
        {
            for (int i = 0; i < rec.Length; i++) Console.Write("{0}\t ",rec[i]);
            Console.WriteLine();
            //var recorder = new Car(rec[0], rec[1], rec[2], rec[3]);
            //Console.WriteLine(recorder);
        }

        public void StatusCars() 
        {
            //Detal detal;
            Console.Clear();
            Console.WriteLine($"Amount cars - {amountcars}, Price cars - {amountCounter}");
            amountCounter = 0;
            //for (int i=0; i < rec[0]; i++)
            //{
            //    this.amountCounter += Wheel.Price;
            //}
            Console.WriteLine($"Price all free details for cars - {prosraliCounter}");
            if (rec[3] >= rec[2] && rec[3] >= rec[1] && rec[3] >= rec[0])
            {
                Console.WriteLine($"Expect cars - {rec[3]}");
            }
            else if (rec[2] > rec[3] && rec[2] >= rec[1] && rec[2] >= rec[0])
            {
                Console.WriteLine($"Expect cars - {rec[2]}");
            }
            else if (rec[1] > rec[2] && rec[1] > rec[3] && rec[1] >= rec[0])
            {
                Console.WriteLine($"Expect cars - {rec[1]}");
            }
            else
            {
                Console.WriteLine($"Expect cars - {rec[0]}");
            }
        }

    }
}
