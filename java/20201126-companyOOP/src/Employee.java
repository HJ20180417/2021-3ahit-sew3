public class Employee extends Collaborator implements IFlunky,IBoxTicker{

    private double monthlySalary;

    public Employee(String name, double monthlySalary) {
        super(name);
        this.monthlySalary = monthlySalary;
    }

    public double getMonthlySalary() {
        return monthlySalary;
    }

    public void setMonthlySalary(double monthlySalary) {
        this.monthlySalary = monthlySalary;
    }

    @Override
    public void tickList(int id) {
        System.out.println(getName() + " is ticking the box " + id);
    }

    @Override
    public void showOff() {
        System.out.println(getName() + " is showing off.");
    }
}
