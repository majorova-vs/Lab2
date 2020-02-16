using System;
using System.IO;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // int n = 5;
            int n;
            //double minCapacity = 200;
            double minCapacity;
            try
            {
                StreamReader sr = new StreamReader(@"D:\OutPut.txt");
                
                    string line = sr.ReadLine();
                    n = Convert.ToInt32(line);
                    minCapacity = Convert.ToDouble(sr.ReadLine());
                
                

                //Console.WriteLine(n);
                //Console.WriteLine(minCapacity);


                Transport[] transports = new Transport[n];

                transports[0] = new Motorcycle("Java", "a123bb", 120, false, 80);
                transports[1] = new Motorcycle("Java", "a124bb", 110, true, 80);
                transports[2] = new PassengerCar("Toyota", "b222cc", 100, 200);
                transports[3] = new Truck("KamAZ", "z998zz", 80, true, 400);
                transports[4] = new Truck("GAZ", "z999zz", 90, false, 400);
                

                Console.WriteLine("All transport in database: ");
                for (int i = 0; i < n; i++)
                {
                    transports[i].PrintInfo();
                    Console.WriteLine();
                }

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
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }
}
