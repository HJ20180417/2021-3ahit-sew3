package string_pkg;

public class Wordprocessor {
    String process(String str) {
        StringBuilder result = new StringBuilder();
        for (String v : str.split(" ")) {
            if (v.startsWith("_")) {
                v = v.toUpperCase().substring(1);
            }
            if (v.endsWith("_")) {
                v = v.toLowerCase();
                v = v.substring(0, v.length() - 1);
            }
            result.append(v + " ");
        }
        str = result.toString().trim();
        return str;
    }
}
