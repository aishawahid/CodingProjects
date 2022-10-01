import java.io.Console;

public class HangmanDriver {

  public static void main(String args[]) {
    Console keyboardConsole = System.console();
    String name;
    name = keyboardConsole.readLine("Please enter you name:");

    Hangman a = new Hangman(name);
    String fetchedName = a.getPlayerName();
    System.out.println("Hi " + name + "!");

    HangmanDictionary b = new HangmanDictionary();
    String wordToGuess = b.getWord();
    a.setWord(wordToGuess);
    do {
      Console guessConsole = System.console();
      String test = guessConsole.readLine("Please enter a guess:");
      a.tryChar(test.charAt(0));
      System.out.println(a.getCurrentState());
      System.out.println(a.getWord());
      if(a.getCurrentState() != a.getWord()){
        System.out.println("hey");
      }
    } while( (a.getRemainingGuesses() != 0) || !((a.getCurrentState()).equals(a.getWord())) );
    System.out.println(wordToGuess);
    a.getCurrentState();

  }

}
