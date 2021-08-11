import grid.Grid2D;
import grid.GridAnalyzer;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class MainApp {
    public static final String RESOURCES_PATH = System.getProperty("user.dir") + "\\20210121-CCC\\res";

    public static void main(String[] args) {

        Grid2D g1 = new Grid2D(RESOURCES_PATH + "\\level1_0.in");
        System.out.println(g1.getStringRepresentation());
        Grid2D g2 = new Grid2D(5,5);
        g2.setvalueAt(2,2,9);
        g2.setvalueAt(3,3,10);
        //print self-created grid
        System.out.println(g2.getStringRepresentation());

        GridAnalyzer ga = new GridAnalyzer();
        //check if grid has a building
        if(ga.gridHasBuilding(g2)){
            System.out.println("Building found!");
        }
        else{
            System.out.println("No Building found!");
        }

        ga.findBuildings(g1);
    }
}
