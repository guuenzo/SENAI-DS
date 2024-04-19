import { StatusBar } from 'expo-status-bar';
import { useEffect, useState } from 'react';
import { Alert, StyleSheet, Text, TouchableOpacity, View } from 'react-native';
import { Container } from './src/components/Container/Container';
import { Title, TitleBtnPlusLess } from './src/components/Title/Title';
import { BtnIncrement, BtnDecrement } from './src/components/Button/Button';

export default function App() {

  //hook de state
  const [count, setCount] = useState(0)

  //funcao para incrementar
  const increment = () => {
    setCount(count + 1)
  }

  //funcao para decrementar
  const decrement = () => {
    if (count <= 0) {
      setCount(0)
      Alert.alert("NÃO TRABALHAMOS COM NÚMEROS NEGATIVOS")
    } else {
      setCount(count - 1)
    }

  }

  useEffect(() => {
    console.warn(`Contador atualizado: ${count}`)
  }, [count])

  return (
    <Container >
      <Title >Contador: <Text style={styles.count}>{count}</Text></Title>
      <BtnIncrement>
        <TitleBtnPlusLess onPress={increment}>Incrementar</TitleBtnPlusLess>
      </BtnIncrement>
      <BtnDecrement>
        <TitleBtnPlusLess onPress={decrement}>Decrementar</TitleBtnPlusLess>
      </BtnDecrement>
      <StatusBar style="auto" />
    </Container>
  );
}

const styles = StyleSheet.create({
  count: {
    color: 'green'
  }
});