﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_and_objects_using_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Car verna = new Car();
            verna.COMPANYNAME = "hyundai\n";
            verna.VEHICLENAME = "verna\n";
            verna.COLOR = "black\n";
            verna.CARSTYLE = "sedan\n";
            verna.ENGINECC = "1497cc\n";
            verna.FUELTYPE = "petrol\n";
            verna.TYPEOFSTART = "button mode\n";
            verna.TRANSMISSIONTYPE = "6 gear transmission\n";
            verna.SEATINGCAPACITY = "5 seater\n";
            verna.AIRBAGS = "6 airbags\n";
            verna.VEHICLEPRICE = "₹17 lakh\n";
            verna.VEHICLEMILEAGE = "25 Km/L\n";
            verna.CAPACITYOFFUELTANK = "45 L\n";
            verna.Vehicletype();
            verna.Cartype();
            Console.Write("\n********************************\n");
            Bike yamaha = new Bike();
            yamaha.COMPANYNAME = "yamaha\n";
            yamaha.VEHICLENAME = "FZ ver.3\n";
            yamaha.BIKETYPE = "sport bike\n";
            yamaha.COLOR = "blue\n";
            yamaha.ENGINECC = "150cc\n";
            yamaha.FUELTYPE = "petrol\n";
            yamaha.VEHICLEPRICE = "₹1 lakh\n";
            yamaha.VEHICLEMILEAGE = "50 Km/L\n";
            yamaha.CAPACITYOFFUELTANK = "13 L\n";
            yamaha.Vehicletype();
            yamaha.Biketype();
            Console.ReadKey();
        }

    }
}
