﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryDemo
{
    /// <summary>
    /// The 'ProductB2' class
    /// </summary>
    public class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " interacts with " + a.GetType().Name);
        }
    }
}
