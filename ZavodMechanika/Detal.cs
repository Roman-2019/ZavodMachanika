using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artzavod
{
    abstract class Detal
    {
        public int Price { get; }
        public Detal(int price)
        {
            Price = price;
        }
    }

    class Engine : Detal
    {
        public Engine(int price)
            : base(price)
        { }
    }


    class Wheel : Detal
    {
        public Wheel(int price) : base(price)
        {
        }
    }

    class Seat : Detal
    {
        public Seat(int price) : base(price)
        {
        }
    }
    class Rudder : Detal
    {
        public Rudder(int price) : base(price)
        {
        }
    }

    interface ICommand
    {
        void Act();
    }

    class CommandSimulator : ICommand
    {
        private Zavod zavod;

        public CommandSimulator(Zavod zavod)
        {
            this.zavod = zavod;
        }

        public void Act()
        {
            //Console.WriteLine("Command triggered");
            zavod.StatusCars();
            
        }
        //protected virtual void InternalAct()
        //{
            
        //}

    }


    class Command : ICommand
    {
        public void Act()
        {
            InternalAct();
        }

        protected virtual void InternalAct()
        {
        }
    }

    class CreateWheelCommand : Command
    {
        private Zavod zavod;
        public Detal Detal { get; set; }

        public CreateWheelCommand(Zavod zavod)
        {
            this.zavod = zavod;
        }

        protected override void InternalAct()
        {
            var key = Program.Rnd.Next(0, 4);

            Detal detal = null;

            //PriceDetal det;

            if (key == 0)
                //det=PriceDetal.detalWheel;
                detal = new Wheel(100);
            else if (key == 1)
                detal = new Engine(1500);
            else if (key == 2)
                detal = new Seat(150);
            else if (key == 3)
                detal = new Rudder(50);

            zavod.Add(detal);
            zavod.ShowState();
            zavod.ShowAllDetal();
        }
    }
}
