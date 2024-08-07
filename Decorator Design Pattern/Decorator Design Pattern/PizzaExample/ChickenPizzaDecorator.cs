namespace Decorator_Design_Pattern.PizzaExample
{
    //The following Concrete Decorator class will add Chicken to Existing Pizza
    public class ChickenPizzaDecorator : PizzaDecorator
    {
        //Pass the existing pizza while creating the Instance of ChickenPizzaDecorator
        //Also pass the same existing pizza object to the base constructor
        public ChickenPizzaDecorator(IPizza pizza) : base(pizza)
        {
        }

        //Overriding the MakePizza method to Chicken
        public override string MakePizza()
        {
            //First Call the Concrete Components MakePizza Method and then the AddChicken method
            return _pizza.MakePizza() + AddChicken();
        }
        public string AddChicken()
        {
            return ", Chicken Added";
        }
    }
}
