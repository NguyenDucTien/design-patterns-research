using System;

namespace AbstractFactory
{
    public class WinFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }
    }
}
