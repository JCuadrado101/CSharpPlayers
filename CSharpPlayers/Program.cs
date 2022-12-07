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

// Color customColor = new Color(153, 128, 32);
// Color selectedColor = Color.Orange;
//
// Console.WriteLine($"({selectedColor.R}, {selectedColor.G}, {selectedColor.B})");
//
// class Color
// {
//     public int R { get; }
//     public int G { get; }
//     public int B { get; }
//
//     public Color(int r, int g, int b)
//     {
//         R = r;
//         G = g;
//         B = b;
//     }
//
//     public static Color White { get; } = new Color(255, 255, 255);
//     public static Color Black {get;} = new Color(0, 0, 0);
//     public static Color Red { get; } = new Color(255, 0, 0);
//     public static Color Orange {get;} =  new Color(255, 165, 0);
//     public static Color Yellow {get;} =  new Color(255, 255, 0);
//     public static Color Green {get;} = new Color(0, 128, 0);
//     public static Color Blue {get;} = new Color(0, 0, 255);
//     public static Color Purple {get;} =  new Color(128, 0, 128);
// }

// The Card

Color[] colors = { Color.Red, Color.Green, Color.Blue, Color.Yellow };
Rank[] ranks = { Rank.One, Rank.Two, Rank.Three, Rank.Four, Rank.Five, Rank.Six, Rank.Seven, Rank.Eight, Rank.Nine, Rank.Ten, Rank.DollarSign, Rank.Percent, Rank.Caret, Rank.Ampersand };

foreach (Color color in colors)
{
    foreach (Rank rank in ranks)
    {
        Card card = new Card(rank, color);
        Console.WriteLine($"The {card.Color} {card.Rank}");
    }
}



public class Card
{
    public Rank Rank { get; }
    public Color Color { get; }

    public Card(Rank rank, Color color)
    {
        Rank = rank;
        Color = color;
    }

    public bool IsSymbol => Rank == Rank.Ampersand || Rank == Rank.Caret || Rank == Rank.DollarSign || Rank == Rank.Percent;
    public bool IsNumber => !IsSymbol;
}

public enum Color { Red, Green, Blue, Yellow }
public enum Rank { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, DollarSign, Percent, Caret, Ampersand }