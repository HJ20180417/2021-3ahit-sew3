package calculator;

public class Elektromotor implements Motor{
    @Override
    public void start() {
        System.out.println("Elektromotor wird gestartet. ");
    }

    @Override
    public void stop() {
        System.out.println("Elektromotor wird abgestellt. ");
    }

    @Override
    public void brake() {
        System.out.println("Elektromotor bremst und generiert Strom dabei. ");
    }

    @Override
    public void faster() {
        System.out.println("Elektromotor beschleunigt. ");
    }
}
