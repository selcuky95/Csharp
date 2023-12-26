using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOlusturma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Calisan> calisanlar = new List<Calisan>
            {
                new Calisan() {Name = "Sema", Surname= "Yılmaz"},
                new Calisan() {Name = "Selçuk", Surname= "Yılmaz"}
            };

            var siraliListe = calisanlar.OrderBy(x => x.Name).ThenBy(x => x.Surname).ToList();
            foreach (Calisan item in siraliListe)
            {
                Console.WriteLine(item.Name+" "+item.Surname);

            }
            Console.ReadKey();
            // sei kai :) (doğru)
        }
    }
}
