using System;
using System.Collections.Generic;
using System.Text;

namespace Labs.Decorator
{
    public abstract class PartsDecorator : Parts
    {
        protected Parts parts;
        private string v;

        //protected PartsDecorator(string v)
        //{
        //    this.v = v;
        //}

        //public PartsDecorator(string n, Parts parts) : base(n)
        //{
        //    this.parts = parts;
        //}

        public PartsDecorator(string n) : base(n)
        {
        }
    }
}
