import { StatusBar } from 'expo-status-bar';
import { Image, StyleSheet, Text, TextInput, TouchableOpacity, View } from 'react-native';
// import { TextInput } from 'react-native-web';

export default function App() {
  return (
    <View style={styles.container}>
      <Image style={styles.image} source={require("./src/assets/img/Ellipse 2 (1).png")} />
      <Text style={styles.text}>Login</Text>
      <TextInput style={styles.input} defaultValue='email...' />
      <TextInput style={styles.input} defaultValue='senha...' />
      <TouchableOpacity style={styles.button}>
        <Text style={styles.textLogin}>
          Login
        </Text>
      </TouchableOpacity>
      <StatusBar style="auto" />
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
    gap: 85
    ,
    backgroundColor: "black"
  },
  image: {
    borderRadius: 1000,
  },
  text: {
    textTransform: "uppercase",
    color: "white",
    fontSize: 25
  },
  input: {
    borderBottomColor: "white",
    borderWidth: 1,
    width: "90%",
    color: "white"
  },
  button: {
    color: "white",
    borderColor: "white",
    width: 100,
    height: 50,
    borderWidth: 1,
    borderRadius: 8,
    justifyContent: "center",
    alignItems: "center",
    left: 125
  },
  textLogin: {
    color: "white",
    textTransform: "uppercase"
  }
});
