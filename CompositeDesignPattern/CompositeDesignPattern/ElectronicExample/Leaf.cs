using System;
using System.Diagnostics;
using System.Xml.Linq;
namespace CompositeDesignPattern.ElectronicExample
{
    // The Leaf class represents the end objects. 
    // A leaf can't have any children.
    // The Leaf object is the Object which does the actual work
    public class Leaf : Component
    {
        public int _price;
        public Leaf(string name, int price) : base(name) { _price = price;}
        public override  void DisplayPrice()
        {
            Console.WriteLine($"\tComponent Name: {_name} and Price: {_price}");
        }
    }
}
