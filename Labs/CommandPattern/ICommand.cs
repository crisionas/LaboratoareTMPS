using System;
using System.Collections.Generic;
using System.Text;

namespace Labs.CommandPattern
{
    public interface ICommand
    {
        bool CanExecute { get; }
        string Name { get; }
        void Execute();
    }
}
