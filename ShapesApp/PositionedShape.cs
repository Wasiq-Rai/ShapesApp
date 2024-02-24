using ShapesApp;

public class PositionedShape
{
    public Shape Shape { get; }
    public int X { get; }
    public int Y { get; }

    public PositionedShape(Shape shape, int x, int y)
    {
        Shape = shape;
        X = x;
        Y = y;
    }
}
