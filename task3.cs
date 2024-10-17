public class Shape
{
    protected double Area;

    public Shape()
    {
        Area = 0;
    }

    public virtual void CalculateArea()
    {
        // მემკვიდრე კლასებში გადატვირთვა მოხდება
    }
}

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public double Length
    {
        get { return _length; }
        set { _length = value; }
    }

    public double Width
    {
        get { return _width; }
        set { _width = value; }
    }

    public Rectangle(double length, double width)
    {
        _length = length;
        _width = width;
    }

    public override void CalculateArea()
    {
        Area = _length * _width;
        Console.WriteLine($"Rectangle Area: {Area}");
    }
}

public class Circle : Shape
{
    private double _radius;

    public double Radius
    {
        get { return _radius; }
        set { _radius = value; }
    }

    public Circle(double radius)
    {
        _radius = radius;
    }

    public override void CalculateArea()
    {
        Area = Math.PI * _radius * _radius;
        Console.WriteLine($"Circle Area: {Area}");
    }
}

// გამოყენება:
Rectangle rectangle = new Rectangle(5, 10);
rectangle.CalculateArea();

Circle circle = new Circle(7);
circle.CalculateArea();
