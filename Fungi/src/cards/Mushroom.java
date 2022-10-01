package cards;

public class Mushroom extends EdibleItem{
    protected int sticksPerMushroom;

    public Mushroom(CardType type, String cardName) {
        super(type, cardName);
    }

    public int getSticksPerMushroom(){
        if(cardName == "birchbolete"){
            sticksPerMushroom = 2;
        }
        else if(cardName == "honeyfungus"){
            sticksPerMushroom = 1;
        }
        else if(cardName == "treeear"){
            sticksPerMushroom = 2;
        }
        else if(cardName == "lawyerswig"){
            sticksPerMushroom = 1;
        }
        else if(cardName == "shiitake"){
            sticksPerMushroom = 2;
        }
        else if(cardName == "henofwoods"){
            sticksPerMushroom = 1;
        }
        else if(cardName == "porcini"){
            sticksPerMushroom = 3;
        }
        else if(cardName == "chanterelle"){
            sticksPerMushroom = 2;
        }
        else if(cardName == "morel"){
            sticksPerMushroom = 4;
        }
        return sticksPerMushroom;
    }
}
