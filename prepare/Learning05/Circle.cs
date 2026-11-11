class Circle : Shape
{
    private double _radius;

    public Circle(double side, string color)
    {
        _radius  = side;
        SetColor(color);
    }

    public override double GetArea()
    {
        return _radius * _radius * 3.14159;
    }
}