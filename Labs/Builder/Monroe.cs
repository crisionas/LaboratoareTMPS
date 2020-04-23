using System;
using System.Collections.Generic;
using System.Text;

namespace Labs.Builder
{
    class Monroe:Parts
    {
        private Car _part = new Car();
        public void Batteries()
        {
            string[] marks = { "Mercedes", "BMW", " Toyota" };
            _part.Add("Baterie 1400W");
            _part.Add("Baterie 1200W");
            _part.Add("Baterie 1000W");
        }
        public void Brakes()
        {
            string[] marks = { "Mercedes", "BMW", " Toyota" };
            _part.Add("Disc simplu");
            _part.Add("Plăci de frână");
        }
        public void Antifreezes()
        {
            string[] marks = { "Mercedes", "BMW","Toyota" };
            _part.Add("Antifreez Rosu");
            _part.Add("Antifreez Verde");
            _part.Add("Antifreez Galben");
        }
        public void Cables()
        {
            string[] marks = { "Mercedes" };
            _part.Add("Cabluri Audio");
            _part.Add("Cabluri electrice");
        }
        public void Clutch()
        {
            string[] marks = { "Mercedes", "BMW"," Toyota" };
            _part.Add("Ambreiaj");
        }
        public void Filters()
        {
            string[] marks = { "Mercedes", "BMW", " Toyota" };
            _part.Add("Filtru ulei");
            _part.Add("Filtru salon");
            _part.Add("Filtru combustibil");
        }
        public void Lubricants()
        {
            string[] marks = { "Mercedes", "BMW", " Toyota" };
            _part.Add("Ulei 5W-30");
            _part.Add("Ulei 5W-40");
            _part.Add("Ulei 5W-20");
            _part.Add("Ulei 10W-40");
            _part.Add("Ulei 10W-1");

        }
        public Car GetCar()
        {
            return _part;
        }
    }
}
