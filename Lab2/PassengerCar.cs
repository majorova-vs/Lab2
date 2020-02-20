using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.Serialization;

namespace Lab2
{
    [Serializable]
    public class PassengerCar : Transport
    {
        [XmlAttribute]
        public string Brand { get; set; }
        public string Number { get; set; }
        public float Speed { get; set; }
        public double LoadCapacity { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public PassengerCar(string brand, string number, float speed, double capacity)
        {
            this.Brand = brand;
            this.Number = number;
            this.Speed = speed;
            this.LoadCapacity = capacity;
        }
        public PassengerCar() { }

        public override void PrintInfo() 
        {
            Console.WriteLine("Brand: " + this.Brand);
            Console.WriteLine("Number: " + this.Number);
            Console.WriteLine("Speed: " + this.Speed);
            Console.WriteLine("Capacity: " + this.CalcLoadCapacity());
            Trace.WriteLine("Car info has been displayed");
        }

        public override double CalcLoadCapacity()
        {
            Trace.WriteLine("Characteristic has been calculated");
            return this.LoadCapacity;
        }

    }
}
