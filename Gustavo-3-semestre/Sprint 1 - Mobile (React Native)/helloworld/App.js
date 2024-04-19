import { StatusBar } from 'expo-status-bar';
import { StyleSheet, Text, View, TextInput, Image, TouchableOpacity } from 'react-native';

export default function App() {
  return (
    <View style={styles.container}>

      <Image style={styles.image} source={require("./src/assets/img/download.png")} />

      <Text style={styles.text}>Hello World!</Text>

      <TextInput style={styles.input} defaultValue='Exemplo de input' />

      <TouchableOpacity style={styles.btn}>
        <Text style={styles.textButton}>exemplo de botão
        </Text>
      </TouchableOpacity>

      <StatusBar style='auto' />
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
    gap: 10
  },
  text: {
    fontSize: 24,
  },
  input: {
    width: `90%`,
    height: 40,
    borderWidth: 1,
    padding: 10,
    marginTop: 10
  },
  image: {
    width: 100,
  },
  btn: {
    width: '90%',
    height: 40,
    borderColor: 'black',
    borderWidth: 1,
    justifyContent: 'center',
    alignItems: 'center',
    backgroundColor: 'black'
  },
  textButton: {
    color: 'white',
    textTransform: 'capitalize',
    fontWeight: '500',
    fontSize: 18
  }
});