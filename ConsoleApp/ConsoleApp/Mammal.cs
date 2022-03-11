using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Mammal : Animal
    {
        public override void Move()
        {
            Console.WriteLine("I am running and swimming");
        }

        protected override Animal CreateClone()
        {
            return new Mammal();
        }
    }
}
