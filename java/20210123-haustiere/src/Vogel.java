public class Vogel extends Haustier{

    private Boolean singvogel;

    public Vogel(String name, Boolean steuerpflichtig, double kosten,Boolean singvogel) {
        super(name, steuerpflichtig, kosten);
        this.singvogel = singvogel;
    }

    public Boolean kannSingen(Boolean singvogel){
        return this.singvogel;
    }

    @Override
    public String beschreibung() {
        return super.beschreibung() + " kann singen: " + this.singvogel;
    }
}
