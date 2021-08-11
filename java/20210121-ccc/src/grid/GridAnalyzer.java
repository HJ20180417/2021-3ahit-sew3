package grid;

public class GridAnalyzer {
    public boolean gridHasBuilding(Grid2D grid) {
        //check element for element if there is a building
        for (int r = 0; r < grid.getRows(); r++) {
            for (int c = 0; c < grid.getCols(); c++) {
                if (grid.getvalueAt(r, c) > 0) {
                    return true;
                }
            }
        }
        return false;
    }

    public void findBuildings(Grid2D grid) {
        Grid2D visitedPositions = new Grid2D(grid.getRows(), grid.getCols());

        for (int r = 0; r < grid.getRows(); r++) {
            for (int c = 0; c < grid.getCols(); c++) {
                //check if there is a building (0 -> no building, 1-> building)
                if (grid.getvalueAt(r, c) > 0 && visitedPositions.getvalueAt(r, c) == 0) {
                    Building b = new Building(grid.getvalueAt(r, c)); //create a Building Object for the current row and column
                    this.findNeighbours(r, c, grid, visitedPositions, b); //run method to find out if there are neighbours
                    System.out.println("Found Building: area= " + b.getSurfaceArea() + " height= " + b.getHeight()); //print the final result
                }
            }
        }
    }

    private void findNeighbours(int r, int c, Grid2D grid, Grid2D visitedPositions, Building b) {

        visitedPositions.setvalueAt(r, c, 1);
        b.increaseSurfaceArea();
        //above
        if (r > 0 && grid.getvalueAt(r - 1, c) == b.getHeight() && visitedPositions.getvalueAt(r - 1, c) == 0) {
            this.findNeighbours(r - 1, c, grid, visitedPositions, b);
        }
        //below
        if (r < grid.getRows() - 1 && grid.getvalueAt(r + 1, c) == b.getHeight() && visitedPositions.getvalueAt(r + 1, c) == 0) {
            this.findNeighbours(r + 1, c, grid, visitedPositions, b);
        }
        //left
        if (c > 0 && grid.getvalueAt(c - 1, r) == b.getHeight() && visitedPositions.getvalueAt(c - 1, r) == 0) {
            this.findNeighbours(c - 1, r, grid, visitedPositions, b);
        }
        //right
        if (c < grid.getCols() - 1 && grid.getvalueAt(c + 1, r) == b.getHeight() && visitedPositions.getvalueAt(c + 1, r) == 0) {
            this.findNeighbours(c + 1, r, grid, visitedPositions, b);
        }

    }
}
