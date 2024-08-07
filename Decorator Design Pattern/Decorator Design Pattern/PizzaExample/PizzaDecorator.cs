namespace Decorator_Design_Pattern.PizzaExample
{
    //Inherited from the Base Component Interface
    public class PizzaDecorator : IPizza
    {
        //Create a Field to store the existing Pizza Object
        protected IPizza _pizza { get; }

        //Initializing the Field using Constructor
        //While Creating an instance of the PizzaDecorator (Instance of the Child Class that Implements PizzaDecorator abstract class)
        //We need to pass the existing pizza object which we want to decorate
        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        //Providing Implementation for Pizza Interface i.e. MakePizza Method
        //Here, we are just calling the Concrete Component ManufactureCar Method using the existing pizza object
        //We are making this Method Virtual to allow the Child Concrete Decorator classes to override
        public virtual string MakePizza()
        {
            return _pizza.MakePizza();
        }
    }
}
