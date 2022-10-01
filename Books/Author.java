public class Author{
  private String name;
  private int yearOfBirth;

  public Author(){
  }

  public Author(String authorName,int yob){
    name=authorName;
    yearOfBirth=yob;
  }

  public String getAuthorName(){
    return name;
  }

  public void setAuthorName(String authorName, int yob){
    name=authorName;
    yearOfBirth=yob;
  }

  public int getYearOfBirth(){
    return yearOfBirth;
  }

  public void setYearOfBirth(int yob){
    yearOfBirth=yob;
  }

}
