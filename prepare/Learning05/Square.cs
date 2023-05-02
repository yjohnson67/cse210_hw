//Import System namespace
using System;

//Define a class named Shape
public class Square : Shape
{
     //Private field to store the length of a side of the square
    private double _side;

    //Constructor that takes a color and length of a side of the square and calls the base class constructor to set the color
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    //Overridden method that calculates and returns the area of the square
    public override double GetArea()
    {
        return _side * _side;
    }
}