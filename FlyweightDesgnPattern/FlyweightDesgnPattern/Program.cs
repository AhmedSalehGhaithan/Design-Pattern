using FlyweightDesignPattern.CAD_System;
using FlyweightDesignPattern.CoffeeShops.Client;
using FlyweightDesignPattern.ForestSimulationExample;
using FlyweightDesignPattern.ShapeExample;
using FlyweightDesignPattern.TextEditor;
using FlyweightDesignPattern.VehicleLicensePlateManagementSystem;
using System.Collections.Generic;
namespace FlyweightDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextEditor();
        }
        static void TextEditor()
        {
            var editor = new TextEditors();
            editor.InsertCharacter('A', 0, "Arial", 12, true, false);
            editor.InsertCharacter('B', 1, "Arial", 12, true, false);
            editor.InsertCharacter('C', 2, "Times New Roman", 14, false, true);
            editor.DisplayDocument();
        }
        static void VehicleLicensePlateManagementSystem()
        {
            var plateSystem = new LicensePlateSystem();
            plateSystem.RegisterVehicle("NY", 12345);
            plateSystem.RegisterVehicle("CA", 67890);
            plateSystem.RegisterVehicle("NY", 54321);
            plateSystem.DisplayAllPlates();
        }
        static void CAD_System()
        {
            var cadSystem = new CADSystem();
            cadSystem.AddCircle(5, 5, 10, "Red", "Solid", 2);
            cadSystem.AddCircle(15, 15, 20, "Blue", "Dotted", 3);
            cadSystem.AddCircle(25, 25, 30, "Red", "Solid", 2);
            cadSystem.DrawAllShapes();
        }
        static void CoffeeShop()
        {
            var shop = new CoffeeShop();
            shop.TakeOrder("Cappuccino", 1);
            shop.TakeOrder("Espresso", 2, "With extra sugar");
            shop.TakeOrder("Cappuccino", 3);
            shop.TakeOrder("Latte", 4);
            shop.ServeOrders();
        }
        static void ForestSimulationExample()
        {
            var forest = new List<Tree>();

            // Adding trees to forest
            forest.Add(new Tree(1, 2, TreeFactory.GetTreeType("Pine", "Green", "PineTexture")));
            forest.Add(new Tree(10, 20, TreeFactory.GetTreeType("Pine", "Green", "PineTexture")));
            forest.Add(new Tree(5, 7, TreeFactory.GetTreeType("Oak", "Brown", "OakTexture")));

            foreach(var tree in forest)
            {
                tree.Draw();
            }
        }
        static void ShapeExample()
        {
            ShapeFactory factory = new ShapeFactory();

            IShape circle1 = factory.GetCircle("red", 10);
            IShape circle2 = factory.GetCircle("Green", 20);
            IShape circle3 = factory.GetCircle("Blue", 10);

            circle1.Draw(1, 1);
            circle2.Draw(2, 2);
            circle3.Draw(3, 3);
        }
    }
}
