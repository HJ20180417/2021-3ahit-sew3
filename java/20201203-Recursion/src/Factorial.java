public class Factorial {
    public static int calcFactorialOf(int n) throws NegativeNumberException {
        //if the parsed number is negative throw the exception, negative numbers aren't allowed
        if (n < 0) {
            throw new NegativeNumberException();
        }
        if (n == 0 || n == 1) { //Factorial of 0 = 1 and Factorial of 1 = 1
            return 1;
        } else { //if the number isn't 0 or 1 or negative calculate the factorial of it
            return calcFactorialOf(n - 1) * n;
        }

    }
}
