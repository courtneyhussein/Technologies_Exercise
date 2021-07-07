using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    class Computer : AbstractEntity
    {

        //Fields/Properties
        public readonly bool NeedsPowerSource = true;
        public bool Power { get; set; }
        public string OS { get; set; }
        public int Storage { get; set; }

        //Construcotr
        public Computer(string os, int storage)
        {
            this.OS = os;
            this.Storage = storage;
            this.Power = true;
        }

        //Methods
        public void TurnOn()
        {
            if (Power == false)
            {
                Power = true;
                Console.WriteLine("Your computer is now powered on.");
            }
            else
            {
                Console.WriteLine("The computer was already powered on.");
            }
        }

        public void TypeInBrowser()
        {
            Console.WriteLine("Type something and hit enter: ");
            string input = Console.ReadLine();
            Console.WriteLine(input  + " has been typed into the browser.");
        }

        
    }
}
