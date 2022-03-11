using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Bird : Animal
    {
        public override void Move()
        {
            Console.WriteLine("I am walking and flying");
        }

        protected override Bird CreateClone()
        {
            return new Bird();
        }
    }
}
