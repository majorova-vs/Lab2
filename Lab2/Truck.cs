using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    public class Truck : Transport
    {
        protected string Brand { get; set; }
        protected string Number { get; set; }
        protected float Speed { get; set; }
        protected double LoadCapacity { get; set; }
        protected bool TruckTrailer { get; set; }

        public Truck(string brand, string number, float speed, bool trucktrailer, double loadcapacity)
        {
            Brand = brand;
            Number = number;
            Speed = speed;
            TruckTrailer = trucktrailer;
            LoadCapacity = loadcapacity;
        }

        public override void PrintInfo()
        {

            Console.WriteLine("Brand: " + this.Brand);
            Console.WriteLine("Number: " + this.Number);
            Console.WriteLine("Speed: " + this.Speed);
            Console.WriteLine("TruckTrailer: " + this.TruckTrailer);
            Console.WriteLine("Capacity: " + this.CalcLoadCapacity());

        }

        public override double CalcLoadCapacity()
        {
            if (TruckTrailer) return this.LoadCapacity * 2;
            else return this.LoadCapacity;
        }
    }
}
