public class ShapeInfo
{
    public string Name { get; set; }
    public float X { get; set; }
    public float Y { get; set; }
    public float Width { get; set; }
    public float Height { get; set; }
    public float SideLength { get; set; } // For squares
    public float Radius { get; set; } // For circles
    public float Length { get; set; } // For lines

    public ShapeInfo(string name, float x, float y, float width, float height)
    {
        Name = name;
        X = x;
        Y = y;
        Width = width;
        Height = height;
    }

    public ShapeInfo(string name, float x, float y, float width, float height, float sideLength)
        : this(name, x, y, width, height)
    {
        SideLength = sideLength;
    }

    public ShapeInfo(string name, float x, float y, float width, float height, float radius, bool isCircle)
        : this(name, x, y, width, height)
    {
        if (isCircle)
        {
            Radius = radius;
        }
    }

    public ShapeInfo(string name, float x, float y, float width, float height, float length, float dummy)
        : this(name, x, y, width, height)
    {
        Length = length;
    }

    public override string ToString()
    {
        if (SideLength > 0)
        {
            return $"{Name} (x = {X}, y = {Y}, side = {SideLength})";
        }
        else if (Radius > 0)
        {
            return $"{Name} (x = {X}, y = {Y}, radius = {Radius})";
        }
        else if (Length > 0)
        {
            return $"{Name} (x = {X}, y = {Y}, length = {Length})";
        }
        else
        {
            return $"{Name} (x = {X}, y = {Y}, width = {Width}, height = {Height})";
        }
    }
}
