package board;

import cards.Card;

import java.util.Collections;
import java.util.Stack;

public class CardPile {
    private Stack<Card> cPile;

    public CardPile(){
        cPile = new Stack<Card>();
    }

    public void addCard(Card card){
        cPile.push(card);
    }

    public Card drawCard(){
        return cPile.pop();
    }

    public void shufflePile(){
        Stack pile  = cPile;
        Collections.shuffle(pile);
        cPile = pile;

    }

    public int pileSize(){
        return cPile.size();
    }

    public boolean isEmpty(){
        if(cPile.empty() == true){
            return true;
        }
        else {
            return false;
        }
    }
}
