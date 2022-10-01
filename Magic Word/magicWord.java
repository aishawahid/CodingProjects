class magicWord {
  public static void main(String args[]) {
      char[][] myArray = { {'L','I','M','B'}, {'A','R','E','A'}, {'C','O','R','K'}, {'K','N','E','E'}};
      char[][] myArrayTwo = { {'B','I','T'}, {'I','C','E'}, {'T','E','N'}};
      char[][] myArrayThree = { {'S','C','E','N','T'}, {'C','A','N','O','E'}, {'A','R','S','O','N'}, {'R','O','U','S','E'}, {'F','L','E','E','T'}};
      char[][] myArrayFour = { {'F','R','A','C','T','U','R','E'}, {'O','U','T','L','I','N','E','D'}, {'B','L','O','O','M','I','N','G'}, {'S','E','P','T','E','T','T','E'}};
      int row = myArrayFour.length;
      int column = myArrayFour[0].length;
      printRow(myArrayFour, 0);
      printColumn(myArrayFour, 0);
      printDiagonal(myArrayFour, false);
      wordsRepeated(myArrayTwo);
  }

  public static void printRow(char[][] array, int row) {
      for(int j = 0; j < array[0].length; j++){
          System.out.print(array[row][j]);
      }
      System.out.println();
  }
  public static void printColumn(char[][] array, int column) {
      for(int j = 0; j < array.length; j++){
          System.out.print(array[j][column]);
      }
      System.out.println();
  }
  public static void printDiagonal(char[][] array, boolean corner) {
      int row = array.length;
      int column = array[0].length;
      if (row == column) {
          for(int j = 0; j < array[0].length; j++){
              for (int i = 0; i < array[0].length; i++) {
                  if (corner == true){
                      if (j == i){
                          System.out.print(array[j][i]);
                      }
                  }
                  else{
                      if ((j + i) == (array[0].length - 1)){
                          System.out.print(array[j][i]);
                      }
                  }
              }
          }
      }
      System.out.println();
  }
  public static String returnRow(char[][] array, int row) {
      String word = "";
      for(int j = 0; j < array[row].length; j++){
          word = word + array[row][j];
      }
      return word;
  }
  public static String returnColumn(char[][] array, int column) {
      String word = "";
      for(int j = 0; j < array[column].length; j++){
          word = word + array[j][column];
      }
      return word;
  }
  public static void wordsRepeated(char[][] array) {
      int row = array.length;
      int column = array[0].length;
      if (row == column){
          int words = 0;
          int i = 0;
          while (i < row && i < column) {
              String rowWord = returnRow(array, i);
              String columnWord = returnColumn(array, i);
              if (rowWord.equals(columnWord)){
                  words += 1;
              }
              i += 1;
          }
          System.out.println("Words Repeated: " + words);
      }
  }
}
