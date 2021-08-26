using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bike:Vehicle
    {
        public string BIKETYPE;

        public void Biketype()
        {
            Console.Write("Bike Type:" + BIKETYPE);
        }
    }
}
