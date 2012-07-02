using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class WinButton : IButton
    {
        public void Paint()
        {
            System.Console.WriteLine("I'm a WinButton");
        }
    }
}
