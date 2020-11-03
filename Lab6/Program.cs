using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab6;

namespace Lab6
{
    public interface IMovable
    {
        bool IsThereAnEngine();

        int Wheels { get; set; }
        string Driver();
    }
    
    public struct Conveyor
    {
        public string Company;
        public enum Number : int
        {
            first = 1, second, third, forth, fifth, sixth, seventh, eighth, nineth
        }
    }

    public class Car : Vehicle, IMovable
    {
        public Car()
        {
            int Power;
            Console.WriteLine("Введите мощность двигателя");
            Power = Convert.ToInt32(Console.ReadLine());
            Engine engine = new Engine(Power);
        }

        public override string Driver()
        {
            return "Водитель управляет автомобилем";
        }
        public bool IsThereAnEngine()
        {
            return true;
        }
        public override string ToString()
        {
            string Str = "_5lab.Car Override Method";
            return Str;
        }
        string IMovable.Driver()
        {
            return "Переопределенный метод интерфейса, вызванный в классе Car";
        }
    }

    public class Train : Vehicle, IMovable
    {
        public Train()
        {
            int Power;
            Console.WriteLine("Введите мощность двигателя");
            Power = Convert.ToInt32(Console.ReadLine());
            Engine engine = new Engine(Power);
            
    }

        public override string Driver()
        {
            return "Поездом управляет машинист";
        }

        string IMovable.Driver()
        {
            return "Переопределенный метод интерфейса, вызванный в классе Train";
        }
        public bool IsThereAnEngine()
        {
            return true;
        }
        public override string ToString()
        {
            string Str = "_5lab.Train Override Method";
            return Str;
        }
    }

    public class Wagon : Train, IMovable
    {
        public override string ToString()
        {
            string Str = "_5lab.Wagon Override Method";
            return Str;
        }
    }

    public class Express : Train, IMovable
    {
        public override string ToString()
        {
            string Str = "_5lab.Express Override Method";
            return Str;
        }
    }

    //sealed
    sealed class Engine
    {
        int Power;
        public Engine(int Power)
        {
            this.Power = Power;
        }
        public override string ToString()
        {
            string Str = "_5lab.Car Override Method";
            return Str;
        }
    }
    public class Printer
    {
        public string IAmPrinting(IMovable InterfaceObJect)
        {

            return InterfaceObJect.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.FuelConsumption = 10;
            car.Speed = 250;
            Train train = new Train();
            train.FuelConsumption = 250;
            train.Speed = 140;
            Wagon wagon = new Wagon();
            wagon.FuelConsumption = 0;
            wagon.Speed = 0;
            Express express = new Express();
            express.FuelConsumption = 350;
            express.Speed = 200;

            Console.WriteLine(car.ToString());
            Console.WriteLine(car.GetHashCode());
            Console.WriteLine(car.Equals(car));
            Console.WriteLine("car is Car: " + (car is Car));
            Console.WriteLine("train is Train: " + (train is Train));
            Console.WriteLine("wagon is Vehicle: " + (wagon is Vehicle));

            List<IMovable> Locomotive = new List<IMovable>();
            Locomotive.Add(new Train());
            Locomotive.Add(new Wagon());
            Locomotive.Add(new Car());
            Locomotive.Add(new Wagon());
            Locomotive.Add(new Express());

            Printer printer = new Printer();
            foreach (IMovable Obj in Locomotive)
            {
                Console.WriteLine(printer.IAmPrinting(Obj));
            }

            Conveyor conv = new Conveyor();
            conv.Company = "Yellow Submarine Ltd.";
            Console.WriteLine("Какую конвеерную ленту хотите запустить? (1-9)");
            int choice;
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case (int)Conveyor.Number.first:
                    Console.WriteLine("Вы запустили конвеер 1.");
                    break;
                case (int)Conveyor.Number.second:
                    Console.WriteLine("Вы запустили конвеер 2.");
                    break;
                case (int)Conveyor.Number.third:
                    Console.WriteLine("Вы запустили конвеер 3.");
                    break;
                case (int)Conveyor.Number.forth:
                    Console.WriteLine("Вы запустили конвеер 4.");
                    break;
                case (int)Conveyor.Number.fifth:
                    Console.WriteLine("Вы запустили конвеер 5.");
                    break;
                case (int)Conveyor.Number.sixth:
                    Console.WriteLine("Вы запустили конвеер 6.");
                    break;
                case (int)Conveyor.Number.seventh:
                    Console.WriteLine("Вы запустили конвеер 7.");
                    break;
                case (int)Conveyor.Number.eighth:
                    Console.WriteLine("Вы запустили конвеер 8.");
                    break;
                case (int)Conveyor.Number.nineth:
                    Console.WriteLine("Вы запустили конвеер 9.");
                    break;
            }

            TransportAgency.Add(car);
            TransportAgency.Add(wagon);
            TransportAgency.Add(train);
            TransportAgency.Add(express);
            TransportAgency.Output();

            Console.WriteLine("\nПосле выборки по скорости:");
            Controller.SpeedRange(TransportAgency.Vehicles, 150, 260);

            Controller.SortByFuelConsumption(TransportAgency.Vehicles);
            Console.WriteLine("\nПосле соритровки по расходу топлива:");
            TransportAgency.Output();

        }
    }
}
