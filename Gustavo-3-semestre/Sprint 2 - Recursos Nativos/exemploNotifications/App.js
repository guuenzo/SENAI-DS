import { StatusBar } from "expo-status-bar";
import { Button, StyleSheet, Text, TouchableOpacity, View } from "react-native";

//importar recursos do expo notifications
import * as Notifications from "expo-notifications";
import { Asset } from "expo-asset";

//solicita permissoes de notificacao ao iniciar o app
Notifications.requestPermissionsAsync();

//define como as notificacoes devem ser tratadas quando recebidas
Notifications.setNotificationHandler({
  handleNotification: async () => ({
    //mostrar o alerta quando a notificacao for recebida
    shouldShowAlert: true,

    //produz som ao receber notificacao
    shouldPlaySound: true,

    //numero de notificacoes no icone do app
    shouldSetBadge: false,
  }),
});

export default function App() {
  const handleCallNotifications = async () => {
    //obtem o status da permissao
    const { status } = await Notifications.getPermissionsAsync();

    //verifica se o usuario concedeu a permissao
    if (status !== "granted") {
      alert("você não deixou as notificações ativas");
      return;
    }
    //agenda um notificacao
    await Notifications.scheduleNotificationAsync({
      content: {
        title: "Bem vindo ao SENAI",
        body: "Notificação recebida.",
        sound: "",
        vibrate: true,
      },
      trigger: null,
    });
  };

  return (
    <View style={styles.container}>
      <TouchableOpacity style={styles.button} onPress={handleCallNotifications}>
        <Text style={styles.text}>Clique aqui !</Text>
      </TouchableOpacity>
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
  button: {
    width: "80%",
    height: 50,
    backgroundColor: "pink",
    justifyContent: "center",
    alignItems: "center",
    borderRadius: 10,
  },
  text: {
    color: "#FFF",
    fontWeight: "bold",
    fontSize: 24,
  },
});
