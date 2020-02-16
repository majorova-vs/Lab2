using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    public class PassengerCar : Transport
    {
        protected string Brand { get; set; }
        protected string Number { get; set; }
        protected float Speed { get; set; }
        protected double LoadCapacity { get; set; }
        public PassengerCar(string brand, string number, float speed, double capacity)
        {
            this.Brand = brand;
            this.Number = number;
            this.Speed = speed;
            this.LoadCapacity = capacity;
        }

        public override void PrintInfo() 
        {
            Console.WriteLine("Brand: " + this.Brand);
            Console.WriteLine("Number: " + this.Number);
            Console.WriteLine("Speed: " + this.Speed);
            Console.WriteLine("Capacity: " + this.CalcLoadCapacity());
        }

        public override double CalcLoadCapacity()
        {
            return this.LoadCapacity;
        }

    }
}
