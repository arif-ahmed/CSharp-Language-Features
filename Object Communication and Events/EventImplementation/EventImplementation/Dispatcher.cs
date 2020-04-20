using System;
using System.Collections.Generic;
using System.Text;

namespace EventImplementation
{
    public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs args);
    public class Dispatcher
    {
        private string _name;
        public event NameChangeEventHandler NameChange;

        public string Name
        {
            get => _name;
            set
            {
                OnNameChange(new NameChangeEventArgs(value));
            }
        }

        public void OnNameChange(NameChangeEventArgs args)
        {
            NameChange(this, args);
        }
    }
}
