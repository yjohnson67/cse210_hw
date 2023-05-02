//Import the System namespace
using System;

//Define a class named Shape
public class Shape
{
    //Define a private string field named _color
    private string _color;

    //Define a public property named Color that gets and sets the value of _color
    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }
    //Define a constructor for the Shape class that takes a string parameter named color
    public Shape(string color)
    {
         // Assign the value of the color parameter to the _color field
        _color = color;
    }

    //Define a virtual method named GetArea that returns a double
    public virtual double GetArea()
    {
         //Return 0.0 as the default value for the GetArea method
        return 0.0;
    }
}