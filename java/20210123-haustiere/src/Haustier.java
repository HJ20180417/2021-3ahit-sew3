public abstract class Haustier {
    private String name;
    private Boolean steuerpflichtig;
    private double kosten;
    private Boolean singvogel;

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public Boolean getSteuerpflichtig() {
        return steuerpflichtig;
    }

    public Haustier(String name, Boolean steuerpflichtig, double kosten) {
        this.name = name;
        this.steuerpflichtig = steuerpflichtig;
        this.kosten = kosten;
    }


    public String beschreibung() {
        return "Sein Name ist: " + getName() + " er hat eine steuerpflicht von: " + getSteuerpflichtig();
    }
}
