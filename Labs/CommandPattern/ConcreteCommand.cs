using System;
using System.Collections.Generic;
using System.Text;

namespace Labs.CommandPattern
{
    public class AddRecord:ICommand
    {
        private CReceiver _receiver;
        public void AddCommmand( CReceiver receiver)
        {
            _receiver = receiver;
        }
        public bool CanExecute
        {
            get { return true; }
        }
        public string Name
        {
            get { return "AddRecord"; }
        }
        public void Execute()
        {
            _receiver.AddProduct();
        }
    }
    public class UpdateCommand:ICommand
    {
        private CReceiver _receiver;
        public UpdateCommand(CReceiver receiver)
        {
            _receiver = receiver;
        }
        public bool CanExecute
        {
            get { return true; }
        }
        public string Name
        {
            get { return "Update"; }
        }
        public void Execute()
        {
            _receiver.UpdateProduct();
        }
    }
    public class DeleteCommand:ICommand
    {
        private CReceiver _receiver;
        public DeleteCommand(CReceiver receiver)
        {
            _receiver = receiver;
        }
        public bool CanExecute
        {
            get { return true; }
        }
        public string Name
        {
            get { return "Delete"; }
        }
        public void Execute()
        {
            _receiver.DeleteProduct();
        }
    }
    public class View1Command:ICommand
    {
        private CReceiver _receiver;
        public View1Command(CReceiver receiver)
        {
            _receiver = receiver;
        }
        public bool CanExecute
        {
            get { return true; }
        }
        public string Name
        {
            get { return "View"; }
        }
        public void Execute()
        {
            _receiver.ViewProducts();
        }
    }
}
