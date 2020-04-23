using System;
using System.Collections.Generic;
using System.Text;

namespace Labs.Decorator
{
    public class User1
    {
        //Assemble all parts
        public void assembly(Parts parts)
        {
            parts.Antifreezes();
            parts.Batteries();
            parts.Brakes();
            parts.Cables();
            parts.Clutch();
            parts.Lubricants();
            parts.Filters();
        }
    }
}
