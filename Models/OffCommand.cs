using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.Models
{
    internal class OffCommand:ICommand
    {
        private Television _tv;
        public OffCommand(Television tv)
        {
            _tv = tv;
        }
        public void Execute()
        {
            _tv.Off();
        }
    }
}
