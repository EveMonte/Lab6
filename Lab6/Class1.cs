using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Lab6
{
    public abstract partial class Vehicle
    {
        public int Wheels { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    class TransportAgency
    {
        public static List<Vehicle> Vehicles = new List<Vehicle>();
        public static List<Vehicle> vehicles { get; set; }

        public static bool Remove(Vehicle vehicle)
        {
            foreach (Vehicle elem in Vehicles)
            {
                if(vehicle == elem)
                {
                    Vehicles.Remove(vehicle);
                    return true;
                }
            }
            return false;
        }

        public static void Add(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
            Console.WriteLine($"Вы добавили в список элемент {vehicle.Wheels}");
        }

        public static void Output()
        {
            Console.WriteLine("Количество колес транспорта:");
            foreach (Vehicle vehicle in Vehicles)
            {
                Console.WriteLine($"Информация о единице транспорта:\n Скорость:{vehicle.Speed} \nРасход топлива: {vehicle.FuelConsumption}");
            }
        }
    }
    public class JsonTester
    {
        public int Number;
        public string Str { get; set; }

        public JsonTester(int number, string str) {
            Number = number;
            Str = str;
        }

    }
        class Class1
    {
        
    }
}
