﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator.Behaviors
{
    public class MuteQuack : IQuackBehavior
    {
        public void MakeQuack()
        {
            Console.WriteLine("Silence");
        }
    }
}
