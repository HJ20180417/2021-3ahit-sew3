package calculator;

public class DieselMotor implements Motor{

    @Override
    public void start() {
        System.out.println("Dieselmotor wird gestartet. ");
    }

    @Override
    public void stop() {
        System.out.println("Dieselmotor wird abgestellt. ");
    }

    @Override
    public void brake() {
        System.out.println("Es wird gebremst. ");
    }

    @Override
    public void faster() {
        System.out.println("Dieselmotor beschleunigt. ");
    }
}
