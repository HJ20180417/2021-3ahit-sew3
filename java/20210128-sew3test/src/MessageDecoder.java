import java.util.Locale;

public class MessageDecoder extends MessageTransmitter {

    public MessageDecoder(String email, String msg) {
        super(email, msg);
    }

    public String decryptMsg(String encryptedMsg) {

        //same principle as encrypt msg, but the other way
        encryptedMsg.toLowerCase(Locale.ROOT);

        //replace the things with the properties
        encryptedMsg = encryptedMsg.replace("1", "a");
        encryptedMsg = encryptedMsg.replace("3", "e");
        encryptedMsg = encryptedMsg.replace("5", "i");
        encryptedMsg = encryptedMsg.replace("7", "o");
        encryptedMsg = encryptedMsg.replace("9", "u");

        //return the right value
        return encryptedMsg;
    }
}
