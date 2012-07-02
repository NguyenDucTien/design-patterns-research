
namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client(new ConcreteFactory1());
            Client client2 = new Client(new ConcreteFactory2());
            System.Console.WriteLine();
        }
    }
}
