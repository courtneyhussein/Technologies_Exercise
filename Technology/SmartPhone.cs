using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    class SmartPhone : Computer
    {
        public int Apps { get; set; }

        //Constructor
        public SmartPhone(string os, int storage, int apps)
            : base(os, storage)
        {
            Apps = apps;
        }

        //Methods
        public void MakeCall()
        {
            Console.WriteLine("Enter the 9-digit phone number you want to call: ");
            string input = Console.ReadLine();
            Console.WriteLine("Calling " + input);
        }
    }
}
