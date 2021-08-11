public class Katze extends Haustier {
    private Vogel freund;

    public Katze(String name, Boolean steuerpflichtig, double kosten,Vogel piep) {
        super(name, steuerpflichtig=false, kosten);
        this.freund = piep;
    }

    public String vogel(){
        return " " + getName() + "s"+" Lieblingsvogel ist " + freund.getName();
    }

    @Override
    public String beschreibung() {
        return super.beschreibung() + vogel();
    }
}
