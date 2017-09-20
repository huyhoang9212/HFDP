using DuckSimulator.Behaviors;
using DuckSimulator.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck reallyDuck = new ReallyDuck();
            reallyDuck.Display();
            reallyDuck.PerformQuack();
            reallyDuck.PerformFly();

            Console.WriteLine("--------------------------------------");
            Duck modelDuck = new ModelDuck();
            modelDuck.SetFlyBehavior(new FlyRocketPowered());
            modelDuck.PerformFly();

            modelDuck.SetQuackBehavior(new Squeak());
            modelDuck.PerformQuack();
        }
    }
}
