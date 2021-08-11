
public class MessageTransmitter {
    private String email;
    private String msg;
    StringBuilder sb = new StringBuilder();
    int n = 0;

    public MessageTransmitter(String email, String msg) {
        this.email = email;
        this.msg = msg;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getMsg() {
        return msg;
    }

    public void setMsg(String msg) {
        this.msg = msg;
    }

    public boolean hasValidMailAdress() {
        return getEmail().matches("^[A-Za-z0-9+_.-]+@(.+)$");
    }

    public String swapMsg(String msg2flip) {
        String[] strArr = msg2flip.split(" ");
        if (n == strArr.length) {
            return sb.toString();
        } else {
            n += 1;
            int j = strArr.length - n;
            String lastWord = strArr[j];
            sb.append(lastWord + " ");
            return swapMsg(msg2flip);
        }
    }
}
