package cards;

public class EdibleItem extends Card {
    protected int flavourPoints;

    public EdibleItem(CardType type, String cardName) {
        super(type, cardName);
    }

    public int getFlavourPoints(){
        if(cardName == "birchbolete"){
            flavourPoints = 3;
        }
        else if(cardName == "honeyfungus"){
            flavourPoints = 1;
        }
        else if(cardName == "treeear"){
            flavourPoints = 1;
        }
        else if(cardName == "lawyerswig"){
            flavourPoints = 2;
        }
        else if(cardName == "shiitake"){
            flavourPoints = 2;
        }
        else if(cardName == "henofwoods"){
            flavourPoints = 3;
        }
        else if(cardName == "porcini"){
            flavourPoints = 3;
        }
        else if(cardName == "chanterelle"){
            flavourPoints = 4;
        }
        else if(cardName == "morel"){
            flavourPoints = 6;
        }
        return flavourPoints;
    }
}
