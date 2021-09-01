using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_and_objects_using_interface
{
    public class Car : Bike
    {


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
