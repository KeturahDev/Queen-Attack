using System;
using System.Collections.Generic;

public class ChessPiece
{
  public int x;
  public int y;
}
public class Game
{
  public static void Main()
  {
    Console.WriteLine("Enter an x coordinate from 1-8 for queen piece");
    string queenInputX = Console.ReadLine();
    int Qx = int.Parse(queenInputX);
    Console.WriteLine("Enter an y coordinate from 1-8 for queen piece");
    string queenInputY = Console.ReadLine();
    int Qy = int.Parse(queenInputY);
    ChessPiece queen = new ChessPiece();
    queen.x = Qx;
    queen.y = Qy;

    Console.WriteLine("Enter an x coordinate from 1-8 for opponent piece");
    string PieceInputX = Console.ReadLine();
    int Px = int.Parse(PieceInputX);
    Console.WriteLine("Enter an y coordinate from 1-8 for opponent piece");
    string PieceInputY = Console.ReadLine();
    int Py = int.Parse(PieceInputY);
    ChessPiece opponent = new ChessPiece();
    opponent.x = Px;
    opponent.y = Py;

    for (int i = 0; i < 8; i++)
    {
      if ((queen.x == opponent.x) || (queen.y == opponent.y)) 
      {
        Console.WriteLine("hit");
      }
      else if ((queen.x + i == opponent.x) && (queen.y + i == opponent.y))
      {
        Console.WriteLine("hit");
      }
      else if ((queen.x - i == opponent.x) && (queen.y - i == opponent.y))
      {
        Console.WriteLine("hit");
      }
      else if ((queen.x + i == opponent.x) && (queen.y - i == opponent.y))
      {
        Console.WriteLine("hit");
      }
      else if ((queen.x - i == opponent.x) && (queen.y + i == opponent.y))
      {
        Console.WriteLine("hit");
      }
      else 
      {
        Console.WriteLine("miss");
      }
    }
  }
}