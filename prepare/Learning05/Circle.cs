//Import System namespace
using System;

//Define a class named Shape
public class Circle : Shape
{
    private double _radius;

    //Constructor for Circle class that takes color and radius as parameters and invokes the base class constructor
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    //Override GetArea method to calcdulate circle's area using the formula pi * r^2
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}