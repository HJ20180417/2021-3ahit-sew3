public class Hund extends Haustier{
    private String rasse;

    public Hund(String name, Boolean steuerpflichtig, double kosten) {
        super(name, steuerpflichtig, kosten);
    }

    public String getRasse() {
        return rasse;
    }

    @Override
    public String beschreibung() {
        return super.beschreibung();
    }
}
