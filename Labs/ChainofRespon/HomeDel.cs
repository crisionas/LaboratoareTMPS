using System;
using System.Collections.Generic;
using System.Text;

namespace Labs.ChainofRespon
{
    public class HomeDel : DelHandle
    {

        public override void Handle(Receiver receiver)
        {
            if (receiver.HomeDep == true)
            {
                Console.WriteLine("The part will deliver to client's adress.");
            }
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}
