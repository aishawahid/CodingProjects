package board;

import cards.Card;

public interface Displayable {

    void add(Card card);
    int size();
    Card getElementAt(int number);

    Card removeElement(int number);

}
