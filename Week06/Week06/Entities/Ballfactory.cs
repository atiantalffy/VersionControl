﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week06
{
    public class Ballfactory : IToyFactory
    {
        public Toy CreateNew()
        {
            return new Ball();
        }
    }
}
