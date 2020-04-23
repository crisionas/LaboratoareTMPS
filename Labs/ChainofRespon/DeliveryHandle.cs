using System;
using System.Collections.Generic;
using System.Text;

namespace Labs.ChainofRespon
{
    public interface IDeliveryHandle
    {
        public IDeliveryHandle Successor { get; set; }
        public abstract void Handle(Receiver receiver);
    }
}
