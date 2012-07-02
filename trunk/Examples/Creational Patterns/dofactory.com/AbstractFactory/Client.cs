
namespace AbstractFactory
{
    public class Client
    {
        private IAbstractProductA abstractProductA;
        private IAbstractProductB abstractProductB;

        public Client(IAbstractFactory factory)
        {
            abstractProductA = factory.CreateProductA();
            abstractProductB = factory.CreateProductB();
        }
    }
}
