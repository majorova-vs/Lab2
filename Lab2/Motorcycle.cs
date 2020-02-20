using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.Serialization;

namespace Lab2
{
    [Serializable]
    public class Motorcycle : Transport
    {
        [XmlAttribute]
        public string Brand { get; set; }
        public string Number { get; set; }
        public float Speed { get; set; }
        public double LoadCapacity { get; set; }
        public bool IsSidecar { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Motorcycle(string brand, string number, float speed, bool issidecar, double loadcapacity)
        {
            Brand = brand;
            Number = number;
            Speed = speed;
            IsSidecar = issidecar;
            LoadCapacity = loadcapacity;
        }
        public Motorcycle() { }

        public override void PrintInfo()
        {
            Console.WriteLine("Brand: " + this.Brand);
            Console.WriteLine("Number: " + this.Number);
            Console.WriteLine("Speed: " + this.Speed);
            Console.WriteLine("IsSidecar: " + this.IsSidecar);
            Console.WriteLine("Capacity: " + this.CalcLoadCapacity());
            Trace.WriteLine("Motorcycle info has been displayed");
        }

        public override double CalcLoadCapacity()
        {
            Trace.WriteLine("Characteristic has been calculated");
            if (this.IsSidecar) return this.LoadCapacity;
            else return 0;
        }

    }
}
