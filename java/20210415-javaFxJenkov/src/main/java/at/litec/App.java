package at.litec;

import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.TextField;
import javafx.scene.layout.VBox;
import javafx.stage.Stage;

import java.io.IOException;

/**
 * JavaFX App
 */
public class App extends Application {

    private static Scene scene;
    private static Stage localStage;
    private static TextField txtBlaBla;

    @Override
    public void start(Stage stage) throws IOException {
        this.localStage =stage;
        scene = new Scene(loadFXML("primary"), 640, 480);
        nonMVCTryout(stage);
        stage.setScene(scene);
        stage.show();
    }
    private static void nonMVCTryout(Stage stage){
        Parent parent = scene.getRoot(); // parent element is a v-box
        VBox vb = (VBox) parent;

        txtBlaBla = new TextField("Bla Bla");
        txtBlaBla.setMaxWidth(200);

        vb.getChildren().add(txtBlaBla);
        //parent.getChildrenUnmodifiable().add(txtBlaBla);
    }

    static void setRoot(String fxml) throws IOException {
        scene.setRoot(loadFXML(fxml));
        if(fxml.equals("primary")){
            nonMVCTryout(localStage);
        }
    }

    private static Parent loadFXML(String fxml) throws IOException {
        FXMLLoader fxmlLoader = new FXMLLoader(App.class.getResource(fxml + ".fxml"));
        return fxmlLoader.load();
    }

    public static void main(String[] args) {
        launch();
    }

}
