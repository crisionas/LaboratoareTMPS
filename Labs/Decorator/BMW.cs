﻿
using Labs.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labs.Decorator
{
    public class BMW : PartsDecorator
    {
        public BMW() : base("BMW")
        { }
        private Car _part = new Car();
        public override void Antifreezes()
        {
            _part.Add("BMW Coolant (DARK BLUE)");
        }

        public override void Batteries()
        {
            _part.Add("Varta");
        }

        public override void Brakes()
        {
            _part.Add("Brembo Brakes");
            _part.Add("Plăci de frână");
        }

        public override void Cables()
        {
            _part.Add("Cabluri Audio");
            _part.Add("Cabluri electrice");
        }

        public override void Clutch()
        {
            _part.Add("Ambreiaj");
        }

        public override void Filters()
        {
            _part.Add("Filtru ulei");
            _part.Add("Filtru salon");
            _part.Add("Filtru combustibil");
        }

        public override Car GetCar()
        {
            return _part;
        }

        public override void Lubricants()
        {
            _part.Add("Ulei 5W-30");
        }
    }
}
