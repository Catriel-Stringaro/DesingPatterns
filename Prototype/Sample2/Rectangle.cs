class Rectangle : Shape
{
    public int Width;
    public int Height;

    public Rectangle() { }

    protected Rectangle(Rectangle source) : base(source)
    {
        Width = source.Width;
        Height = source.Height;
    }

    public override Shape Clone()
    {
        return new Rectangle(this);
    }
}
