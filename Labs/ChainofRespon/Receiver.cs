using System;
using System.Collections.Generic;
using System.Text;

namespace Labs.ChainofRespon
{
    public class Receiver
    {
        public bool HomeDep { get; set; }
        public bool GetStore { get; set; }
        public bool Install { get; set; }
        public Receiver(bool h,bool s,bool i)
        {
            HomeDep = h;
            GetStore = s;
            Install = i;
        }
    }
}
