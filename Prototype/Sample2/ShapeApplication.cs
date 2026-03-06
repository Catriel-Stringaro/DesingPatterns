class ShapeApplication
{
    private List<Shape> shapes = new List<Shape>();

    public ShapeApplication()
    {
        Circle circle = new Circle();
        circle.X = 10;
        circle.Y = 10;
        circle.Radius = 20;
        shapes.Add(circle);

        Shape anotherCircle = circle.Clone();
        shapes.Add(anotherCircle);

        Rectangle rectangle = new Rectangle();
        rectangle.Width = 10;
        rectangle.Height = 20;
        shapes.Add(rectangle);
    }

    public List<Shape> BusinessLogic()
    {
        List<Shape> shapesCopy = new List<Shape>();

        foreach (Shape s in shapes)
        {
            shapesCopy.Add(s.Clone());
        }

        return shapesCopy;
    }
}
