package board;

import cards.Card;

import java.util.ArrayList;

public class Display implements Displayable{
    private ArrayList<Card> displayList = new ArrayList<>();

    public void add(Card card){
        displayList.add(card);
    }

    public int size(){
        return displayList.size();
    }

    public Card getElementAt(int postion){
        return displayList.get(postion);
    }

    public Card removeElement(int postion){
        return displayList.remove(postion);
    }
}
