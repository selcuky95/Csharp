using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // My ForEachLoop example :)

            // On this instance, We want amount of the numbers as much as user wants,
            
            Console.WriteLine("Please give an amount");
            int num = int.Parse(Console.ReadLine());

            // We must open up an array to log these numbers in 
            int[] numbers = new int[num];
            // The reason why I entered "num" is that ; when we give the numbers from the user,
            // these will enter into the int [] numbers

            // and Now, i can use my number [] in the collection segment of my For Each and For Loop***

            //Before opening my loop, I need to open 2 new variable as "average" and "sum" both having "0", and
            // I want to include sum in the loop and the average will be effective before writing down

            // so we open up our For each loop
            
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Please give the number: ");          // Here, I want the numbers from user
                numbers[i] = int.Parse(Console.ReadLine());                                     
            }
            foreach (var item in numbers)                         // I use my "average" to hold the numbers(item) here and make the calculation
            {
                sum += item;
            }
            // We use double in case the result gives many digits
            double average = sum / num;
            Console.WriteLine("The average is: "+average);        // The only thing left is to write it down
            Console.ReadKey();
        }
    }
}
