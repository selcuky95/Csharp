using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLoopKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(i);
            }

            Console.WriteLine();

            string letters = "Life is important";
            letters.Split(' ');
            for (int i = 0; i < letters.Length; i++)
            {
                Console.Write(i);
            }
            Console.ReadKey();
        }
    }
}
