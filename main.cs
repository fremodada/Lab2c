using System;

class MainClass {
  public static void Main (string[] args) {
  /*
  The program will decide if a color is warm, cool or neutral based on the rules specified below:
  Warm colors are: yellow, orange, red, gold, pink
  Cool colors are: blue, purple, magenta, green
  Neutral colors are: black, white, ivory, brown, beige
  Any other color should display a default message
  Example: “Unable to determine the color temperature for the color fuschia”
  */
  // Get input
    Console.WriteLine ("Enter a color:");
    string color = Console.ReadLine();
  // Determine whether color temperature
  switch (color)
  {
    case ("yellow"):
      Console.WriteLine ("The color " + color + " is warm.");
      break;
    case ("orange"):
      Console.WriteLine ("The color " + color + " is warm.");
      break;
    case ("red"):
      Console.WriteLine ("The color " + color + " is warm.");
      break;
    case ("gold"):
      Console.WriteLine ("The color " + color + " is warm.");
      break;
    case ("pink"):
      Console.WriteLine ("The color " + color + " is warm.");
      break;
    case ("blue"):
    Console.WriteLine ("The color " + color + " is cool.");
    break;
     case ("purple"):
    Console.WriteLine ("The color " + color + " is cool.");
    break;
      case ("magenta"):
    Console.WriteLine ("The color " + color + " is cool.");
    break;
     case ("green"):
    Console.WriteLine ("The color " + color + " is cool.");
    break;
      case ("black"):
    Console.WriteLine ("The color " + color + " is neutral.");
    break;
        case ("white"):
    Console.WriteLine ("Thbrownor " + color + " is neutral.");
    break;
        case ("ivory"):
    Console.WriteLine ("The color " + color + " is neutral.");
    break;
      case ("brown"):
    Console.WriteLine ("The color " + color + " is neutral.");
    break;
    case ("beige"):
    Console.WriteLine ("The color " + color + " is neutral.");
    break;
    default:
    Console.WriteLine ("Unable to determine the color temperature for " + color + ".");
    break;
  }
  }
  
}