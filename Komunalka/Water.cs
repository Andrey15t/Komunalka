﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komunalka
{
    class Water : Receipt
    {

        public Water(int a, double b):base(a,b)
        {

        }

        public override int setNum
        {
            set
            {
                base.setNum = value;
            }
        }
        public override double setTarif
        {
            set
            {
                base.setTarif = value;
            }
        }
        public override double getSum()
        {
            return base.getSum();
        }
    }
}
