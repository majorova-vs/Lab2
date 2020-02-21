using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Lab2
{
    class Program
    {

        /// <summary>
        /// Вызывается метод ReadAndDisplay и на экран выводится необходимая информация
        /// </summary>
        static void Main(string[] args)
        {
            TextWriterTraceListener tr1 = new TextWriterTraceListener(System.Console.Out);
            Trace.Listeners.Add(tr1);
            Trace.Flush();
            try
            {
                ReadAndDisplay();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }





        }

        /// <summary>
        /// Метод считывает информацию из файла OutPut.txt и записывает ее в массив transports.
        /// Генерируются XML-файлы, содержащие информацию о созданных объектах.
        /// </summary>
        static void ReadAndDisplay()
        {
                Int32.TryParse(File.ReadLines(@"D:\OutPut.txt").Skip(0).First(), out int n);
                float.TryParse(File.ReadLines(@"D:\OutPut.txt").Skip(1).First(), out float mincap);
                Transport[] transports = new Transport[n];
                string[] str;
                for (int i = 0; i < n; i++)
                {
                    str = File.ReadLines(@"D:\OutPut.txt").Skip(i + 2).First().Split(',');
                if (str[0] == "Motorcycle")
                {
                    transports[i] = new Motorcycle(str[1], str[2], float.Parse(str[3]), bool.Parse(str[4]), double.Parse(str[5]));
                    XmlSerializer formatter = new XmlSerializer(typeof(Motorcycle));
                    using (FileStream fs = new FileStream(@"D:\Motorcycle.xml", FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(fs, transports[i]);
                    }
                }
                else if (str[0] == "PassengerCar")
                {
                    transports[i] = new PassengerCar(str[1], str[2], float.Parse(str[3]), double.Parse(str[4]));
                    XmlSerializer formatter = new XmlSerializer(typeof(PassengerCar));
                    using (FileStream fs = new FileStream(@"D:\PassengerCar.xml", FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(fs, transports[i]);
                    }
                }
                else if (str[0] == "Truck")
                {
                    transports[i] = new Truck(str[1], str[2], float.Parse(str[3]), bool.Parse(str[4]), double.Parse(str[5]));
                    XmlSerializer formatter = new XmlSerializer(typeof(Truck));
                    using (FileStream fs = new FileStream(@"D:\Truck.xml", FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(fs, transports[i]);
                    }
                }
                }
                Console.WriteLine("All transport in database: ");
                for (int i = 0; i < 5; i++)
                {
                    transports[i].PrintInfo();
                    Console.WriteLine();
                }
                PrintSuitableInfo(transports, mincap);
            

        }
        /// <summary>
        /// Метод выводит на экран информацию только о машинах, удовлетворяющих требованиям грузоподъемности
        /// <param name="minCapacity"> минимальная грузоподъемность</param>
        /// <param name="transports"> массив транспортных средств (база данных)</param>
        /// </summary>
        static void PrintSuitableInfo(Transport[] transports, float minCapacity)
        {
            Console.WriteLine("List of suitable transport: ");
            foreach (Transport transport in transports)
            {
                if (transport.CalcLoadCapacity() >= minCapacity)
                {
                    transport.PrintInfo();
                    Console.WriteLine();
                }
            }
        }
    }
}
