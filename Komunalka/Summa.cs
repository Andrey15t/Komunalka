using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komunalka
{
    class Summa
    {
        double summa = 0;
        public Summa()
        {

        }

        public double getSumma(double a,double b, double c)
        {
            summa = a + b + c;
            return summa;
        }
    }
}
