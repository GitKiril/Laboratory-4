﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class custom3 : B
    {
        public override void MyName(string name)
        {
            base.MyName(name);
        }
        public override int Sum(int a, int b)
        {
            return base.Sum(a, b);
        }
        public override double Math(int a, int b)
        {
            return a / b;
        }
    }
}
