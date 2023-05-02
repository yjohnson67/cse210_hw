//Import System namespace
using System;

//Define a class named Shape
public class Rectangle : Shape
{
    private double _length;
    private double _width;

     //Constructor that accepts the color, width, and height, and calls the base constructor with the color
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    //Override the GetArea() method from the base class and fill in the body of this function to return the area
    public override double GetArea()
    {
        return _length * _width;
    }
}