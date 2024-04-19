import { StatusBar } from "expo-status-bar";
import {
  Image,
  Modal,
  StyleSheet,
  Text,
  TouchableOpacity,
  View,
} from "react-native";

import { Camera, CameraType } from "expo-camera";
import * as MediaLibrary from "expo-media-library";

import { useEffect, useState, useRef } from "react";
import { FontAwesome } from "@expo/vector-icons";

export default function App() {
  const [tipoCamera, setTipoCamera] = useState(CameraType.front);
  const cameraRef = useRef(null);
  const [showModal, setShowModal] = useState(false);
  const [photo, setPhoto] = useState(null);

  /*
  1- quando salvar a foto e clicar na lixeira - remover da galeria
  2- permitir a foto com flash
  3- botao para recarregar o autofocus
  4- capturar e salvar video
   */

  useEffect(() => {
    (async () => {
      const { status: cameraStatus } =
        await Camera.requestCameraPermissionsAsync();

      const { status: mediaStatus } =
        await MediaLibrary.requestPermissionsAsync();
    })();
  }, []);

  async function capturePhoto() {
    if (cameraRef != null) {
      const photo = await cameraRef.current.takePictureAsync();

      setPhoto(photo.uri);

      setShowModal(true);

      console.log(photo);
    }
  }

  async function UploadPhoto() {
    await MediaLibrary.createAssetAsync(photo)
      .then(() => {
        alert("Foto salva com sucesso");
      })
      .catch((error) => {
        alert("Não foi possível processar a foto");
      });
  }

  const ClearPhoto = async () => {
    if (!photo) {
      console.log("Nenhuma foto salva para remover.");
      return;
    }

    try {
      const asset = await MediaLibrary.getAssetInfoAsync(photo);
      if (asset) {
        await MediaLibrary.deleteAssetsAsync(asset.id);
        console.log("Foto removida da galeria com sucesso.");
        setPhoto(null); // Limpar o estado da foto
        setShowModal(false);
      }
    } catch (error) {
      console.error("Erro ao remover foto da galeria:", error);
    }
  };

  // async function ClearPhoto() {
  //   await MediaLibrary.deleteAssetsAsync(photo)
  //     .then(() => {
  //       alert("Foto deletada com sucesso");
  //     })
  //     .catch((error) => {
  //       alert("Não foi possível processar a foto");
  //     });
  //   setPhoto(null);

  //   setShowModal(false);
  // }

  return (
    <View style={styles.container}>
      <Camera style={styles.camera} type={tipoCamera} ref={cameraRef}>
        <View style={styles.viewFlip}>
          <TouchableOpacity
            onPress={() =>
              setTipoCamera(
                tipoCamera === CameraType.front
                  ? CameraType.back
                  : CameraType.front
              )
            }
            style={styles.btnFlip}
          >
            <Text style={styles.txtFlip}>Trocar</Text>
          </TouchableOpacity>
        </View>
      </Camera>

      <TouchableOpacity
        onPress={() => capturePhoto()}
        style={styles.btnCapture}
      >
        <FontAwesome name="camera" size={23} color="white" />
      </TouchableOpacity>

      <Modal animationType="slide" transparent={false} visible={showModal}>
        <View
          style={{
            flex: 1,
            justifyContent: "center",
            alignItems: "center",
            margin: 20,
          }}
        >
          <View style={{ margin: 10, flexDirection: "row", gap: 20 }}>
            {/* botões de controle */}
            <TouchableOpacity
              onPress={() => ClearPhoto()}
              style={styles.btnClear}
            >
              <FontAwesome name="trash" size={35} color="#FF0000" />
            </TouchableOpacity>

            <TouchableOpacity
              onPress={() => UploadPhoto()}
              style={styles.btnUpload}
            >
              <FontAwesome name="upload" size={35} color="#121212" />
            </TouchableOpacity>
          </View>

          <Image
            style={{ width: "100%", height: 500, borderRadius: 15 }}
            source={{ uri: photo }}
          />
        </View>
      </Modal>

      <StatusBar style="auto" />
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: "#fff",
    alignItems: "center",
    justifyContent: "center",
  },
  camera: {
    flex: 1,
    height: "80%",
    width: "100%",
  },
  viewFlip: {
    flex: 1,
    backgroundColor: "transparent",
    flexDirection: "row",
    alignItems: "flex-end",
    justifyContent: "center",
  },
  btnFlip: {
    padding: 20,
  },
  txtFlip: {
    fontSize: 20,
    color: "#fff",
    marginBottom: 20,
  },
  btnCapture: {
    padding: 20,
    margin: 20,
    borderRadius: 10,
    backgroundColor: "#121212",
    justifyContent: "center",
    alignItems: "center",
  },
  btnClear: {
    padding: 20,
    backgroundColor: "transparent",
    justifyContent: "center",
    alignItems: "center",
  },
  btnUpload: {
    padding: 20,
    backgroundColor: "transparent",
    justifyContent: "center",
    alignItems: "center",
  },
});
