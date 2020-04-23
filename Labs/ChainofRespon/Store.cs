using System;
using System.Collections.Generic;
using System.Text;

namespace Labs.ChainofRespon
{
    public class Store:DelHandle
    {


        public override void Handle(Receiver receiver)
        {
            if (receiver.GetStore == true)
            {
                Console.WriteLine("The part will deliver to our store.");
            }
            else if (Successor != null)
               Successor.Handle(receiver);
        }
       
      
    }
}
