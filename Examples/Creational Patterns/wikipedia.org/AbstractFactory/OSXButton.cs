
namespace AbstractFactory
{
    public class OSXButton : IButton
    {
        public void Paint()
        {
            System.Console.WriteLine("I'm an OSXButton");
        }
    }
}
