using System;

namespace AbstractFactory
{
    public class OSXFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new OSXButton();
        }
    }
}
