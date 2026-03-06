class Circle : Shape
{
    public int Radius;

    public Circle() { }

    protected Circle(Circle source) : base(source)
    {
        Radius = source.Radius;
    }

    public override Shape Clone()
    {
        return new Circle(this);
    }
}
