package board;

import cards.Card;

import java.util.ArrayList;

public class Hand implements Displayable{
    private ArrayList<Card> handList = new ArrayList<>();

    public void add(Card card){
        handList.add(card);
    }

    public int size(){
        return handList.size();
    }

    public Card getElementAt(int postion){
       return handList.get(postion);
    }

    public Card removeElement(int postion){
        return handList.remove(postion);
    }
}
