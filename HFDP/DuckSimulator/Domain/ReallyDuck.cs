using DuckSimulator.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator.Domain
{
    public class ReallyDuck : Duck
    {
        public ReallyDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new Quack();
        }
        public override void Display()
        {
            Console.WriteLine("I am a really Duck");

        }
    }
}
