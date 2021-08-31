using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car : Vehicle
    {
        public override void Vehiclehorn()
        {
         Console.Write("car horn:the car say clean clean");
        }
        public string CARSTYLE;
        public string TRANSMISSIONTYPE;
        public string AIRBAGS;
        public string SEATINGCAPACITY;
        public string TYPEOFSTART;

        public void Cartype()
        {
            Console.Write("Car style:" + CARSTYLE);
            Console.Write("Transmission type:" + TRANSMISSIONTYPE);
            Console.Write("Airbags:" + AIRBAGS);
            Console.Write("Seating Capacity:" + SEATINGCAPACITY);
            Console.Write("Type Of Start:" + TYPEOFSTART);
        }
    }
}
