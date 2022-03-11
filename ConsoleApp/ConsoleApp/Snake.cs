using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Snake : Reptile
    {
        public void Move(int speed)
        {
            base.Move();
            Console.WriteLine("I can reach {0} km/h", speed);
        }
    }
}
