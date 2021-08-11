import java.util.Locale;

public class MessageEncoder extends MessageTransmitter {

    public MessageEncoder(String email, String msg) {
        super(email, msg);
    }

    public String encryptMsg() {
        String msg = getMsg();
        //make the msg to lower case
        msg.toLowerCase();
        //replace the things with the properties
        msg = msg.replace("a", "1");
        msg = msg.replace("e", "3");
        msg = msg.replace("i", "5");
        msg = msg.replace("o", "7");
        msg = msg.replace("u", "9");

        //return the right value
        return msg;
    }
}
