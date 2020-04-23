using System;
using System.Collections.Generic;
using System.Text;

namespace Labs.Builder
{
    public interface Parts
    {
        public void Batteries();
        public void Brakes();
        public void Antifreezes();
        public void Cables();
        public void Clutch();
        public void Filters();
        public void Lubricants();
        public Car GetCar();
    }
}
