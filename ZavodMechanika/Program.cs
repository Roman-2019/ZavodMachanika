using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artzavod
{
    class Program
    {
        public static Random Rnd = new Random();
        static void Main(string[] args)
        {
            var zavod = new Zavod();
            //zavod.Add(new Wheel());
            //var record = Car();


            var commands = new Dictionary<ConsoleKey, ICommand>
            {
                [ConsoleKey.Enter] = new CreateWheelCommand(zavod),// { Detal=new Wheel(100)}
                [ConsoleKey.Spacebar] = new CommandSimulator(zavod)
            };

            var undone = true;
            while (undone)
            {
                var key = Console.ReadKey().Key;
                if (!commands.ContainsKey(key))
                    break;
                var command = commands[key];
                command.Act();
            }
        }
    }
}
