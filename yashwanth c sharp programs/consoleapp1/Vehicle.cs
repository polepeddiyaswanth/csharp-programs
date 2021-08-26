using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vehicle
    {
        public string COMPANYNAME;
        public string VEHICLENAME;
        public string COLOR;
        public string ENGINECC;
        public string FUELTYPE;
        public string VEHICLEPRICE;
        public string VEHICLEMILEAGE;
        public string CAPACITYOFFUELTANK;
        public void Vehicletype()
        {
            Console.Write("company name:" + COMPANYNAME);
            Console.Write("vehicle name:" + VEHICLENAME);
            Console.Write("color:" + COLOR);
            Console.Write("engine cc:" + ENGINECC);
            Console.Write("fuel type:" + FUELTYPE);
            Console.Write("vehicle price:" + VEHICLEPRICE);
            Console.Write("vehicle mileage:" + VEHICLEMILEAGE);
            Console.Write("capacity of fuel tank:" + CAPACITYOFFUELTANK);
        }
    }
}
