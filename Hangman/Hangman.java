
public class Hangman {

    private String playerName;
    private String wordToGuess;
    public int maxGuesses;
    private char[] guesses;

    public Hangman(String playerName){
      setPlayerName(playerName);
      maxGuesses = 20;
      guesses = new char[maxGuesses];
    }
    public String getPlayerName(){
      return playerName;
    }
    public void setPlayerName(String name){
      playerName = name;
    }
    public String getWord(){
      return wordToGuess;
    }
    public void setWord(String word){
      wordToGuess = word;
    }
    public char[] getGuesses(){
      return guesses;
    }
    public boolean tryChar(char test){
      boolean found = false;
      int lengthOfWord = wordToGuess.length();
      char[] charString = wordToGuess.toCharArray();
      String stringGuesses = String.valueOf(guesses);
      for(int i = 0; i < lengthOfWord; i++) {
        if(test == charString[i]) // and not in guesses
        {
          if(stringGuesses.contains(String.valueOf(charString[i]))){

          }
          else{
            found = true;
            int position = getRemainingGuesses();
            guesses[20-position] = test;
          }
        }
      }
      return found;
    }
    public int getRemainingGuesses(){
      String alphabet = "abcdefghijklmnopqrstuv";
      int counter = 0;
      for (int i =0; i<20 ;i++ ) {
          if(alphabet.contains(String.valueOf(guesses[i]))){
            counter = counter + 1;
          }
      }
      return (20 - counter);

    }
    public String getCurrentState(){

        int lengthOfWord = wordToGuess.length();
        String stringGuesses = String.valueOf(guesses);
        char[] charString = wordToGuess.toCharArray();
        String currentWord = "";
        for(int i = 0; i < lengthOfWord; i++) {
            if(stringGuesses.contains(String.valueOf(charString[i]))){
                  currentWord = currentWord + charString[i];
            }
            else{
              currentWord = currentWord + "_";
            }
        }
        return currentWord;

    }

}
