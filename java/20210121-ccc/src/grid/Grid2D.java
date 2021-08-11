package grid;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class Grid2D {
    /// member variables
    private int rows;
    private int cols;
    private int[][] cells;

    /// constructor
    public Grid2D(int rows, int cols) {
        this.rows = rows;
        this.cols = cols;

        cells = new int[rows][cols];
    }

    /// copy constructor
    public Grid2D(Grid2D grid) {
        this.rows = grid.getCols();
        this.cols = grid.getCols();

        cells = new int[grid.getRows()][grid.getRows()];

        for (int i = 0; i < this.getRows(); i++) {
            for (int l = 0; l < this.getRows(); l++) {
                this.setvalueAt(i, l, grid.getvalueAt(i, l));
            }
        }
    }

    ///file reader constructor
    public Grid2D(String fileName) {
        try  {
            Scanner scanner = new Scanner(new File(fileName));
            String firstLine = scanner.nextLine();
            String[] rowsAndCols = firstLine.split(" ");
            this.rows = Integer.valueOf(rowsAndCols[0]);
            this.cols = Integer.valueOf(rowsAndCols[1]);
            this.cells = new int[this.rows][this.cols];
            int j=0;
            while(scanner.hasNext()){
                String line = scanner.nextLine();
                String[] s = line.split(" ");
                for (int i = 0; i <s.length ; i++) {
                    cells[i][j]=Integer.valueOf(s[i]);
                }
                j++;
            }
            scanner.close();
        }
    catch (FileNotFoundException e){
            System.out.println(e);
        }
    }

    /// getter/(setter)
    public int getRows() {
        return rows;
    }

    public int getCols() {
        return cols;
    }

    public int[][] getCells() {
        return cells;
    }

    /// other methods
    public int getvalueAt(int row, int col) {
        // @todo handle ArrayOutOfBoundsException
        return cells[row][col];
    }

    public void setvalueAt(int row, int col, int val) {
        // @todo handle ArrayOutOfBoundsException
        cells[row][col] = val;
    }

    public String getStringRepresentation() {
        StringBuilder sb = new StringBuilder("");
        sb.append("Rows = " + this.getRows() + "\n");
        sb.append("Cols = " + this.getCols() + "\n");
        sb.append("CellValues =\n");
        for (int i = 0; i < this.getRows(); i++) {
            for (int l = 0; l < this.getRows(); l++) {
                sb.append(this.getvalueAt(i, l) + " ");
            }
            sb.append("\n");
        }
        return sb.toString().trim();
    }
}
