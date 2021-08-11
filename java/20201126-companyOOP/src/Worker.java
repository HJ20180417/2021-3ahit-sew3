public class Worker extends Collaborator implements IDuctTaper{

    private double hourlyWage;
    private double workingHoursCount;

    public Worker(String name, double hourlyWage, double workingHoursCount) {
        super(name);
        this.hourlyWage = hourlyWage;
        this.workingHoursCount = workingHoursCount;
    }

    public double getHourlyWage() {
        return hourlyWage;
    }

    public void setHourlyWage(double hourlyWage) {
        this.hourlyWage = hourlyWage;
    }

    public double getWorkingHoursCount() {
        return workingHoursCount;
    }

    public void setWorkingHoursCount(double workingHoursCount) {
        this.workingHoursCount = workingHoursCount;
    }

    @Override
    public void fixItTemporary(int id) {
        System.out.println(getName() + " is fixing Task number " + id);
    }
}
