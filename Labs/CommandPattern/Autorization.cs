using System;
using System.Collections.Generic;
using System.Text;

namespace Labs.CommandPattern
{
    public class Autorization
    {
        public void ExecuteCommand(ICommand cmd)
        {
            if(cmd.CanExecute)
            {
                cmd.Execute();
            }
            else
            {
                Console.WriteLine("You don't have acces to {0} command.", cmd.Name);
            }
        }
    }
}
