package chess;

public class Knight extends Piece{
	private PieceColour colour;
	private String symbol;

 	public Knight(PieceColour pc){
		if (pc.equals(PieceColour.WHITE)){
			this.colour=PieceColour.WHITE;
			this.symbol="♘";
		}
		else if (pc.equals(PieceColour.BLACK)){
			this.colour=PieceColour.BLACK;
			this.symbol="♞";
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
		if ((i1 == i0-2 && j1 == j0 - 1) || (i1 == i0-2 && j1 == j0 + 1) || (i1 == i0-1 && j1 == j0 -2) || (i1 == i0-1 && j1 == j0+2) || (i1 == i0+1 && j1 == j0-2) || (i1 == i0+1 && j1 == j0 + 2) || (i1 == i0+2 && j1 == j0 - 1) || (i1 == i0+2 && j1 == j0 + 1)) {
			boolean hasPiece = Board.hasPiece(i1,j1);
			if(hasPiece == true){
				PieceColour newColour = (Board.getPiece(i1, j1)).getColour();
				if(newColour != colour){
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
		else {
			return false;
		}
	}
}
