package board;

import cards.*;

import java.util.ArrayList;

public class Player {
    private Hand h;
    private Display d;
    private int score;
    private int handlimit;
    private int sticks;

    public Player(){
        h = new Hand();
        d = new Display();
        Card P = new Pan();
        d.add(P);
        score = 0;
        handlimit = 8;
        sticks = 0;
    }
    public int getScore(){
        return score;
    }
    public int getHandLimit(){
        return handlimit;
    }
    public int getStickNumber(){
        return sticks;
    }


    public void addSticks(int nosticks){
        sticks = nosticks + sticks;
        for (int i = 0; i < nosticks; i++) {
            d.add(new Stick());
        }
    }

    public void removeSticks(int nosticks){
        sticks = sticks - nosticks;
    }

    public Hand getHand(){
        return h;
    }

    public Display getDisplay(){
        return d;
    }

    public void addCardtoHand(Card card){
        h.add(card);
    }

    public void addCardtoDisplay(Card card){
        d.add(card);
    }

    public boolean takeCardFromTheForest(int card){
        handlimit = 8;
        if(d.size() > 0){
            for (int i = 0; i < d.size(); i++) {
                if(d.getElementAt(i).getType() == CardType.BASKET){
                    handlimit = handlimit + 2;
                }
            }
            if ( h.size() + 1 > handlimit){
                return false;
            }
            else {
                if(card > 2){
                    if(sticks >= card-2){
                        int removeSticks = card - 2;
                        int counter = 0;
                        sticks = sticks - (removeSticks);
                        for (int i = 0; i < d.size(); i++) {
                            if(d.getElementAt(i).getType() == CardType.STICK){
                                d.removeElement(i);
                                i--;//make in function
                            }
                            counter++;
                            if (removeSticks<counter+1){
                                break;
                            }
                        }
                        Card card1 = Board.getForest().getElementAt(card-1);
                        if(card1.getType() == CardType.BASKET)
                        {
                            handlimit = handlimit + 2;
                            d.add(card1);
                        }
                        else{
                            h.add(card1);
                        }
                        return true;
                    }
                    else{
                        return false;
                    }
                }
                else {
                    Card card1 = Board.getForest().getElementAt(card-1);
                    if(card1.getType() == CardType.BASKET)
                    {
                        handlimit = handlimit + 2;
                        d.add(card1);
                    }
                    else{
                        h.add(card1);
                    }
                    return true;
                }
            }
        }
        else {
            if(card > 2){
                if(sticks >= card-2){
                    int removeSticks = card - 2;
                    int counter = 0;
                    sticks = sticks - (removeSticks);
                    for (int i = 0; i < d.size(); i++) {
                        if(d.getElementAt(i).getType() == CardType.STICK){
                            d.removeElement(i); //make in function
                            i--;
                        }
                        counter++;
                        if (removeSticks<counter+1){
                            break;
                        }
                    }
                    Card card1 = Board.getForest().getElementAt(card-1);
                    if(card1.getType() == CardType.BASKET)
                    {
                        handlimit = handlimit + 2;
                        d.add(card1);
                    }
                    else{
                        h.add(card1);
                    }
                    return true;
                }
                else{
                    return false;
                }
            }
            else {
                Card card1 = Board.getForest().getElementAt(card-1);
                if(card1.getType() == CardType.BASKET)
                {
                    handlimit = handlimit + 2;
                    d.add(card1);
                }
                else{
                    h.add(card1);
                }
                return true;
            }
        }
    }

    public boolean takeFromDecay(){
        handlimit = 8;
        int decayBaskets = 0;
        int handBaskets = 0;
        ArrayList<Card> decayPile = Board.getDecayPile();
        if(d.size() > 0) {
            for (int i = 0; i < d.size(); i++) {
                if (d.getElementAt(i).getType() == CardType.BASKET) {
                    handlimit = handlimit + 2;
                }
            }
            for (int i = 0; i < decayPile.size(); i++) {
                if (decayPile.get(i).getType() == CardType.BASKET) {
                    handlimit = handlimit + 2;
                    decayBaskets = decayBaskets + 1;
                }
            }
            for (int i = 0; i < h.size(); i++) {
                if (h.getElementAt(i).getType() == CardType.BASKET) {
                    handlimit = handlimit + 2;
                    handBaskets = handBaskets + 1;
                }
            }
            if ( h.size() +  decayPile.size() - decayBaskets  - handBaskets> handlimit){
                return false;
            }
            else {
                for (int i = 0; i < decayPile.size(); i++) {
                    Card card1 = decayPile.get(i);
                    if(card1.getType() == CardType.BASKET)
                    {
                        d.add(card1);
                    }
                    else{
                        h.add(card1);
                    }
                }
                return true;
            }
        }
        //Check that taking these cards will not surpass the player's hand limit.
        //Check if there is a basket in the decay pile as this will increase the hand limit.
        else {
            for (int i = 0; i < decayPile.size(); i++) {
                if (decayPile.get(i).getType() == CardType.BASKET) {
                    handlimit = handlimit + 2;
                    decayBaskets = decayBaskets + 1;
                }
            }
            for (int i = 0; i < h.size(); i++) {
                if (h.getElementAt(i).getType() == CardType.BASKET) {
                    handlimit = handlimit + 2;
                    handBaskets = handBaskets + 1;
                }
            }
            if ( h.size()  +  decayPile.size() - decayBaskets - handBaskets > handlimit){
                return false;
            }
            else {
                for (int i = 0; i < decayPile.size(); i++) {
                    Card card1 = decayPile.get(i);
                    if(card1.getType() == CardType.BASKET)
                    {
                        d.add(card1);
                    }
                    else{
                        h.add(card1);
                    }
                }
                return true;
            }
        }
    }

    public boolean cookMushrooms(ArrayList<Card> cards){
        //check if pan
        //check mushrooms are the same
        //check enough cards
        //update score
        //remove cards used
        boolean isPan = false;
        boolean areSame = true;
        boolean isEdible = true;
        int cider = 0;
        int butter = 0;
        int mushrooms = 0;
        String mushName = "";
        for (int i = 0; i < d.size(); i++) {
            Card cardi = d.getElementAt(i);
            if (cardi.getType() == CardType.PAN) {
                isPan = true;
            }

        }
        ArrayList<Card> duplicate = new ArrayList<>();

        for (int i = 0; i < cards.size(); i++) {
            Card cardi = cards.get(i);

            if(cardi.getType() == CardType.PAN){
                isPan = true;
            }
            else if(cardi.getType() == CardType.CIDER){
                cider = cider + 1;
            }
            else if(cardi.getType() == CardType.BUTTER){
                butter = butter + 1;
            }
            else if(cardi.getType() == CardType.DAYMUSHROOM){
                mushrooms = mushrooms + 1;
                duplicate.add(cardi);
                mushName = cardi.getName();
            }
            else if(cardi.getType() == CardType.NIGHTMUSHROOM){
                mushrooms = mushrooms + 2;
                duplicate.add(cardi);
                mushName = cardi.getName();
            }
            else {
                isEdible = false;
            }
        }

        for (int i = 0; i < duplicate.size() - 1; i++) {
            if(duplicate.get(i).getName() != duplicate.get(i+1).getName()){
                areSame = false;
                break;
            }
        }

        if (isPan == true && areSame == true && isEdible == true) {
            if (mushrooms <= 2){
                return false;
            }
            else if(mushrooms + 1 > (cider * 5) + (butter * 4)){
                int flavourPoints = 0;
                if(mushName == "birchbolete"){
                    flavourPoints = 3;
                }
                else if(mushName == "honeyfungus"){
                    flavourPoints = 1;
                }
                else if(mushName == "treeear"){
                    flavourPoints = 1;
                }
                else if(mushName == "lawyerswig"){
                    flavourPoints = 2;
                }
                else if(mushName == "shiitake"){
                    flavourPoints = 2;
                }
                else if(mushName == "henofwoods"){
                    flavourPoints = 3;
                }
                else if(mushName == "porcini"){
                    flavourPoints = 3;
                }
                else if(mushName == "chanterelle"){
                    flavourPoints = 4;
                }
                else if(mushName == "morel"){
                    flavourPoints = 6;
                }
                score = (mushrooms * flavourPoints) + (3 * butter) + (5 * cider);
                return true;
            }
            else {
                return false;
            }
        }
        else {
            return false;
        }
    }

    public boolean sellMushrooms(String string, int number){
        String canonical = string.replaceAll("[^A-Za-z]+", "").toLowerCase();
        int realNum = 0;
        if(number >= 2){
            if (canonical == "honeyfungus" || canonical == "henofwoods" || canonical == "birchbolete" || canonical == "chanterelle" || canonical == "lawyerswig" || canonical == "morel" || canonical == "porcini" || canonical == "shiitake" || canonical == "treeear" || canonical.equals("honeyfungus") || canonical.equals("henofwoods") || canonical.equals("birchbolete") || canonical.equals("chanterelle") || canonical.equals("lawyerswig") || canonical.equals("morel") || canonical.equals("porcini") || canonical.equals("shiitake" )|| canonical.equals("treeear")){
                for (int i = 0; i < h.size(); i++) {
                    if(h.getElementAt(i).getType() == CardType.NIGHTMUSHROOM){
                        String name = h.getElementAt(i).getName();
                        if(name.equals(canonical)){
                            realNum = realNum + 2;
                        }
                    }
                    else if(h.getElementAt(i).getType() == CardType.DAYMUSHROOM){
                        String name = h.getElementAt(i).getName();
                        if(name.equals(canonical)){
                            realNum = realNum + 1;
                        }
                    }
                }
                if(realNum >= number){
                    int sticks = 0;
                    int flavourPoints = 0;
                    if(canonical.equals("birchbolete")){
                        BirchBolete bb = new BirchBolete(CardType.DAYMUSHROOM);
                        flavourPoints = bb.getFlavourPoints();
                        sticks = bb.getSticksPerMushroom();
                    }
                    else if(canonical.equals("honeyfungus")){
                        HoneyFungus hf = new HoneyFungus(CardType.DAYMUSHROOM);
                        flavourPoints = hf.getFlavourPoints();
                        sticks = hf.getSticksPerMushroom();
                    }
                    else if(canonical.equals("treeear")){
                        TreeEar te = new TreeEar(CardType.DAYMUSHROOM);
                        flavourPoints = te.getFlavourPoints();
                        sticks = te.getSticksPerMushroom();
;                    }
                    else if(canonical.equals("lawyerswig")){
                        LawyersWig lw = new LawyersWig(CardType.DAYMUSHROOM);
                        flavourPoints = lw.getFlavourPoints();
                        sticks = lw.getSticksPerMushroom();
                    }
                    else if(canonical.equals("shiitake")){
                        Shiitake st = new Shiitake(CardType.DAYMUSHROOM);
                        flavourPoints = st.getFlavourPoints();
                        sticks = st.getSticksPerMushroom();
                    }
                    else if(canonical.equals("henofwoods")){
                        HenOfWoods how = new HenOfWoods(CardType.DAYMUSHROOM);
                        flavourPoints = how.getFlavourPoints();
                        sticks = how.getSticksPerMushroom();
                    }
                    else if(canonical.equals("porcini")){
                        Porcini p = new Porcini(CardType.DAYMUSHROOM);
                        flavourPoints = p.getFlavourPoints();
                        sticks = p.getSticksPerMushroom();
                    }
                    else if(canonical.equals("chanterelle")){
                        Chanterelle c = new Chanterelle(CardType.DAYMUSHROOM);
                        flavourPoints = c.getFlavourPoints();
                        sticks = c.getSticksPerMushroom();
                    }
                    else if(canonical.equals("morel")){
                        Morel m = new Morel(CardType.DAYMUSHROOM);
                        flavourPoints = m.getFlavourPoints();
                        sticks = m.getSticksPerMushroom();
                    }

                    int noSticks = (sticks) * number;
                    score = score + (flavourPoints*number);
                    addSticks(noSticks);

                    for (int i = 0; i < h.size(); i++) {
                        if(h.getElementAt(i).getType() == CardType.NIGHTMUSHROOM){
                            if(h.getElementAt(i).getName().equals(canonical)){
                                h.removeElement(i);
                                i--;
                            }
                        }
                        else if(h.getElementAt(i).getType() == CardType.DAYMUSHROOM){
                            if(h.getElementAt(i).getName().equals(canonical)){
                                h.removeElement(i);
                                i--;
                            }
                        }
                    }
                    return true;
                }
                else {
                    return false;
                }
            }
            else {
                return false;
            }
        }
        else {
            return false;
        }
    }

    public boolean putPanDown(){
        boolean isFound = false;
        for (int i = 0; i < h.size(); i++) {
            Card cardi = h.getElementAt(i);
            if(cardi.getType() == CardType.PAN)
            {
                d.add(cardi);
                h.removeElement(i);
                isFound = true;
                break;
            }
        }
        if (isFound == false){
            return false;
        }
        else {
            return true;
        }
    }
}
