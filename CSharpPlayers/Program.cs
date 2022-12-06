// The Point

// Point a = new Point(2, 3);
// Point b = new Point(4, 5);
//
// Console.WriteLine($"({a.X}, {a.Y})");
// Console.WriteLine($"({b.X}, {b.Y})");
//
// public class Point
// {
//     public float X { get; set; }
//     public float Y { get; set; }
//
//     public Point(float x, float y)
//     {
//         X = x;
//         Y = y;
//     }
//     public Point() : this(0, 0) {}
// }

// The Color

Color customColor = new Color(153, 128, 32);
Color selectedColor = Color.Orange;

Console.WriteLine($"({selectedColor.R}, {selectedColor.G}, {selectedColor.B})");

class Color
{
    public int R { get; }
    public int G { get; }
    public int B { get; }

    public Color(int r, int g, int b)
    {
        R = r;
        G = g;
        B = b;
    }

    public static Color White { get; } = new Color(255, 255, 255);
    public static Color Black {get;} = new Color(0, 0, 0);
    public static Color Red { get; } = new Color(255, 0, 0);
    public static Color Orange {get;} =  new Color(255, 165, 0);
    public static Color Yellow {get;} =  new Color(255, 255, 0);
    public static Color Green {get;} = new Color(0, 128, 0);
    public static Color Blue {get;} = new Color(0, 0, 255);
    public static Color Purple {get;} =  new Color(128, 0, 128);
}