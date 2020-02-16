using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    public class Motorcycle : Transport
    {
        protected string Brand { get; set; }
        protected string Number { get; set; }
        protected float Speed { get; set; }
        protected double LoadCapacity { get; set; }
        bool IsSidecar { get; set; }
        public Motorcycle(string brand, string number, float speed, bool issidecar, double loadcapacity)
        {
            Brand = brand;
            Number = number;
            Speed = speed;
            IsSidecar = issidecar;
            LoadCapacity = loadcapacity;
        }


        public override void PrintInfo()
        {
            Console.WriteLine("Brand: " + this.Brand);
            Console.WriteLine("Number: " + this.Number);
            Console.WriteLine("Speed: " + this.Speed);
            Console.WriteLine("IsSidecar: " + this.IsSidecar);
            Console.WriteLine("Capacity: " + this.CalcLoadCapacity());
        }

        public override double CalcLoadCapacity()
        {
            if (this.IsSidecar) return this.LoadCapacity;
            else return 0;
        }

    }
}
