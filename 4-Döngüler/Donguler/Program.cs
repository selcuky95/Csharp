using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool error = false;
            do
            {
                int num = int.Parse(Console.ReadLine());
                if (num > 20)
                {
                    Console.WriteLine("1 ile 20 arasında sayı giriniz");
                    error = true;
                }
                for (int i = 0; i <= 20; i++)
                {
                    Console.WriteLine(i);
                    while (i > 10)
                    {
                        Console.CursorSize = 10;
                        Console.BackgroundColor= ConsoleColor.Red;
                        Console.ForegroundColor= ConsoleColor.DarkMagenta;
                        error = false; 
                    }
                    error = false;
                }
            } while (true);
            
   
        }
    }
}
