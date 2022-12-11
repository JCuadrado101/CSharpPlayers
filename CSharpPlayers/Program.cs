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
//
// Color[] colors = { Color.Red, Color.Green, Color.Blue, Color.Yellow };
// Rank[] ranks = { Rank.One, Rank.Two, Rank.Three, Rank.Four, Rank.Five, Rank.Six, Rank.Seven, Rank.Eight, Rank.Nine, Rank.Ten, Rank.DollarSign, Rank.Percent, Rank.Caret, Rank.Ampersand };
//
// foreach (Color color in colors)
// {
//     foreach (Rank rank in ranks)
//     {
//         Card card = new Card(rank, color);
//         Console.WriteLine($"The {card.Color} {card.Rank}");
//     }
// }
//
// public class Card
// {
//     public Rank Rank { get; }
//     public Color Color { get; }
//
//     public Card(Rank rank, Color color)
//     {
//         Rank = rank;
//         Color = color;
//     }
//
//     public bool IsSymbol => Rank == Rank.Ampersand || Rank == Rank.Caret || Rank == Rank.DollarSign || Rank == Rank.Percent;
//     public bool IsNumber => !IsSymbol;
// }
//
// public enum Color { Red, Green, Blue, Yellow }
// public enum Rank { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, DollarSign, Percent, Caret, Ampersand }

// The Locked Door

// int initialPasscode = GetInt("What is the initial passcode?");
// Door door = new Door(initialPasscode);
//
// while (true)
// {
//     Console.Write($"The door is {door.State}. What do you want to do? (open, close, lock, unlock, change code) ");
//     string? command = Console.ReadLine();
//
//     switch (command)
//     {
//         case "open":
//             door.Open();
//             break;
//         case "close":
//             door.Close();
//             break;
//         case "lock":
//             door.Lock();
//             break;
//         case "unlock":
//             int guess = GetInt("What is the passcode?");
//             door.Unlock(guess);
//             break;
//         case "change code":
//             int currentCode = GetInt("What is the current passcode?");
//             int newCode = GetInt("What do you want to change it to?");
//             door.ChangeCode(currentCode, newCode);
//             break;
//     }
// }
//
// int GetInt(string text)
// {
//     Console.Write(text + " ");
//     return Convert.ToInt32(Console.ReadLine());
// }
//
// public class Door
// {
//     private int _passcode;
//     public DoorState State { get; private set; }
//
//     public Door(int initialPasscode)
//     {
//         _passcode = initialPasscode;
//         State = DoorState.Closed;
//     }
//     
//     public void Close()
//     {
//         if (State == DoorState.Open) State = DoorState.Closed;
//     }
//
//     public void Open()
//     {
//         if (State == DoorState.Closed) State = DoorState.Open;
//     }
//
//     public void Lock()
//     {
//         if (State == DoorState.Closed) State = DoorState.Locked;
//     }
//
//     public void Unlock(int passcode)
//     {
//         if (State == DoorState.Locked && passcode == _passcode) State = DoorState.Closed;
//     }
//
//     public void ChangeCode(int oldPasscode, int newPasscode)
//     {
//         if (oldPasscode == _passcode) _passcode = newPasscode;
//     }
// }
//
// public enum DoorState { Open, Closed, Locked }


// The Password Validator

// PasswordValidator validator = new PasswordValidator();
//
// while (true)
// {
//     Console.Write("Enter a password: ");
//     string? password = Console.ReadLine();
//
//     if (password == null) break; // If the user enters a null password (Ctrl+Z) then let's be done.
//                                  // An alternative could be to make `IsValid` handle null or to fall
//                                  // back to some default string like the empty string ("") instead.
//                                  // This challenge doesn't specifically call out dealing with null,
//                                  // and it isn't easy to get a null in there in the first place. If
//                                  // you ignored this possibility, that's fine too.
//
//     if (validator.IsValid(password)) Console.WriteLine("That password is valid.");
//     else Console.WriteLine("That password is not valid.");
// }
//
// public class PasswordValidator
// {
//     public bool IsValid(string password)
//     {
//         if (password.Length < 6) return false;
//         if (password.Length > 13) return false;
//         if (!HasUppercase(password)) return false;
//         if (!HasLowercase(password)) return false;
//         if (!HasDigits(password)) return false;
//         if (Contains(password, 'T')) return false;
//         if (Contains(password, '&')) return false;
//
//         return true;
//     }
//
//     private bool HasUppercase(string password)
//     {
//         foreach (char letter in password)
//             if (char.IsUpper(letter)) return true;
//
//         return false;
//     }
//
//     private bool HasLowercase(string password)
//     {
//         foreach (char letter in password)
//             if (char.IsLower(letter)) return true;
//
//         return false;
//     }
//
//     private bool HasDigits(string password)
//     {
//         foreach (char letter in password)
//             if (char.IsDigit(letter)) return true;
//
//         return false;
//     }
//
//     private bool Contains(string password, char letter)
//     {
//         foreach (char character in password)
//             if (character == letter) return true;
//
//         return false;
//     }
// }

