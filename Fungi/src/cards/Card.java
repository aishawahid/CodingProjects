package cards;

import java.util.Random;

public class Card {
    protected CardType type;
    protected String cardName;

    public Card(CardType ctype, String ccardName){
        type = ctype;
        cardName = ccardName;
    }

    public CardType getType(){
        return type;
    }

    public String getName(){
        return cardName;
    }
}
