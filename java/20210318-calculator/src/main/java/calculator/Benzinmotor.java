package calculator;

public class Benzinmotor implements Motor{

    @Override
    public void start() {
        System.out.println("Benzinmotor wird gestartet. ");
    }

    @Override
    public void stop() {
        System.out.println("Benzinmotor wird abgestellt. ");
    }

    @Override
    public void brake() {
        System.out.println("Es wird gebremst. ");
    }

    @Override
    public void faster() {
        System.out.println("Benzinmotor beschleunigt. ");
    }
}
