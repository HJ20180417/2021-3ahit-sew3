package regExp;

public class RegularExpressions {
    public boolean containsJimOrJoe(String Text) {
        return Text.matches(".*J(im|oe).*");
    }
    public boolean isPhoneNumber(String number){
        return number.matches(".*\\d{7}|(\\d){3}(\\s|-)(\\d){4}.*");
    }
    public boolean isDate(String date){ return date.matches(".*3[0-1]|2[1-9]|1[1-9]|0[1-9]\\.0[1-9]|1[0-2]\\.\\d{0,}.*");}
    public boolean above3000(String num){ return num.matches(".*[3-9]\\d{3}|\\d{5,}.*");}
    public boolean htmlFinder(String html){ return html.matches(".*<u>\\w{0,}</u>.*");}
}
//ddmmyyyy