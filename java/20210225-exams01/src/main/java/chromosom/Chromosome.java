package chromosom;

import java.util.Locale;

public class Chromosome {

    protected String strandA;
    protected String strandB;

    public Chromosome(String strandA, String strandB) {
        this.strandA = strandA;
        this.strandB = strandB;
    }

    public String getDNAStrand(int i){
        if(i==1){
            return strandA;
        }
        else if(i==2){
            return strandB;
        }
        else{
            return null;
        }
    }

    public boolean checkDNAStrand(String strand){
        return strand.toUpperCase().matches("[CAGT]+");
    }

    public int calcHammingDistance(){
        return 0;
    }
}
