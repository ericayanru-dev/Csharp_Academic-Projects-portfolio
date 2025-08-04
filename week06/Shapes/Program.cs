using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        // Create a list of shapes
        List<Shapes> shapes = new List<Shapes>();

        // Add one of each shape
        Circle circle = new Circle(5);          // Radius = 5
        Rectangle rectangle = new Rectangle(4, 6); // Length = 4, Width = 6
        Squares square = new Squares(3);        // Length = 3

        // Set colors (optional)
        circle.SetColor("Red");
        rectangle.SetColor("Blue");
        square.SetColor("Green");

        // Add to the list
        shapes.Add(circle);
        shapes.Add(rectangle);
        shapes.Add(square);

        // Loop through and display each shape's area
        foreach (Shapes shape in shapes)
        {
            double area = shape.GetArea();
            Console.WriteLine($"Area: {area:F2}");
        }
    
    }
}