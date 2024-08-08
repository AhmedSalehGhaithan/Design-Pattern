using BridgeDesignPattern.ColorExample.Factory;

namespace BridgeDesignPattern.ColorExample
{
    public static class CreateShapeColorStaticClass
    {
         static IShapeFactory redShapeFactory = new RedShapeFactory();
         static IShapeFactory blueShapeFactory = new blueShapeFactory();
         static IShapeFactory yellowShapeFactory = new YellowShapeFactory();
        public static void CreateRedCircle() => redShapeFactory.CreateCircle().Draw(); 
        public static void CreateRedRectangle() => redShapeFactory.CreateRectangle().Draw();
        public static void CreateRedSquare() => redShapeFactory.CreateSquare().Draw();
        public static void CreateBlueCircle() => blueShapeFactory.CreateCircle().Draw();
        public static void CreateBlueRectangle() => blueShapeFactory.CreateRectangle().Draw();
        public static void CreateBlueSquare() => blueShapeFactory.CreateSquare().Draw();
        public static void CreateYellowCircle() => yellowShapeFactory.CreateCircle().Draw();
        public static void CreateYellowRectangle() => yellowShapeFactory.CreateRectangle().Draw();
        public static void CreateYellowSquare() => yellowShapeFactory.CreateSquare().Draw();
        
    }
}
