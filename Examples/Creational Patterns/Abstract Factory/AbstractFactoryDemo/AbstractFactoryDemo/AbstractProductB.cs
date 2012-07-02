using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryDemo
{
    /// <summary>
    /// The 'AbstractProductB' abstract class
    /// </summary>
    public abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA a);
    }
}
