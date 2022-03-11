using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal abstract class Animal : ICloneable
    {
        private int Age
        {
            get;
            set;
        }

        protected abstract Animal CreateClone();

        public virtual object Clone()
        {
            Animal clone = CreateClone();
            clone.Age = this.Age;
            return clone;
        }

        public virtual void Move()
        {

        }
    }
}
