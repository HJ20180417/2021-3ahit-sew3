package grid;

public class Building {

    private int height;
    private int surfaceArea;

    public Building(int height) {
        this.height = height;
        this.surfaceArea = 0;
    }

    public int getHeight() {
        return height;
    }

    public int getSurfaceArea() {
        return surfaceArea;
    }

    public void increaseSurfaceArea() {
        this.surfaceArea += 1;
    }
}
