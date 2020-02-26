using System;
using System.Collections.Generic;
using Chess.Models;

namespace Chess
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter an x coordinate from 1-8 for queen piece");
      int queenX = int.Parse(Console.ReadLine());
    
      Console.WriteLine("Enter an y coordinate from 1-8 for queen piece");
      int queenY = int.Parse(Console.ReadLine());

      Console.WriteLine("Enter an x coordinate from 1-8 for opponent piece");
      int opponentX = int.Parse(Console.ReadLine());

      Console.WriteLine("Enter an y coordinate from 1-8 for opponent piece");
      int opponentY = int.Parse(Console.ReadLine());

      ChessPiece queen = new ChessPiece(queenX, queenY);
      ChessPiece opponent = new ChessPiece(opponentX, opponentY);

      queen.SetPieceX(queenX);
      queen.SetPieceY(queenY);

      opponent.SetPieceX(opponentX);
      opponent.SetPieceY(opponentY);

      int newQX =  queen.GetPieceX();
      int newQY =  queen.GetPieceY();

      int newOX =  opponent.GetPieceX();
      int newOY =  opponent.GetPieceY();
    
      for (int i = 0; i < 8; i++)
      {
        if ((newQX == newOX) || (newQY == newOY)) 
        {
          Console.WriteLine("hit");
        }
        else if ((newQX + i == newOX) && (newQY + i == newOY))
        {
          Console.WriteLine("hit");
        }
        else if ((newQX - i == newOX) && (newQY - i == newOY))
        {
          Console.WriteLine("hit");
        }
        else if ((newQX + i == newOX) && (newQY - i == newOY))
        {
          Console.WriteLine("hit");
        }
        else if ((newQX - i == newOX) && (newQY + i == newOY))
        {
          Console.WriteLine("hit");
        }
       
      }
    }
  }
}