public class Manager extends Employee implements ITaskMaster{

    private double commission;
    private double turnover;

    public Manager(String name, double monthlySalary, double commission, double turnover) {
        super(name, monthlySalary);
        this.commission = commission;
        this.turnover = turnover;
    }

    public double getCommission() {
        return commission;
    }

    public void setCommission(double commission) {
        this.commission = commission;
    }

    public double getTurnover() {
        return turnover;
    }

    public void setTurnover(double turnover) {
        this.turnover = turnover;
    }

    @Override
    public void bullySomeone(Collaborator c){
        System.out.println("Manager " + getName() + " is giving " + c.getName() + " a new task.");
    }

    @Override
    public BSable createNewBsJob() {
        return new Collaborator("name not known");
    }
}
