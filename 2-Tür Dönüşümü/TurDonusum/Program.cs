using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TurDonusum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            string num2 = num.ToString();
            long num3 = long.Parse(num2.ToString());
            double num4= double.Parse(num3.ToString());
            float num5 = float.Parse(num4.ToString());
            decimal num6 = decimal.Parse(num5.ToString());
            
            Console.WriteLine(num6);
            Console.ReadKey();
        }
    }
}
