using System;
using System.Collections.Generic;
using System.Text;

namespace Labs.Builder
{
    public class KYB:Parts
    {
        private Car _part = new Car();
        public void Batteries()
        {

        }
        public void Brakes()
        {
            string[] marks = { "Mercedes", "BMW", " Toyota" };
            _part.Add("Disc simplu");
            _part.Add("Plăci de frână");
        }
        public void Antifreezes()
        {
            string[] marks = { "Mercedes", "BMW" };
            _part.Add("Antifreez Rosu");
            _part.Add("Antifreez Albastru");
        }
        public void Cables()
        {
            string[] marks = {" Toyota" };
            _part.Add("Cabluri Audio");
            _part.Add("Cabluri electrice");
        }
        public void Clutch()
        {
            string[] marks = { " Toyota" };
            _part.Add("Ambreiaj");
        }
        public void Filters()
        {
            string[] marks = { "Mercedes", "BMW" };
            _part.Add("Filtru ulei");
            _part.Add("Filtru salon");
            _part.Add("Filtru combustibil");
        }
        public void Lubricants()
        {
           
        }
        public Car GetCar()
        {
            return _part;
        }
    }
}
