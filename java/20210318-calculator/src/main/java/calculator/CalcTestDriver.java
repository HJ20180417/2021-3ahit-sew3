package calculator;

public class CalcTestDriver {
    public static void main(String[] args) {

        SimpleCalculator simpleCalc = new SimpleCalculator();
        ICalculator simpleCalc2 = new SimpleCalculator();
        System.out.println(simpleCalc.div(7.765, 0.0));

        useCalculator(simpleCalc);
        //useCalculator(simpleCalc2);
    }
    private static void useCalculator(SimpleCalculator calc){
        System.out.println(calc.mult(2,3));
    }
}
