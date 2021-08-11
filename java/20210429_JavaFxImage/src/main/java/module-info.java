module at.litec {
    requires javafx.controls;
    requires javafx.fxml;

    opens at.litec to javafx.fxml;
    exports at.litec;
}