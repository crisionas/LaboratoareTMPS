using Labs.CommandPattern;
using Labs.Singletone;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labs.Proxy
{
    public class Proxy : IView
    {
        CReceiver receive;
        public override void ViewProducts()
        {
            if (receive == null)
                receive = new CReceiver();
            receive.ViewProducts();
        }
    }
}
