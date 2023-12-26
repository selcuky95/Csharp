using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorYapisi
{
    internal class Class1
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int ID { get; set; }
        public int BankNumber { get; set; }

        List
        public void FullName(string ad, string soyad)
        {
            Name = ad; Surname = soyad;
            string TamAd = string.Format("Name Surname: {0}{1}", Name, Surname,ID,BankNumber);
        }
    }
}
