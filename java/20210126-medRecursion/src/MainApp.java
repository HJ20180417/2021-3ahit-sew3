import java.util.Scanner;

public class MainApp {
    public static void main(String[] args) {
        double medikamentenmenge;

        Scanner sc = new Scanner(System.in);
        System.out.printf("Type in the days since the drug last was taken\n");
        int days = sc.nextInt();
        sc.close();
        System.out.println(getMedikamentenmenge(days,5));
    }
    public static double getMedikamentenmenge(int days, double medikamentenmenge){
        if(days == 0){
            return medikamentenmenge;
        }
        medikamentenmenge = medikamentenmenge * 0.6;
        medikamentenmenge += 5;
        return getMedikamentenmenge(days - 1,medikamentenmenge);
    }
}
