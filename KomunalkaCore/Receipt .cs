using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomunalkaCore
{
    class Receipt
    {
        int num;
        double tarif, sum = 0;
        
        
        public Receipt(int a, double b)
        {
            num = a;
            tarif = b;
        }

        public virtual int setNum
        {
            set
            {
                num = value;
            }
        }
        public virtual double setTarif
        {
            set
            {
                tarif = value;
            }
        }
        public virtual double getSum()
        {
            sum = num * tarif;
            return sum;
        }

    }
}
