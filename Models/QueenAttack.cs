namespace Chess.Models
{
  public class ChessPiece
  {
    private int _pieceX;
    private int _pieceY;
  
    public ChessPiece(int pieceX, int pieceY)
    {
      _pieceX = pieceX;
      _pieceY = pieceY;
    }

    public int GetPieceX()
    {
      return _pieceX;
    }

     public int GetPieceY()
    {
      return _pieceY;
    }

    public void SetPieceX(int newPieceX)
    {
      _pieceX = newPieceX;
    }
    
    public void SetPieceY(int newPieceY)
    {
      _pieceY = newPieceY;
    }
  }
}
