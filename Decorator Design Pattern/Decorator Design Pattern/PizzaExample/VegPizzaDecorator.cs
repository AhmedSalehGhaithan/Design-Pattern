namespace Decorator_Design_Pattern.PizzaExample
{
    //The following Concrete Decorator class will add Vegetables to the Existing Pizza
    public class VegPizzaDecorator : PizzaDecorator
    {
        //Pass the existing pizza object while creating the Instance of VegPizzaDecorator class
        //Also pass the same existing pizza object to the base class constructor
        public VegPizzaDecorator(IPizza pizza) : base(pizza)
        {
        }

        //Overriding the MakePizza method to Vegetables
        public override string MakePizza()
        {
            //First Call the Concrete Components MakePizza Method and then the AddVegetables method
            return _pizza.MakePizza() + AddVegetables();
        }

        public string AddVegetables()
        {
            return ", AddVegetables added";
        }
    }
}
