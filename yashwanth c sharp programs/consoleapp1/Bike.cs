using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Bike : Vehicle
    {
        public override void Vehiclehorn()
        {
          Console.Write("bike horn:the bike say poy poy");
        }
        public string BIKETYPE;

        public void Biketype()
        {
            Console.Write("Bike Type:" + BIKETYPE);
        }
    }
}
