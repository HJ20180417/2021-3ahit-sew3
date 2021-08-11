public class StringInverter {
    public String turnStrArround(String text) {

        //with recursion
        if (text.length() <= 0) {
            return "";
        }
        /*at first the last char of the String is saved in the local char "last", then the other chars of the String are saved in the local String "rest", at last it calls the recursion, so everytime the last
        char will be appended*/
        else {
            char last = text.charAt(text.length() - 1);
            String rest = text.substring(0, text.length() - 1);
            return last + turnStrArround(rest);
        }
    }

    public String turnStringAroundWithoutRecursion(String text) {
        //without recursion
        String[] arrText = text.split(""); //split the text into chars
        StringBuilder str = new StringBuilder();
        for (int l = text.length() - 1; l >= 0; l--) {
            str.append(arrText[l]); //append every word to the StringBuilder, begin with the last char
        }
        return str.toString(); //return the String
    }
}
