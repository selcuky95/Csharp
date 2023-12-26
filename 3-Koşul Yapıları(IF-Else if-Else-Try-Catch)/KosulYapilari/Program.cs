using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KosulYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string txt = "Life is important";
            if (txt.Count()>5)
            {
                txt.Split();
                Console.WriteLine(txt.Length);
            }
            else
            {
                Console.WriteLine(txt);
            }

            //try
            //{
            //    string txt = "Life is important";
            //    if (txt.Count() > 20)
            //    {
            //        txt.Split();
            //        Console.WriteLine(txt.Length);
            //    }  
            //}
            //catch ()
            //{
            //    Console.WriteLine("The selected text is having smaller number than expected");
            //}
        }
    }
}
