using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDZ_6
{
    abstract class Worker
    {
        public string PIB { set; get; }
        public int age { set; get; }
        
        

        public void Input()
        {
            Console.Write("\nEnter PIB: ");
            PIB = Console.ReadLine();
            Console.Write("Enter age: ");
            age = int.Parse(Console.ReadLine());           
            
        }

        public virtual void Print()
        {
        }
    }

    class President : Worker
    {
        public int experience { set; get; }
        public int educations { get; set; }
        

        public void InputP()
        {
            Input();
            Console.Write(" work experience (in age): ");
            experience = int.Parse(Console.ReadLine());
            Console.Write(" number of educations: ");
            educations = int.Parse(Console.ReadLine());
           
        }

        public override void Print()
        {
            Console.WriteLine($"\nPIB: {PIB}");
            Console.WriteLine($"Age: {age}");        
            Console.WriteLine($"Work experience: {experience}");
            Console.WriteLine($"Number of educations: {educations}");
        }
    }
    class Security : Worker
    {
        public int experience { set; get; }
        public int educations { get; set; }
        

        public void InputS()
        {
            Input();
            Console.Write(" work experience (in age): ");
            experience = int.Parse(Console.ReadLine());
            Console.Write(" number of educations: ");
            educations = int.Parse(Console.ReadLine());
            
        }

        public override void Print()
        {
            Console.WriteLine($"\nPIB: {PIB}");
            Console.WriteLine($"Age: {age}");          
            Console.WriteLine($"Work experience: {experience}");
            Console.WriteLine($"Number of educations: {educations}");
           
        }
    }
    class Manager : Worker
    {
        public int experience { set; get; }
        public int educations { get; set; }
        

        public void InputM()
        {
            Input();
            Console.Write(" work experience (in age): ");
            experience = int.Parse(Console.ReadLine());
            Console.Write("number of educations: ");
            educations = int.Parse(Console.ReadLine());
            
        }

        public override void Print()
        {
            Console.WriteLine($"\nPIB: {PIB}");
            Console.WriteLine($"Age: {age}");          
            Console.WriteLine($"Work experience: {experience}");
            Console.WriteLine($"Number of educations: {educations}");
            
        }
    }
    class Engineer : Worker
    {
        public int experience { set; get; }
        public int educations { get; set; }
        

        public void InputE()
        {
            Input();
            Console.Write(" work experience (in age): ");
            experience = int.Parse(Console.ReadLine());
            Console.Write(" number of educations: ");
            educations = int.Parse(Console.ReadLine());
            
        }

        public override void Print()
        {
            Console.WriteLine($"\nPIB: {PIB}");
            Console.WriteLine($"Age: {age}");           
            Console.WriteLine($"Work experience: {experience}");
            Console.WriteLine($"Number of educations: {educations}");
        }
    }
}
