package board;

import cards.Card;

import java.util.ArrayList;

public class CardList {
    private static ArrayList<Card> cList;

    public CardList(){
        cList = new ArrayList<Card>();
    }

    public void add(Card card){
        ArrayList<Card> cLists = new ArrayList<>();
        cLists.add(card);
        int forestSize = cList.size();
        if(forestSize > 0){
            for (int i = 0; i < forestSize; i++) {
                Card nextCard = cList.get(i);
                cLists.add(nextCard);
            }
            cList = cLists;
        }
        else{
            cList.add(card);
        }
        //about size
    }


    public int size(){
        return cList.size();
    }

    public static Card getElementAt(int postion){
        return cList.get(postion);
    }

    public static Card removeCardAt(int postion){
        return cList.remove(postion);
    }
}
