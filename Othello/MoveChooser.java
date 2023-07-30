import java.util.ArrayList;


public class MoveChooser {

    public static Move bestMove;

    public static int evaluation(BoardState board){

        int valueOfPos = 0;

        int [][] heuristic = {
                {120,-20, 20, 5, 5, 20, -20, 120},
                {-20, -40, -5, -5, -5, -5, -40, -20},
                {20, -5, 15, 3, 3, 15, -5, 20},
                {5, -5, 3, 3, 3, 3, -5, 5},
                {5, -5, 3, 3, 3, 3, -5, 5},
                {20, -5, 15, 3, 3, 15, -5, 20},
                {-20, -40, -5, -5, -5, -5, -40, -20},
                {120, -20, 20, 5, 5, 20, -20, 120}
        };

        int weightedWhite = 0;
        int weightedBlack = 0;

        for(int i =0; i < heuristic.length; i++){
            for(int j =0; j < heuristic.length; j++){
                if(board.getContents(i,j) == -1){
                    weightedBlack = weightedBlack + (1 * (heuristic[i][j]));
                }
                else if(board.getContents(i,j) == 1){
                    weightedWhite = weightedWhite + (1 * (heuristic[i][j]));
                }
            }
        }

        valueOfPos = weightedWhite - weightedBlack;

        System.out.println(valueOfPos);
        return valueOfPos;

    }

    public static double minimax(boolean maximisingPlayer,int depth, double alpha, double beta, Move move, BoardState board){
        ArrayList<Move> moves = board.getLegalMoves();
        int searchDepth= Othello.searchDepth;

        int topMove = 0;

        if (depth == 0){
            return evaluation(board);
        }
        else if (maximisingPlayer){
            if (moves.size() == 0){
                maximisingPlayer = false;
            }
            for (int i = 0; i < moves.size(); i++) {
                BoardState nextBoard = board.deepCopy();
                nextBoard.makeLegalMove(moves.get(i).x, moves.get(i).y);
                double score = minimax(false, depth-1, alpha, beta, moves.get(i), nextBoard);

                if (score > alpha) {
                    alpha = score;
                    topMove = i;

                }

                if (alpha >= beta) {
                    break;
                }
            }

            if (depth == searchDepth) {
                bestMove = moves.get(topMove);
            }

            return alpha;

        }
        else {
            if (moves.size() == 0){
                maximisingPlayer = true;
            }
            for (int i = 0; i < moves.size(); i++) {
                BoardState nextBoard = board.deepCopy();
                nextBoard.makeLegalMove(moves.get(i).x, moves.get(i).y);
                double score = minimax(true,depth-1, alpha, beta, moves.get(i), nextBoard);

                if (score < beta)
                    beta = score;

                if (alpha >= beta)
                    break;
            }
            return beta;
        }

    }

    public static Move chooseMove(BoardState boardState){

	int searchDepth= Othello.searchDepth;

        ArrayList<Move> moves= boardState.getLegalMoves();
        if(moves.isEmpty()){
            return null;
	    }

        else {
            minimax(true, searchDepth, Double.NEGATIVE_INFINITY, Double.POSITIVE_INFINITY, moves.get(0), boardState);
            return bestMove;
        }
    }
}
