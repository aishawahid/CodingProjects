package board;

import cards.*;

import java.util.ArrayList;

public class Board {
    private static CardPile forestCardsPile;
    private static CardList forest;
    private static ArrayList<Card> decayPile;

    public static void initialisePiles(){
        forestCardsPile = new CardPile();
        forest = new CardList();
        decayPile = new ArrayList<>();
    }

    public static void setUpCards(){
        for (int i = 0; i < 5; i++) {
            Card B = new Basket();
            forestCardsPile.addCard(B);
        }
        for (int i = 0; i < 4; i++) {
            Card BB = new BirchBolete(CardType.DAYMUSHROOM);
            forestCardsPile.addCard(BB);
        }
        for (int i = 0; i < 3; i++) {
            Card BUT = new Butter();
            forestCardsPile.addCard(BUT);
        }
        for (int i = 0; i < 4; i++) {
            Card C = new Chanterelle(CardType.DAYMUSHROOM);
            forestCardsPile.addCard(C);
        }
        for (int i = 0; i < 3; i++) {
            Card CI = new Cider();
            forestCardsPile.addCard(CI);
        }
        for (int i = 0; i < 5; i++) {
            Card HOW = new HenOfWoods(CardType.DAYMUSHROOM);
            forestCardsPile.addCard(HOW);
        }
        for (int i = 0; i < 10; i++) {
            Card HF = new HoneyFungus(CardType.DAYMUSHROOM);
            forestCardsPile.addCard(HF);
        }
        for (int i = 0; i < 6; i++) {
            Card LW = new LawyersWig(CardType.DAYMUSHROOM);
            forestCardsPile.addCard(LW);
        }
        for (int i = 0; i < 3; i++) {
            Card M = new Morel(CardType.DAYMUSHROOM);
            forestCardsPile.addCard(M);
        }
        for (int i = 0; i < 11; i++) {
            Card PAN = new Pan();
            forestCardsPile.addCard(PAN);
        }
        for (int i = 0; i < 4; i++) {
            Card P = new Porcini(CardType.DAYMUSHROOM);
            forestCardsPile.addCard(P);
        }
        for (int i = 0; i < 5; i++) {
            Card S = new Shiitake(CardType.DAYMUSHROOM);
            forestCardsPile.addCard(S);
        }
        for (int i = 0; i < 8; i++) {
            Card T = new TreeEar(CardType.DAYMUSHROOM);
            forestCardsPile.addCard(T);
        }
        Card T = new TreeEar(CardType.NIGHTMUSHROOM);
        forestCardsPile.addCard(T);
        Card S = new Shiitake(CardType.NIGHTMUSHROOM);
        forestCardsPile.addCard(S);
        Card P = new Porcini(CardType.NIGHTMUSHROOM);
        forestCardsPile.addCard(P);
        Card LW = new LawyersWig(CardType.NIGHTMUSHROOM);
        forestCardsPile.addCard(LW);
        Card HF = new HoneyFungus(CardType.NIGHTMUSHROOM);
        forestCardsPile.addCard(HF);
        Card HOW = new HenOfWoods(CardType.NIGHTMUSHROOM);
        forestCardsPile.addCard(HOW);
        Card C = new Chanterelle(CardType.NIGHTMUSHROOM);
        forestCardsPile.addCard(C);
        Card BB = new BirchBolete(CardType.NIGHTMUSHROOM);
        forestCardsPile.addCard(BB);


    }

    public static CardPile getForestCardsPile(){
        return forestCardsPile;
    }

    public static CardList getForest(){
        return forest;
    }

    public static ArrayList<Card> getDecayPile(){
        return decayPile;
    }

    public static void updateDecayPile(){
        int forestSize = forest.size();
        Card closestCard = forest.getElementAt(forestSize-1);
        if(decayPile.size() < 4)
        {
            decayPile.add(closestCard);
            forest.removeCardAt(forestSize-1);
            forest.add(forestCardsPile.drawCard());
        }
        else
        {
            decayPile = new ArrayList<>();
            decayPile.add(closestCard);
            forest.removeCardAt(forestSize-1);
            forest.add(forestCardsPile.drawCard());
        }


    }
}
