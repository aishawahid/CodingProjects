package driver;

import javafx.application.Application;
import javafx.geometry.Insets;
import javafx.scene.image.Image;
import javafx.scene.image.ImageView;
import javafx.scene.layout.VBox;
import javafx.scene.paint.Color;
import javafx.scene.shape.Rectangle;
import javafx.scene.text.Text;
import javafx.stage.Stage;
import javafx.scene.Scene;
import javafx.scene.layout.HBox;
import javafx.scene.control.ScrollPane;

import java.io.FileInputStream;
import board.*;
import cards.Card;

public class GraphicalGame extends Application{

    private static Player p1, p2;

    @Override
    public void start (Stage stage) throws Exception{

        Text ph1 = new Text(80, 500, "Player 1 hand");
        ph1.setFill(Color.BLACK);
        Rectangle prh1 = new Rectangle(1000, 125);
        prh1.setStroke(Color.BLACK);

        Text pd1 = new Text(80, 240, "Player 1 display");
        pd1.setFill(Color.BLACK);
        Rectangle pr1 = new Rectangle(1000, 125);
        pr1.setStroke(Color.BLACK);

        Text f = new Text(80, 240, "Forest");
        f.setFill(Color.BLACK);

        Text pd2 = new Text(180, 240, "Player 2 display");
        pd2.setFill(Color.BLACK);
        Rectangle pr2 = new Rectangle(1000, 125);
        pr2.setStroke(Color.BLACK);


        Text ph2 = new Text(180, 500, "Player 2 hand");
        ph2.setFill(Color.BLACK);
        Rectangle prh2 = new Rectangle(1000, 125);
        prh2.setStroke(Color.BLACK);


        FileInputStream input = new FileInputStream("img/birchbolete.jpg");
        Image image = new Image(input);
        ImageView imageView = new ImageView(image);
        HBox hboxx = new HBox(imageView);


        boolean p1plays=true;
        Player currentPlayer;

        Board.initialisePiles();
        Board.setUpCards();
        Board.getForestCardsPile().shufflePile();

        HBox root3 = new HBox(10);
        //Populate forest
        for (int i=0; i<8;i++) {
            Display duplicate = p1.getDisplay();
            Card cardi = duplicate.getElementAt(i);
            if(cardi.getName() == "birchbolete"){
                input = new FileInputStream("img/birchbolete.jpg");
                image = new Image(input);
                imageView = new ImageView(image);
                hboxx = new HBox(imageView);
                root3.getChildren().add(hboxx);
                root3.setPadding(new Insets(0,10,0,10));
            }
            else if(cardi.getName()  == "honeyfungus"){
                input = new FileInputStream("img/honeyfungus.jpg");
                image = new Image(input);
                imageView = new ImageView(image);
                hboxx = new HBox(imageView);
                root3.getChildren().add(hboxx);
                root3.setPadding(new Insets(0,10,0,10));
            }
            else if(cardi.getName()  == "treeear"){
                input = new FileInputStream("img/treeear.jpg");
                image = new Image(input);
                imageView = new ImageView(image);
                hboxx = new HBox(imageView);
                root3.getChildren().add(hboxx);
                root3.setPadding(new Insets(0,10,0,10));
            }
            else if(cardi.getName()  == "lawyerswig"){
                input = new FileInputStream("img/lawyerswig.jpg");
                image = new Image(input);
                imageView = new ImageView(image);
                hboxx = new HBox(imageView);
                root3.getChildren().add(hboxx);
                root3.setPadding(new Insets(0,10,0,10));
            }
            else if(cardi.getName()  == "shiitake"){
                input = new FileInputStream("img/shiitake.jpg");
                image = new Image(input);
                imageView = new ImageView(image);
                hboxx = new HBox(imageView);
                root3.getChildren().add(hboxx);
                root3.setPadding(new Insets(0,10,0,10));
            }
            else if(cardi.getName()  == "henofwoods"){
                input = new FileInputStream("img/henofwoods.jpg");
                image = new Image(input);
                imageView = new ImageView(image);
                hboxx = new HBox(imageView);
                root3.getChildren().add(hboxx);
                root3.setPadding(new Insets(0,10,0,10));
            }
            else if(cardi.getName()  == "porcini"){
                input = new FileInputStream("img/porcini.jpg");
                image = new Image(input);
                imageView = new ImageView(image);
                hboxx = new HBox(imageView);
                root3.getChildren().add(hboxx);
                root3.setPadding(new Insets(0,10,0,10));
            }
            else if(cardi.getName()  == "chanterelle"){
                input = new FileInputStream("img/chanterelle.jpg");
                image = new Image(input);
                imageView = new ImageView(image);
                hboxx = new HBox(imageView);
                root3.getChildren().add(hboxx);
                root3.setPadding(new Insets(0,10,0,10));
            }
            else if(cardi.getName()  == "morel"){
                input = new FileInputStream("img/morel.jpg");
                image = new Image(input);
                imageView = new ImageView(image);
                hboxx = new HBox(imageView);
                root3.getChildren().add(hboxx);
                root3.setPadding(new Insets(0,10,0,10));
            }
            else if(cardi.getName()  == "Cider"){
                input = new FileInputStream("img/cider.jpg");
                image = new Image(input);
                imageView = new ImageView(image);
                hboxx = new HBox(imageView);
                root3.getChildren().add(hboxx);
                root3.setPadding(new Insets(0,10,0,10));
            }
            else if(cardi.getName()  == "Butter"){
                input = new FileInputStream("img/butter.jpg");
                image = new Image(input);
                imageView = new ImageView(image);
                hboxx = new HBox(imageView);
                root3.getChildren().add(hboxx);
                root3.setPadding(new Insets(0,10,0,10));
            }
            else if(cardi.getName()  == "Pan"){
                input = new FileInputStream("img/pan.jpg");
                image = new Image(input);
                imageView = new ImageView(image);
                hboxx = new HBox(imageView);
                root3.getChildren().add(hboxx);
                root3.setPadding(new Insets(0,10,0,10));
            }
            else if(cardi.getName()  == " Basket"){
                input = new FileInputStream("img/basket.jpg");
                image = new Image(input);
                imageView = new ImageView(image);
                hboxx = new HBox(imageView);
                root3.getChildren().add(hboxx);
                root3.setPadding(new Insets(0,10,0,10));
            }

        }


        VBox root2 = new VBox(10);


        //Populate forest
        for (int i=0; i<8;i++) {
            Board.getForest().add(Board.getForestCardsPile().drawCard());
            Card currentC = Board.getForestCardsPile().drawCard();
            System.out.println(currentC.getName());
            if(currentC.getName() == "birchbolete"){
                input = new FileInputStream("img/birchbolete.jpg");
                image = new Image(input);
                imageView = new ImageView(image);
                hboxx = new HBox(imageView);
                root2.getChildren().add(hboxx);
                root2.setPadding(new Insets(0,10,0,10));
            }
            else if(currentC.getName() == "honeyfungus"){
                input = new FileInputStream("img/honeyfungus.jpg");
                image = new Image(input);
                imageView = new ImageView(image);
                hboxx = new HBox(imageView);
                root2.getChildren().add(hboxx);
                root2.setPadding(new Insets(0,10,0,10));
            }
            else if(currentC.getName() == "treeear"){
                input = new FileInputStream("img/treeear.jpg");
                image = new Image(input);
                imageView = new ImageView(image);
                hboxx = new HBox(imageView);
                root2.getChildren().add(hboxx);
                root2.setPadding(new Insets(0,10,0,10));
            }
            else if(currentC.getName() == "lawyerswig"){
                input = new FileInputStream("img/lawyerswig.jpg");
                image = new Image(input);
                imageView = new ImageView(image);
                hboxx = new HBox(imageView);
                root2.getChildren().add(hboxx);
                root2.setPadding(new Insets(0,10,0,10));
            }
            else if(currentC.getName() == "shiitake"){
                input = new FileInputStream("img/shiitake.jpg");
                image = new Image(input);
                imageView = new ImageView(image);
                hboxx = new HBox(imageView);
                root2.getChildren().add(hboxx);
                root2.setPadding(new Insets(0,10,0,10));
            }
            else if(currentC.getName() == "henofwoods"){
                input = new FileInputStream("img/henofwoods.jpg");
                image = new Image(input);
                imageView = new ImageView(image);
                hboxx = new HBox(imageView);
                root2.getChildren().add(hboxx);
                root2.setPadding(new Insets(0,10,0,10));
            }
            else if(currentC.getName() == "porcini"){
                input = new FileInputStream("img/porcini.jpg");
                image = new Image(input);
                imageView = new ImageView(image);
                hboxx = new HBox(imageView);
                root2.getChildren().add(hboxx);
                root2.setPadding(new Insets(0,10,0,10));
            }
            else if(currentC.getName() == "chanterelle"){
                input = new FileInputStream("img/chanterelle.jpg");
                image = new Image(input);
                imageView = new ImageView(image);
                hboxx = new HBox(imageView);
                root2.getChildren().add(hboxx);
                root2.setPadding(new Insets(0,10,0,10));
            }
            else if(currentC.getName() == "morel"){
                input = new FileInputStream("img/morel.jpg");
                image = new Image(input);
                imageView = new ImageView(image);
                hboxx = new HBox(imageView);
                root2.getChildren().add(hboxx);
                root2.setPadding(new Insets(0,10,0,10));
            }
            else if(currentC.getName() == "Cider"){
                input = new FileInputStream("img/cider.jpg");
                image = new Image(input);
                imageView = new ImageView(image);
                hboxx = new HBox(imageView);
                root2.getChildren().add(hboxx);
                root2.setPadding(new Insets(0,10,0,10));
            }
            else if(currentC.getName() == "Butter"){
                input = new FileInputStream("img/butter.jpg");
                image = new Image(input);
                imageView = new ImageView(image);
                hboxx = new HBox(imageView);
                root2.getChildren().add(hboxx);
                root2.setPadding(new Insets(0,10,0,10));
            }
            else if(currentC.getName() == "Pan"){
                input = new FileInputStream("img/pan.jpg");
                image = new Image(input);
                imageView = new ImageView(image);
                hboxx = new HBox(imageView);
                root2.getChildren().add(hboxx);
                root2.setPadding(new Insets(0,10,0,10));
            }
            else if(currentC.getName() == " Basket"){
                input = new FileInputStream("img/basket.jpg");
                image = new Image(input);
                imageView = new ImageView(image);
                hboxx = new HBox(imageView);
                root2.getChildren().add(hboxx);
                root2.setPadding(new Insets(0,10,0,10));
            }

        }
        // Setup scrollpane
        ScrollPane scrollPnaep1h=new ScrollPane();
        scrollPnaep1h.setContent(root3);
        scrollPnaep1h.setHbarPolicy(ScrollPane.ScrollBarPolicy.ALWAYS);
        scrollPnaep1h.setVbarPolicy(ScrollPane.ScrollBarPolicy.NEVER);
        // Setup scrollpane
        ScrollPane scrollPnae=new ScrollPane();
        scrollPnae.setContent(root2);
        scrollPnae.setHbarPolicy(ScrollPane.ScrollBarPolicy.ALWAYS);
        scrollPnae.setVbarPolicy(ScrollPane.ScrollBarPolicy.NEVER);
        //adding scroll pane to the scene
        VBox root = new VBox(10);
        root.getChildren().addAll(ph1, scrollPnaep1h, pd1, pr1, f, scrollPnae, pd2, pr2, ph2, prh2);
        Scene scene = new Scene(root);


        //Initialise players and populate player hands
        p1  = new Player(); currentPlayer=p1; p2 = new Player();
        p1.addCardtoHand(Board.getForestCardsPile().drawCard());p1.addCardtoHand(Board.getForestCardsPile().drawCard());p1.addCardtoHand(Board.getForestCardsPile().drawCard());
        p2.addCardtoHand(Board.getForestCardsPile().drawCard());p2.addCardtoHand(Board.getForestCardsPile().drawCard());p2.addCardtoHand(Board.getForestCardsPile().drawCard());


        stage.setScene(scene);
        stage.setTitle("Fungi game");
        stage.show();
    }

    public static void main(String args[]){
        launch(args);
    }

}
