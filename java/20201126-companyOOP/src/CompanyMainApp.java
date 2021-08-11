//just some basic OOP-Concepts no comments needed

public class CompanyMainApp {
    public static void main(String[] args) {
        Worker w = new Worker("Willi",10,20);
        Employee e = new Employee("Eddi",2000);
        Manager m = new Manager("Manfred",2000,0.03,7000);

        m.performBsTask();
        m.bullySomeone(w);
        m.bullySomeone(e);
        e.bullySomeone(w);
        w.bullySomeone(w);

        w.fixItTemporary(23);
        w.fixItTemporary(42);

        e.tickList(10);
        e.showOff();

        BSable bs = m.createNewBsJob();
        bs.performBsTask();
    }
}
