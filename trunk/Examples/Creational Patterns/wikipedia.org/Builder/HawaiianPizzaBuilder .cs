
namespace Builder
{
    /// <summary>
    /// Concrete Builder - provides implementation for Builder; an object able to construct other objects.
    /// Constructs and assembles parts to build the objects
    /// </summary>
    public class HawaiianPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough()
        {
            pizza.Dough = "cross";
        }

        public override void BuildSauce()
        {
            pizza.Sauce = "mild";
        }

        public override void BuildTopping()
        {
            pizza.Topping = "ham+pineapple";
        }
    }
}
