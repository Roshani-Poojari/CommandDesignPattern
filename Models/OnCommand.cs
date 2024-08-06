using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.Models
{
    internal class OnCommand:ICommand
    {
        private Television _tv;
        public OnCommand(Television tv)
        {
            _tv = tv;
        }
        public void Execute()
        {
            _tv.On();
        }
    }
}
