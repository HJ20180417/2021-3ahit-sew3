package string_pkg;

import java.io.File;
import java.sql.SQLOutput;
import java.util.InputMismatchException;
import java.util.Scanner;
import java.io.IOException;
import java.io.FileNotFoundException;


public class MainScannerApp {

    public static void main(String[] args) {
        int choose;
        Wordprocessor wp = new Wordprocessor();
        Scanner in = new Scanner(System.in);
        Scanner in2 = new Scanner(System.in);
        System.out.println("Do you want to read in your data from file (1) or console (2)?");
        choose = in.nextInt();
        if (choose == 2) {
            System.out.println("Geben Sie einen Text ein!");
            String text = in.nextLine();
            in = in2;
            text = in2.nextLine();
            String res = wp.process(text);
            System.out.println(res);
            in.close();
        } else {
            String path;
            System.out.println("Type in the path you want to scan!");
            Scanner readPath = new Scanner(System.in);
            path = readPath.next();
            StringBuilder result = new StringBuilder();
            try {
                Scanner scanner = new Scanner(new File(path));
                Scanner scanner2 = new Scanner(new File(path));

                while (scanner.hasNext()) { // read as long as there is data
                    String line = scanner.nextLine();
                    scanner = scanner2;
                    String s = scanner2.nextLine();
                    s = wp.process(line);

                    for (String str : s.split(" ")) {
                        result.append(str + " ");
                    }
                    System.out.print(result);

                }
                scanner.close();
            } catch (FileNotFoundException e) {
                System.out.println("File not found!");
            }
        }


    }
}
