Console.Title = "The Point";

Point point = new Point(2, 3);
Point point2 = new Point(-4, 0);

Console.WriteLine($"{point.X()}, {point.Y()}");
Console.WriteLine($"{point2.X()}, {point2.Y()}");

//Our class Point
class Point
{
    //immutable variables
    private int _x;
    private int _y;

    //constructor, that can create a point from a specific X and Y
    public Point(int x, int y)
    {
        _x = x;
        _y = y;

    }

    public int Y() => _x;
    public int X() => _y;

    //parameterless constructor, so we can call point with no arguments
    public Point() { }

}