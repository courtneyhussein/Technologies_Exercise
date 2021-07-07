using System;

namespace Technology
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer newComputer = new Computer("macOS", 1024);
            Laptop newLaptop = new Laptop("Windows", 2048, 10);
            SmartPhone newSmartPhone = new SmartPhone("macOS", 1024, 35);

            Console.WriteLine($"newComputer OS: {newComputer.OS} - storage size: {newComputer.Storage} - ID: {newComputer.ID}");
            Console.WriteLine($"newLaptop OS: {newLaptop.OS} - storage size: {newLaptop.Storage} - Volume: {newLaptop.Volume} - Needs Power source: {newLaptop.NeedsPowerSource} - ID: {newLaptop.ID}");
            Console.WriteLine($"newSmartPhone OS: {newSmartPhone.OS} - storage size: {newSmartPhone.Storage} - Volume: {newSmartPhone.Apps} - Needs Power source: {newSmartPhone.NeedsPowerSource} - ID: {newSmartPhone.ID}");

            Console.WriteLine("\nComputer");
            newComputer.TurnOn();
            newComputer.TypeInBrowser();

            Console.WriteLine("\nLaptop");
            newLaptop.Power = false;
            newLaptop.TurnOn();
            newLaptop.TypeInBrowser();
            newLaptop.ChangeVolume();

            Console.WriteLine("\nSmartPhone");
            newSmartPhone.Power = false;
            newSmartPhone.TurnOn();
            newSmartPhone.TypeInBrowser();
            newSmartPhone.MakeCall();
            

        }
    }
}
