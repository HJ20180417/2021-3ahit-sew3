public class Collaborator implements BSable,IGoon {

    private String name;

    public Collaborator(String name) {
        this.name = name;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    @Override
    public void performBsTask() {
        System.out.println(name + " is performing a bs task...");
    }

    @Override
    public void bullySomeone(Collaborator c) {
        System.out.println(name + " is bullying " +c.getName());
    }


}
