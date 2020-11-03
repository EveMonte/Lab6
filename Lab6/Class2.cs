using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public abstract partial class Vehicle
    {
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public abstract string Driver();
        public int Speed;
        public decimal FuelConsumption;
    }

    class Controller
    {



        public static void SortByFuelConsumption(List<Vehicle> v)
        {
            //List<Vehicle> V = new List<Vehicle>();
            Vehicle temp;
            for (int i = 0; i < v.Count; i++)
            {
                for (int j = i + 1; j < v.Count; j++)
                {
                    if(v[i].FuelConsumption > v[j].FuelConsumption)
                    {
                        temp = v[j];
                        v[j] = v[i];
                        v[i] = temp;
                    }
                    
                    
                    
                }
            }
        }
        public static void SpeedRange(List<Vehicle> v, int sp1, int sp2)
        {
            for(int i = 0; i < v.Count; i++)
            {
                if((v[i].Speed <= sp2) && (v[i]).Speed >= sp1)
                {
                    Console.WriteLine($"Информация о единице транспорта:\n Скорость:{v[i].Speed} \nРасход топлива: {v[i].FuelConsumption}");
                }
            }
        }
        public static void ReadCollectionFromFile()
        {
            string path = @"C:\Users\User\Desktop\ООП\Lab6\Lab6\TextFile.txt";
            string temp;
            List<string> CollectionOfStrings = new List<string>();
            StreamReader sr = new StreamReader(path);
            do
            {
                temp = sr.ReadLine();
                CollectionOfStrings.Add(temp);
            }
            while (temp != null);
            foreach(string str in CollectionOfStrings)
            {
                Console.WriteLine(str);
            }
        }

    }
    class Class2
    {
    }
}
