using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDZ_6
{
    class Device
    {
        public string name { get; set; }
        public int year_made { get; set; }
        public int money { get; set; }

        public Device(string name, int year_made, int money)
        {
            this.name = name;
            this.year_made = year_made;
            this.money = money;
        }
    }

    class Kettle : Device
    {
        public Kettle(string name, int year_made, int money) : base(name, year_made, money)
        {
        }
        public void Input()
        {
            Console.Write("name of device: ");
            name = Console.ReadLine();
            Console.Write("Enter year of made the device: ");
            year_made = int.Parse(Console.ReadLine());
            Console.Write("Enter price of device: ");
            money = int.Parse(Console.ReadLine());
        }
        public void Sound()
        {
            Console.WriteLine("pshhh");
        }
        public void Show()
        {
            Console.WriteLine($"\nName: {name}");
        }
        public void Desc()
        {
            Console.WriteLine($"\nYear of made: {year_made}");
            Console.WriteLine($"Money: {money}");
        }
    }
    class Microwave : Device
    {
        public Microwave(string name, int year_made, int money) : base(name, year_made, money)
        {
        }
        public void Input()
        {
            Console.Write("name of device: ");
            name = Console.ReadLine();
            Console.Write("Enter year of made the device: ");
            year_made = int.Parse(Console.ReadLine());
            Console.Write("Enter price of device: ");
            money = int.Parse(Console.ReadLine());
        }
        public void Sound()
        {
            Console.WriteLine("peak");
        }
        public void Show()
        {
            Console.WriteLine($"\nName: {name}");
        }
        public void Desc()
        {
            Console.WriteLine($"\nYear of made: {year_made}");
            Console.WriteLine($"Money: {money}");
        }
    }
    class Car : Device
    {
        public Car(string name, int year_made, int money) : base(name, year_made, money)
        {
        }
        public void Input()
        {
            Console.Write(" name of device: ");
            name = Console.ReadLine();
            Console.Write("Enter year of made the device: ");
            year_made = int.Parse(Console.ReadLine());
            Console.Write("Enter price of device: ");
            money = int.Parse(Console.ReadLine());
        }
        public void Sound()
        {
            Console.WriteLine("Bip");
        }
        public void Show()
        {
            Console.WriteLine($"\nName: {name}");
        }
        public void Desc()
        {
            Console.WriteLine($"\nYear of made: {year_made}");
            Console.WriteLine($"Money: {money}");
        }
    }
    class Streamer : Device
    {
        public Streamer(string name, int year_made, int money) : base(name, year_made, money)
        {
        }
        public void Input()
        {
            Console.Write("name of device: ");
            name = Console.ReadLine();
            Console.Write("Enter year of made the device: ");
            year_made = int.Parse(Console.ReadLine());
            Console.Write("Enter price of device: ");
            money = int.Parse(Console.ReadLine());
        }
        public void Sound()
        {
            Console.WriteLine("Bip-shee");
        }
        public void Show()
        {
            Console.WriteLine($"\nName: {name}");
        }
        public void Desc()
        {
            Console.WriteLine($"\nYear of made: {year_made}");
            Console.WriteLine($"Money: {money}");
        }
    }
}
