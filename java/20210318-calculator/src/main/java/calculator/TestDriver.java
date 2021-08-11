package calculator;

public class TestDriver {
    public static void main(String[] args) {
        Auto e = new Auto(new Elektromotor());
        e.start();
        e.faster();
        e.brake();
        e.stop();
        System.out.println();

        Auto b = new Auto(new Benzinmotor());
        b.start();
        b.faster();
        b.brake();
        b.stop();
        System.out.println();

        Auto d = new Auto(new DieselMotor());
        d.start();
        d.faster();
        d.brake();
        d.stop();
        System.out.println();
    }
}
