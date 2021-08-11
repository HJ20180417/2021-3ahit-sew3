package calculator;

public class ScientificCalculator extends BasicCalculator implements IScientificCalculator{
    @Override
    public double sin(double x) {
        return Math.sin(x);
    }

    @Override
    public double cos(double x) {
        return Math.cos(x);
    }

    @Override
    public double tan(double x) {
        return Math.tan(x);
    }
}
