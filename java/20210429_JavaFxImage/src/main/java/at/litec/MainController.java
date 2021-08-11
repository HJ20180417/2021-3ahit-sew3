package at.litec;

import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;
import javafx.fxml.FXML;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.image.Image;
import javafx.scene.image.ImageView;
import javafx.stage.FileChooser;

public class MainController {
     @FXML
     Label lblInfo;

     @FXML
     Button btnOpenImage;

     @FXML
     ImageView ivImg;

     @FXML
    private void onBtnOpenImageClicked() throws IOException{
         FileChooser fc = new FileChooser();
         fc.getExtensionFilters().addAll(
             new FileChooser.ExtensionFilter("JPEG Files", "*.jpg"),
             new FileChooser.ExtensionFilter("BMP Files", "*.bmp"),
             new FileChooser.ExtensionFilter("PNG Files", "*.png")
        );
        File imageFile= fc.showOpenDialog(App.getMainStage());
        lblInfo.setText(imageFile.getAbsolutePath());

         FileInputStream input = new FileInputStream(imageFile.getAbsolutePath());
         Image image = new Image(input);
         ivImg.setImage(image);
     }
}
