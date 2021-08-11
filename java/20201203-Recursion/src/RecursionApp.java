import java.io.Serializable;

public class RecursionApp {
    public static void main(String[] args) throws NegativeNumberException {
        try {
            System.out.println("Factorial of 10: " + Factorial.calcFactorialOf(10));
            System.out.println("Factorial of 3: " + Factorial.calcFactorialOf(3));
            System.out.println("Factorial of -5: " + Factorial.calcFactorialOf(-5));
        } catch (NegativeNumberException e) {
            System.out.println(e);
        }
        StringInverter str = new StringInverter();
        String text = "Hallo 3AHIT";
        System.out.println("Standard Text " + text);
        String turnedText = str.turnStrArround(text);
        System.out.println("Gedrehter Text: " + turnedText);
        System.out.print("Gedrehter Text mit eigenem Algorithmus: ");
        System.out.println(str.turnStringAroundWithoutRecursion(text));
    }
}
