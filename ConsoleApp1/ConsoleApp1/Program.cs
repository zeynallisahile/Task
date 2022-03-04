using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "";
                Console.WriteLine("Bir ay daxil edin:");
                x = Console.ReadLine();
                switch (x)
                {
                    case "yanvar":
                    Console.WriteLine(x + " ayinda 31 gun Var");
                    break;
                    case "mart":
                    Console.WriteLine(x + " ayinda 31 gun Var");
                    break;
                    case "may":
                    Console.WriteLine(x + " ayinda 31 gun Var");
                    break;
                    case "iyul":
                    Console.WriteLine(x + " ayinda 31 gun Var");
                    break;
                    case "avgust":
                    Console.WriteLine(x + " yinda 31 gun Var");
                    break;
                    case "oktiyabr":
                    Console.WriteLine(x + " ayinda 31 gun Var");
                    break;
                    case "dekabr":
                    Console.WriteLine(x + " ayinda 31 gun Var");
                    break;

                    case "aprel":
                    Console.WriteLine(x + " ayinda 30 gun Var");
                    break;
                    case "iyun":
                    Console.WriteLine(x + " ayinda 30 gun Var");
                    break;
                    case "sentiyabr":
                    Console.WriteLine(x + " ayinda 30 gun Var");
                    break;
                    case "noyabr":
                    Console.WriteLine(x + " ayinda 30 gun Var");
                    break;

                    case "fevral":
                    Console.WriteLine(x + " ayinda 28 veya 29 gun Var");
                    break;
                    default:
                        Console.WriteLine("Ay duzgun daxil edilmeyib");
                        break;
                }
        }
    }
}
