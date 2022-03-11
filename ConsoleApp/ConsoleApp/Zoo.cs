using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Zoo : IEnumerable
    {
        Zoo[] zoo = null;

        public Zoo()
        {
            zoo = new Zoo[0];
        }
        public IEnumerator GetEnumerator()
        {
            foreach (var animal in zoo)
            {
                if (animal == null)
                    break;
                yield return animal;
            }
        }
    }
}
