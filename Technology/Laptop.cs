using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    class Laptop : Computer
    {
        //Fields/Properties
        public int Volume { get; set; }

        //Constructor
        public Laptop(string os, int storage, int volume)
            : base(os, storage)
        {
            Volume =volume;
        }


        //Methods
        public void ChangeVolume()
        {
            Console.WriteLine("Do you want to raise or lower the volume? Enter + or - : ");
            string upOrDown = Console.ReadLine();
            Console.WriteLine("Enter a number that represents how much you would like to change the volume: ");
            int howMuch = Int32.Parse(Console.ReadLine());

            if (upOrDown == "+")
            {
                Volume += howMuch;
            }
            else if (upOrDown == "-")
            {
                Volume -= howMuch;

                if (Volume < 0)
                {
                    Volume = 0;
                }
            }
            Console.WriteLine("The Volume is " + Volume);
        }
    }
}
