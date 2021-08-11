package calculator;

public class SpecialCalculator implements ICalculator, IBasicCalculator, IScientificCalculator{
    @Override
    public double pow(double x, double n) {
        if(n<0 || x<0) { return 0; }
        else { return Math.pow(x, n); }
    }

    @Override
    public double rootOf(double x, double n) {
        if(n<0 || x<0) { return 0; }
        else { return Math.pow(x, 1./n); }
    }

    @Override
    public double add(double x, double y) {
        if(y<0 || x<0) { return 0; }
        else { return x+y; }
    }

    @Override
    public double sub(double x, double y) {
        if(y<0 || x<0) { return 0; }
        else { return x-y; }
    }

    @Override
    public double mult(double x, double y) {
        if(y<0 || x<0) { return 0; }
        else { return x*y; }
    }

    @Override
    public double div(double x, double y) {
        if(y<0 || x<0) { return 0; }
        else { return x/y; }
    }

    @Override
    public double sin(double x) {
        if(x<0) { return 0; }
        else { return Math.sin(x); }
    }

    @Override
    public double cos(double x) {
        if(x<0) { return 0; }
        else { return Math.cos(x); }
    }

    @Override
    public double tan(double x) {
        if(x<0) { return 0; }
        else { return Math.tan(x); }
    }
}
