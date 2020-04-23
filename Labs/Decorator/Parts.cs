using Labs.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labs.Decorator
{
    public abstract class Parts
    {

        protected Parts(string n)
        {
            this.Name = n;
        }
        public string Name;
        public abstract void Batteries();
        public abstract void Brakes();
        public abstract void Antifreezes();
        public abstract void Cables();
        public abstract void Clutch();
        public abstract void Filters();
        public abstract void Lubricants();
        public abstract Car GetCar();
    }
}
