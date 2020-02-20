using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.Serialization;

namespace Lab2
{
    [Serializable]
    public class Truck : Transport
    {
        [XmlAttribute]
        public string Brand { get; set; }
        public string Number { get; set; }
        public float Speed { get; set; }
        public double LoadCapacity { get; set; }
        public bool TruckTrailer { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Truck(string brand, string number, float speed, bool trucktrailer, double loadcapacity)
        {
            Brand = brand;
            Number = number;
            Speed = speed;
            TruckTrailer = trucktrailer;
            LoadCapacity = loadcapacity;
        }

        public Truck() { }

        public override void PrintInfo()
        {

            Console.WriteLine("Brand: " + this.Brand);
            Console.WriteLine("Number: " + this.Number);
            Console.WriteLine("Speed: " + this.Speed);
            Console.WriteLine("TruckTrailer: " + this.TruckTrailer);
            Console.WriteLine("Capacity: " + this.CalcLoadCapacity());
            Trace.WriteLine("Truck info has been displayed");

        }

        public override double CalcLoadCapacity()
        {
            Trace.WriteLine("Characteristic has been calculated");
            if (TruckTrailer) return this.LoadCapacity * 2;
            else return this.LoadCapacity;
        }
    }
}
