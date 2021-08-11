package calculator;

public class BasicCalculator extends SimpleCalculator implements IBasicCalculator {
    @Override
    public double pow(double x, double n) {
        return Math.pow(x,n);
    }

    @Override
    public double rootOf(double x, double n) {
        if(n == 2) { return Math.sqrt(x); }
        else { return Math.pow(x, 1./n); }
    }
}
