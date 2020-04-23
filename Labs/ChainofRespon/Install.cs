using System;
using System.Collections.Generic;
using System.Text;

namespace Labs.ChainofRespon
{
    public class Install : DelHandle
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.Install == true)
            {
                Console.WriteLine("The part will be installed in our service.");
            }
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}
