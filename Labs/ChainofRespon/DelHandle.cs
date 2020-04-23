using System;
using System.Collections.Generic;
using System.Text;

namespace Labs.ChainofRespon
{
    public abstract class DelHandle
    {
        public DelHandle Successor { get; set; }
        public abstract void Handle(Receiver receiver);
    }
}
