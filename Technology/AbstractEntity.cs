using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    abstract class AbstractEntity
    {
        //Field
        public int ID { get; set; }
        private static List<int> intList = new List<int> ()  {  };

        //Constructor
        public AbstractEntity()
        {
            ID = CreateUniqueID();
        }

        //Method
        private static int CreateUniqueID()
        {
            Random random = new Random();
            //int[] intArr = { };
            int num;
            do
            {
                num = random.Next(0, 10000);
            }
            while (intList.Contains(num));

            intList.Add(num);
            return num;
        }
        public void PrintIDList()
        {
            foreach (int id in intList)
            {
                Console.WriteLine(id);
            }
        }

    }
}
