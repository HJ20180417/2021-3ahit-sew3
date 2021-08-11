package regExp;

public class MainApp {
    public static void main(String[] args) {
        RegularExpressions exp = new RegularExpressions();
        String number = "+43 660 2005529";
        String Text = "Jim, Jim, Jim und Joe sind toll!";
        String date = "30.02.2004";
        String num = "10000";
        String html = "<u>Hello</>";
        //call the methods to check with regExps
        boolean check1 = exp.containsJimOrJoe(Text);
        boolean check2 = exp.isPhoneNumber(number);
        boolean check3 = exp.isDate(date);
        boolean check4 = exp.above3000(num);
        boolean check5 = exp.htmlFinder(html);
        if(check1 == true){
            System.out.println("Jim und/oder Joe wurde gefunden");
        }
        else System.out.println("Jim und/oder Joe wurde nicht gefunden");

        if(check2 == true){
            System.out.println("Es ist eine gültige Nummer!");
        }
        else System.out.println("Es ist keine gültige Nummer!");

        if(check3 == true){
            System.out.println("Date valid");
        }
        else System.out.println("Date not valid");
        if(check4 == true){
            System.out.println("above");
        }
        else System.out.println("not above");
        if(check5 == true){
            System.out.println("html");
        }
        else System.out.println("not html");

    }


}
