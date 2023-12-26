using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodOlusturma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(); // is a method of Console Class that takes +18 overloads 
            Console.ReadKey(); // 1 overload

            string txt = "Even a single life is important";
            txt.Trim();
            txt.Replace(" ", "");
            txt.Substring(7,txt.Length);
            txt.Contains(" ");
            txt.ToCharArray();

            int number = 15;
            double number2 = 12.1;
            Math.Sqrt(number);
            Math.Round(number2);
            Math.Min(number,number2);
            Math.Max(number,number2);
            Math.Ceiling(number2);
            Math.Floor(number2);
            Math.Abs(number2);
        }
    }
}
