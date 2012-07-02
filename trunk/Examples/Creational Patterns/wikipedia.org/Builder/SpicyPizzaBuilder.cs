using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    /// <summary>
    /// Concrete Builder - provides implementation for Builder; an object able to construct other objects.
    /// Constructs and assembles parts to build the objects
    /// </summary>
    public class SpicyPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough()
        {
            pizza.Dough = "pan baked";
        }

        public override void BuildSauce()
        {
            pizza.Sauce = "hot";
        }

        public override void BuildTopping()
        {
            pizza.Topping = "pepperoni + salami";
        }
    }
}
