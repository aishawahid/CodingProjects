package chess;
import java.lang.Math;

public class Bishop extends Piece{
	private PieceColour colour;
	private String symbol;

	public Bishop(PieceColour pc){
		if (pc.equals(PieceColour.WHITE)){
			this.colour=PieceColour.WHITE;
			this.symbol="♗";
		}
		else if (pc.equals(PieceColour.BLACK)){
			this.colour=PieceColour.BLACK;
			this.symbol="♝";
		}
	}

	public String getSymbol(){
		return symbol;
	}
	public PieceColour getColour(){
		return colour;
	}

	@Override
	public boolean isLegitMove(int i0, int j0, int i1, int j1) {
		int i = i1-i0;
		int j = j1-j0;
		boolean jump = false;

		if (Math.abs(i) == Math.abs(j)) {
			for (int p = 1; p < Math.abs(j); p++)
			{
				boolean jumpsPiece = false;
				if (i>=0 && j>=0){
					jumpsPiece = Board.hasPiece((i0+p),(j0+p));
					if (jumpsPiece == true) {
						jump = true;
						break;
					}
				}
				else if(i>=0 && j<=0){
					jumpsPiece = Board.hasPiece((i0+p),(j0-p));
					if (jumpsPiece == true) {
						jump = true;
						break;
					}
				}
				else if(i<=0 && j>=0){
					jumpsPiece = Board.hasPiece((i0-p),(j0+p));
					if (jumpsPiece == true) {
						jump = true;
						break;
					}
				}
				else if(i<=0 && j<=0){
					jumpsPiece = Board.hasPiece((i0-p),(j0-p));
					if (jumpsPiece == true) {
						jump = true;
						break;
					}
				}
			}
			if(jump == true){
				return false;
			}
			else {
				boolean hasPiece = Board.hasPiece(i1,j1);
				if(hasPiece == true){
					PieceColour newColour = (Board.getPiece(i1, j1)).getColour();
					if((newColour != (Board.getPiece(i0, j0)).getColour())){
						return true;
					}
					else {
						return false;
					}
				}
				else {
					return true;
				}
			}
		}
		else {
			return false;
		}
	}
}
