using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Reptile : Animal
    {
        public override void Move()
        {
            Console.WriteLine("I am walking and swimming");
        }

        protected override Animal CreateClone()
        {
            return new Reptile();
        }
    }
}
