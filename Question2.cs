using System;

abstract class Shape{
    public abstract double GetArea();
}

class Circle : Shape{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

class Rectangle : Shape{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override double GetArea()
    {
        return length * width;
    }
}

class Question2{
    static void Main(string[] args)
    {  
        Circle circle = new Circle(5.0);
        Rectangle rectangle = new Rectangle(4.0, 6.0);

        Console.WriteLine("Area of the circle: " + circle.GetArea());
        Console.WriteLine("Area of the rectangle: " + rectangle.GetArea());

        Console.ReadLine(); 
    }
}