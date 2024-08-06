using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.Models
{
    internal class Television
    {
        public void On()
        {
            Console.WriteLine("Television is switched on");
        }
        public void Off()
        {
            Console.WriteLine("Television is switched off");
        }
    }
}
