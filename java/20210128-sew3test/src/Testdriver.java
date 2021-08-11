import java.util.Scanner;

public class Testdriver {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Type in the text: ");
        String text = sc.nextLine();
        System.out.println("Type in the email: ");
        String email = sc.nextLine();
        MessageEncoder me = new MessageEncoder(email, text);
        MessageDecoder md = new MessageDecoder(email, text);
        MessageTransmitter mt = new MessageTransmitter(email, text);
        String encMsg = me.encryptMsg();
        System.out.println("Encrypted message " + encMsg);
        String decMsg = md.decryptMsg(encMsg);
        System.out.println("Decrypted Message: " + decMsg);
        System.out.println(mt.hasValidMailAdress());
        String turnedString = mt.swapMsg(text);
        System.out.println("Gedrehter String: " + turnedString);
    }
}
