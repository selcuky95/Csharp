using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inheriting properties in Class1 and adding them into the method in Class2  
            // At the last part, sum of these processes are used in Program.cs
            
            


            
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please insert a budget");
                double accountPrice = int.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Please make your choice from these options (1,2,3,4)");
                Console.WriteLine("1-Standard Membership");
                Console.WriteLine("2-Normal Membership");
                Console.WriteLine("3-VIP Membership");
                Console.WriteLine("4-Exit");
                string secim = Console.ReadLine();
                
                switch (secim)
                {
                    case "1":
                        int standardCost = 3000;
                        double standardExt = 1.4;
                        Console.WriteLine("Standard Membership");                        
                        Console.WriteLine("2000$ for a Standard Membership.Do you want to open a new Membership?");
                        
                        System.Threading.Thread.Sleep(2000);
                        if (accountPrice > standardCost)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            double cost1 = Class2.TurnUpTotal(standardCost, standardExt);
                            Console.WriteLine("Current budget: ",accountPrice-cost1);
                            Console.WriteLine("Welcome to the 70KG GYM Sports");
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Insufficient Funds");  
                        }
                        break;

                    case "2":
                        int normalCost = 4000;
                        double normalExt = 1.4;
                        double otv = 1.4;
                        Console.WriteLine("Normal Membership");
                        Console.WriteLine("4000$ for a Standard Membership.Do you want to open a new Membership?");
                        
                        System.Threading.Thread.Sleep(2000);

                        if (accountPrice > 4000)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            double cost2 = Class2.TurnUpTotal(normalCost, normalExt, otv);
                            Console.WriteLine("Current budget: ",accountPrice-cost2);
                            Console.WriteLine("Welcome to the 70KG GYM Sports");
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Insufficient Funds");
                        }
                        break;

                    case "3":
                        int vipCost = 6000;
                        double vipExt = 1.4;
                        double otv2 = 1.0;
                        double excEquip = 0.6;
                        Console.WriteLine("VIP Membership");
                        Console.WriteLine("6000$ for a Standard Membership.Do you want to open a new Membership?");
                        
                        System.Threading.Thread.Sleep(2000);
                        if (accountPrice > 8000)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            double cost3 = Class2.TurnUpTotal(vipCost, vipExt, otv2,excEquip);
                            Console.WriteLine("Current budget: ", accountPrice - cost3);;
                            Console.WriteLine("Welcome to the 70KG GYM Sports");
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Insufficient Funds");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Exiting from application.Thank you for your participation :)");                        
                        break;
                    default:
                        Console.WriteLine("Please insert one of the responsive buttons mentioned above!");
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        break;
                }
            } while (true);
            
            
        }
    }
}
