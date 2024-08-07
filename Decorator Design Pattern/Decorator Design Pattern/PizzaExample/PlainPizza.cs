namespace Decorator_Design_Pattern.PizzaExample
{
    // Concrete Components provide default implementations of the operations.
    public class PlainPizza : IPizza
    {
        //The following MakePizza method returns the default Pizza
        public string MakePizza()
        {
            return "Plain Pizza";
        }
    }
}
