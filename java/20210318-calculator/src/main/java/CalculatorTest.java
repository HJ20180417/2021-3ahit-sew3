import javax.swing.text.html.HTMLDocument;

public class CalculatorTest {
    public static void main(String[] args) {
        SimpleCalculator simCalc = new SimpleCalculator();
        ICalculator simpCalc = new SimpleCalculator();
        IBasicCalculator basCalc = new BasicCalculator();
        ScientificCalculator sciCalc = new ScientificCalculator();

        System.out.println(sciCalc.tan(17));
        System.out.println(simpCalc.mult(4,5));
        System.out.println(simCalc.div(7, 0));
        System.out.println(basCalc.root(27,3));
    }

}
