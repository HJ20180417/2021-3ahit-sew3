import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class MainApp {
    public static void main(String[] args) {
        Vogel vogel = new Vogel("Gustav",false,50,true);
        Katze katze = new Katze("Nelli",true,10,vogel);
        Hund hund = new Hund("Manni",true,100);

        System.out.println(vogel.beschreibung());
        System.out.println(katze.beschreibung());
        System.out.println(hund.beschreibung());
    }



}
