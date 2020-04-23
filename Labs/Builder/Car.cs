using System;
using System.Collections.Generic;
using System.Text;

namespace Labs.Builder
{
    public class Car
    {
        private List<string> _parts = new List<string>();
        public void Add(string part)
        {
            _parts.Add(part);
        }
        public void Show()
        {
            Console.WriteLine("\nParts avaible:");
            foreach( string part in _parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
