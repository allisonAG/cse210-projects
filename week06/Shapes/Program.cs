using System;

class Program
{
    static void Main(string[] args)
    {
        // Square s1 = new Square("blue", 4);
        // Console.WriteLine(s1.GetColor());
        // Console.WriteLine(s1.GetArea());

        // Rectangle r1 = new Rectangle("red", 4, 2);
        // Console.WriteLine(r1.GetColor());
        // Console.WriteLine(r1.GetArea());

        // Circle c1 = new Circle("black", 4);
        // Console.WriteLine(c1.GetColor());
        // Console.WriteLine(c1.GetArea());

        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("blue", 4);
        shapes.Add(s1);

        Rectangle r1 = new Rectangle("red", 4, 2);
        shapes.Add(r1);

        Circle c1 = new Circle("black", 4);
        shapes.Add(c1);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            
            Console.WriteLine(color);
            Console.WriteLine(area);
        }
    }
}