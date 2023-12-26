using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Class2:Class1
    {
        public static double TurnUpTotal(double cost,double extra)
        {
            double standardMem = cost * extra;
            return standardMem;
        }
        // Params method can be used in this instance;
        public static double TurnUpTotal(double cost, double extra,double otv)
        { 
            double normal = cost * (extra+otv);
            return normal;
        }
        public static double TurnUpTotal(double cost, double extra, double otv,double excEquip)
        {
            double vip = cost * (extra+otv+excEquip);
            return vip;
        }
    }
}
