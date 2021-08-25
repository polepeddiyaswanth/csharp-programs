using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapp1
{
    class Program
    {
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
            }
        }
         public class Car : Vehicle
        {
           public string CARSTYLE;
           public string TRANSMISSIONTYPE;
           public string AIRBAGS;
           public string SEATINGCAPACITY;
           public string TYPEOFSTART;
           
        }
         public class Bike : Vehicle
        {
            public string BIKETYPE;
        }
         public static void Main()
        {
            Car yash = new Car();
            yash.COMPANYNAME = "hyunadai";
            yash.VEHICLENAME = "verna";
            yash.COLOR = "black";
            yash.CARSTYLE = "sedan";
            yash.ENGINECC = "1497cc";
            yash.FUELTYPE = "petrol";
            yash.TYPEOFSTART = "button mode";
            yash.TRANSMISSIONTYPE = "6 gear transmission";
            yash.SEATINGCAPACITY = "5 seater";
            yash.AIRBAGS = "6 airbags";
            yash.VEHICLEPRICE = "₹17 lakh";
            yash.VEHICLEMILEAGE = "25 Km/L";
            yash.CAPACITYOFFUELTANK = "45 L";
            yash.Vehicletype();

            Bike yashw = new Bike();
            yashw.COMPANYNAME = "yamaha";
            yashw.VEHICLENAME = "FZ ver.3";
            yashw.BIKETYPE = "sport bike";
            yashw.COLOR = "blue";
            yashw.ENGINECC = "150cc";
            yashw.FUELTYPE = "petrol";
            yashw.VEHICLEPRICE = "₹1 lakh";
            yashw.VEHICLEMILEAGE = "50 Km/L";
            yashw.CAPACITYOFFUELTANK = "13 L";
            yashw.Vehicletype();
        }
    }
}
