public class BaseImage {
    private int width, height;
    private Byte pixels[][];

    public BaseImage(int width, int height) {
        this.width = width;
        this.height = height;
        pixels = new Byte[width][height];
    }
}
