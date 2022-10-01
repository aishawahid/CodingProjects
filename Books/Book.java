public class Book{
    private String title;
    private Author author;
    private int items;

    public Book(){
    }

    public Book(String booktitle, Author authorname,int numberOfItems){
      title=booktitle;
      author=authorname;
      items=numberOfItems;
    }

    public String getTitle(){
      return title;
    }

    public Author getAuthor(){
      return author;
    }

    public int getItems(){
      return items;
    }

    public void setTitle(String t){
      title=t;
    }

    public void setAuthor(Author a){
      author=a;
    }

    public void setItems(int i){
      items=i;
    }
}
