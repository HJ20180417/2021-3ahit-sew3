package string_pkg;

import com.sun.tools.javac.Main;

public class MainApp {
    public static void main(String[] args) { //psvm

        /* just some testing during the lesson
        int x = 5;
        int y = 3;
        int sum = 0;
        String name = "Jakob";
        String name3 = "Jakob";
        boolean checker;

        System.out.println("Calculate sum of " + x + "+" + y + " is"); //sout

        sum = x + y;

        System.out.println("The answer is: " + sum);

        if(name.equals(name3)){
            checker = true;
        }
        else checker = false;

        if(checker == false){
            System.out.println("The Strings aren't equal!");
        }
        else System.out.println("The Strings are equal");

        if(name == name3){
            checker = true;
        }
        else checker = false;

        if(checker == false){
            System.out.println("The Strings aren't equal!");
        }
        else System.out.println("The Strings are equal");

         */
        Wordprocessor wp = new Wordprocessor();
        MainScannerApp scan = new MainScannerApp();

        String[] strArr = {"meiN_ _Name iSt _Hase. Ich weiß BESCHEID._ _wirklich!", "_Split_Text_ _abc_def xyz_", "_Piraten  si_nd_ cool_"};
        for (String str : strArr) {
            System.out.println("not processed: " + str);
            System.out.println("-- > processed: " + wp.process(str));
        }


    }
}
