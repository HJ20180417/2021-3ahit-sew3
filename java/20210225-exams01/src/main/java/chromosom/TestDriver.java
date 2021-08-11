package chromosom;

public class TestDriver {
    public static void main(String[] args) {
        XChromosome x = new XChromosome("CTGA","CTGA");

        x.checkDNAStrand("AAAA");
        x.checkDNAStrand("ABABA");
    }
}
