using System;

        public class Vehicle
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
            Console.Write("company name:"+ COMPANYNAME);
            Console.Write("vehicle name:" + VEHICLENAME);
            Console.Write("color:" + COLOR);
            Console.Write("engine cc:" + ENGINECC);
            Console.Write("fuel type:" + FUELTYPE);
            Console.Write("vehicle price:" + VEHICLEPRICE);
            Console.Write("vehicle mileage:" + VEHICLEMILEAGE);
            Console.Write("capacity of fuel tank:" + CAPACITYOFFUELTANK);
    }
        }
         public class Car : Vehicle
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
         public class Bike : Vehicle
        {
            public string BIKETYPE;
            
            public void Biketype()
                {
                    Console.Write("Bike Type:" + BIKETYPE);
    }
        }

          class Program
          {
        public static void Main()
        {
            Car verna = new Car();
            verna.COMPANYNAME = "hyunadai\n";
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
        Console.Write("********************************\n");
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

