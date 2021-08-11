package calculator;

public class Auto {
    private Motor m;

    public Auto(Motor m) {
        this.m = m;
    }

    public void start() {
        m.start();
    }
    public void stop() {
        m.stop();
    }
    public void brake() {
        m.brake();
    }
    public void faster() {
        m.faster();
    }
}
