/*Ein Array wird von vorne nach hinten durchlaufen.
Hierbei wird geprüft, ob das jeweilige Element kleiner als sein Nachfolgeelement ist.
Ist dies der Fall wird die Schleife fortgesetzt. Falls nicht, so werden das aktuelle Element
und sein Nachfolger getauscht, sodass das kleinere Element nun vor dem größeren liegt.
Durch rekursiven Aufruf der Methode wird der Schleifendurchlauf erneut gestartet bis eine
aufsteigende Sortierung vorliegt.
 */
public class SortApp {
    public static void main(String[] args) {
        int n=0;
        int numbers[] = {7,34,5,12,11,18,25,44,1,100};
        int[] sortedNums = bubbleSort(numbers,n);
        for(int l=0;l<sortedNums.length;l++){
            System.out.println(sortedNums[l]);
        }
    }
    public  static int[] bubbleSort(int numbers[],int n) {
        int check = 0;
        for(int i = 0;i<=numbers.length-2;i++){
            if(numbers[i]<numbers[i+1]){
                check += 1;
            }
        }
        if(n == 9){
            n=0;
        }
            if (check != numbers.length-1) {
                if (numbers[n] < numbers[n + 1]) {
                    return bubbleSort(numbers, n + 1);
                } else {
                    int temp = numbers[n];
                    numbers[n] = numbers[n + 1];
                    numbers[n + 1] = temp;
                    return bubbleSort(numbers, n + 1);
                }
            }
            else {
                return numbers;
            }
    }
}
