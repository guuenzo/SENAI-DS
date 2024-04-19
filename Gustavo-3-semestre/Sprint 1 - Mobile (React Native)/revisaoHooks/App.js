import { StatusBar } from 'expo-status-bar';
import { useEffect, useState } from 'react';
import { StyleSheet, Text, TouchableOpacity, View } from 'react-native';

export default function App() {

  //hook de state
  const [count, setCount] = useState(0)

  //funcao para incrementar
  const increment = () => {
    setCount(count + 1)
  }

  //funcao para decrementar
  const decrement = () => {
    setCount(count - 1)
  }

  useEffect(() => {
    console.warn(`Contador atualizado: ${count}`)
  }, [count])

  return (
    <View style={styles.container}>
      <Text style={styles.textCount}>Contador: {count}</Text>

      <TouchableOpacity>
        <Text style={styles.buttonPlus} onPress={increment}>Incrementar</Text>
      </TouchableOpacity>
      <TouchableOpacity>
        <Text style={styles.buttonLess} onPress={decrement}>Decrementar</Text>
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
  },
  textCount: {
    fontSize: 35
  },
  buttonPlus: {
    backgroundColor: 'blue',
    borderRadius: 10,
    borderWidth: 2,
    fontSize: 35
  },
  buttonLess: {
    backgroundColor: 'red',
    borderRadius: 10,
    borderWidth: 2,
    fontSize: 32
  }
});
