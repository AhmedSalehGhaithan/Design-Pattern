using System;
using System.Collections.Generic;
namespace CompositeDesignPattern.ElectronicExample
{
    // The Composite class represents the complex components that have children. 
    // The Composite objects delegate the actual work to their children and then combine the result.
    public class Composite : Component
    {
        //The Object is used to hold all the child components of a composite components
        public List<Component> _components = new List<Component>();
        public Composite(string name) :base(name) { }

        public void AddComponent(Component component) => _components.Add(component);
        public override void DisplayPrice() 
        {
            foreach(var component in _components)
            {
                component.DisplayPrice();
            }
        }
    }
}
