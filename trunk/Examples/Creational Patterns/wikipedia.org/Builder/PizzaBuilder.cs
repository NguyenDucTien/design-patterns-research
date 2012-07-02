
namespace Builder
{
    /// <summary>
    /// Builder - abstract interface for creating objects (the product, in this case)
    /// </summary>
    public abstract class PizzaBuilder
    {
        protected Pizza pizza;

        public Pizza GetPizza()
        {
            return pizza;
        }

        public void CreateNewPizzaProduct()
        {
            pizza = new Pizza();
        }

        public abstract void BuildDough();
        public abstract void BuildSauce();
        public abstract void BuildTopping();
    }
}
