abstract class Shape
{
    public int X;
    public int Y;
    public string Color;

    protected Shape() { }

    protected Shape(Shape source)
    {
        X = source.X;
        Y = source.Y;
        Color = source.Color;
    }

    public abstract Shape Clone();
}
