using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Collections;
namespace ProjectCLIBMI
{
    class BMICLI
    {
        static void Main(string[] args)
        {  
            RunMetohds(args);
        } 
        public static void BmiCalc(double hight, double weight)
        {
            double bmi = weight / Math.Pow(hight, 2);
            double roundBmi =    Math.Round(bmi);
            Console.WriteLine($"Your Bmi Score is:\n{roundBmi}");

            if(bmi <= 18.4)
            Console.WriteLine("Your Status is: Underweight");
            else if(18.5 <= bmi ||  bmi <= 24.9)
            Console.WriteLine("Your Status is: Normal");
            else if(25.0 <= bmi || bmi <= 39.9)
            Console.WriteLine("Your Status is: Overweight");
            else if(bmi >= 40.0)
            Console.WriteLine("Your Status is: Obese");
        }
        public static void GiveValueToBmi1(string[] args)
        {
            double height, weight;

            height = Convert.ToDouble(args[2]);
            weight = Convert.ToDouble(args[4]);

            BmiCalc(height, weight);         
        }  
        public static void GiveValueToBmi2(string[] args)
        {
            double height, weight;

            weight = Convert.ToDouble(args[2]);
            height = Convert.ToDouble(args[4]);

            BmiCalc(height, weight);         
        }
        static void ProgramShowHelp()
        {
            string space = " ".PadRight(8);
            Console.Write($"Use these switch to run program:\n--height");
            Console.Write(space);
            Console.Write("Your height (centimeters)\n--weight");
            Console.Write(space);
            Console.Write("Your weight (kilograms)\n--version");
            Console.Write(space);
            Console.Write("Show current version\n--help");
            Console.Write(space);
            Console.Write("Show command list");
        }
        static void ProgramShowVersion()
        {
            Console.WriteLine("Current version is: 1.0");
        }
        public static void RunMetohds(string[] args)
        {
            if(args[0] == "bmi")
            {
                if(args.Length == 5  && args[1] == "--height" && args[3] == "--weight")
                {
                    GiveValueToBmi1(args);
                }
                else if(args.Length == 5  && args[1] == "--weight" && args[3] == "--height")
                {
                    GiveValueToBmi2(args);
                }
                else if(args.Length == 2  && args[1] == "--helps")
                {
                    ProgramShowHelp();
                }
                else if(args.Length == 2  && args[1] == "--versions")
                {
                    ProgramShowVersion();
                }
                else
                {
                    Eror();
                }
            }
            else
            {
                Eror();
            }
        }
        public static void Eror()
        {
            Console.WriteLine("Invalid command :(\nUse --helps switch to show help");
        }
    }    
}

