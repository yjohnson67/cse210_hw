//Import the System namespace
using System;

// define a class named Program
class Program
{
    // define the Main method, which is the entry point for the program
    static void Main(string[] args)
    {
         // create a new Square instance with a red color and side length of 5.0
        Square square = new Square("red", 5.0);
         // print the color of the square
        Console.WriteLine($"Square color: {square.Color}");
        // print the area of the square
        Console.WriteLine($"Square area: {square.GetArea()}");

        // create a new Rectangle instance with a green color, width of 4.0, and height of 6.0
        Rectangle rectangle = new Rectangle("green", 4.0, 6.0);
        // print the color of the rectangle
        Console.WriteLine($"Rectangle color: {rectangle.Color}");
        // print the area of the rectangle
        Console.WriteLine($"Rectangle area: {rectangle.GetArea()}");

         // create a new Circle instance with a blue color and radius of 3.0
        Circle circle = new Circle("blue", 3.0);
        // print the color of the circle
        Console.WriteLine($"Circle color: {circle.Color}");
         // print the area of the circle
        Console.WriteLine($"Circle area: {circle.GetArea()}");

        // create a new List of Shape instances
        List<Shape> shapes = new List<Shape>();
        // add the square, rectangle, and circle instances to the list
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        // iterate through the list of shapes
        foreach (Shape shape in shapes)
        {
            // print the color of the shape
            Console.WriteLine($"Shape color: {shape.Color}");
            // print the area of the shape
            Console.WriteLine($"Shape area: {shape.GetArea()}");
        }
    }
}