﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDZ_6
{
    class Music
    {
        public string name { get; set; }
        public int year_made { get; set; }
        public int money { get; set; }

        public Music(string name, int year_made, int money)
        {
            this.name = name;
            this.year_made = year_made;
            this.money = money;
        }
    }

    class Violin : Music
    {
        public Violin(string name, int year_made, int money) : base(name, year_made, money)
        {
        }
        public void Input()
        {
            Console.Write(" name of violin: ");
            name = Console.ReadLine();
            Console.Write("Enter year of made the violin: ");
            year_made = int.Parse(Console.ReadLine());
            Console.Write("Enter price of violin: ");
            money = int.Parse(Console.ReadLine());
        }
        public void Sound()
        {
            Console.WriteLine("screech");
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
        public void History()
        {
            Console.WriteLine("\nThe first references to the violin date back to the 16th century in Italy");
        }
    }
    class Trombone : Music
    {
        public Trombone(string name, int year_made, int money) : base(name, year_made, money)
        {
        }
        public void Input()
        {
            Console.Write(" name of trombone: ");
            name = Console.ReadLine();
            Console.Write("Enter year of made the trombone: ");
            year_made = int.Parse(Console.ReadLine());
            Console.Write("Enter price of trombone: ");
            money = int.Parse(Console.ReadLine());
        }
        public void Sound()
        {
            Console.WriteLine("tre");
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
        public void History()
        {
            Console.WriteLine("\nThe trombone was developed in Italy in the 16th century");
        }
    }
    class Ukulele : Music
    {
        public Ukulele(string name, int year_made, int money) : base(name, year_made, money)
        {
        }
        public void Input()
        {
            Console.Write(" name of ukulele: ");
            name = Console.ReadLine();
            Console.Write("Enter year of made the ukulele: ");
            year_made = int.Parse(Console.ReadLine());
            Console.Write("Enter price of ukulele: ");
            money = int.Parse(Console.ReadLine());
        }
        public void Sound()
        {
            Console.WriteLine("Дзинь");
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
        public void History()
        {
            Console.WriteLine("\nThe ukulele was created in Hawaii in the 19th century");
        }
    }
    class Cello : Music
    {
        public Cello(string name, int year_made, int money) : base(name, year_made, money)
        {
        }
        public void Input()
        {
            Console.Write(" name of cello: ");
            name = Console.ReadLine();
            Console.Write("Enter year of made the cello: ");
            year_made = int.Parse(Console.ReadLine());
            Console.Write("Enter price of cello: ");
            money = int.Parse(Console.ReadLine());
        }
        public void Sound()
        {
            Console.WriteLine("mele");
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
        public void History()
        {
            Console.WriteLine("\nThe cello originated in the middle of the 16th century in Italy");
        }
    }
}
