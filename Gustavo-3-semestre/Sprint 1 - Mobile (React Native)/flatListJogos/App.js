import { StatusBar } from 'expo-status-bar';
import { FlatList, SafeAreaView, StyleSheet, Text, View } from 'react-native';
import Jogos from "./src/Jogos/Jogos"

//import da fonte   
import { useFonts, SingleDay_400Regular, Poppins_900Black_Italic } from '@expo-google-fonts/poppins';

export default function App() {

  let [fontsLoaded, fontError] = useFonts({
    SingleDay_400Regular,
    Poppins_900Black_Italic
  });

  if (!fontsLoaded && !fontError) {
    return null;
  }

  const gamesList = [
    { id: '1', name: 'Assasins Creed', description: 'Assassins Creed é uma franquia de jogos de ação furtiva criada pela Ubisoft que conta a eterna guerra entre o clã dos Assassinos, que buscam um mundo onde todos são livres, e os Templários, que querem controle absoluto.', classification: '+18' },
    { id: '2', name: 'GTA V', description: 'Grand Theft Auto V, popularmente conhecido como GTA V, é um jogo eletrônico de ação e aventura lançado em 2013 para o PS3. Desenvolvido pela Rockstar North, o jogo se passa na cidade fictícia de Los Santos, inspirada em Los Angeles, e no condado rural de Blaine County, no sul da Califórnia.', classification: '+18' },
    { id: '3', name: 'Overcooked', description: 'Overcooked é um jogo de culinária cooperativo de sofá para 1 a 4 jogadores. Em equipa, tu e os teus colegas chefes de cozinha têm de preparar, cozinhar e servir deliciosos pedidos antes que os clientes reclamadores saiam irritados.', classification: 'L' },
  ]

  return (
    <SafeAreaView>
      <FlatList
        data={gamesList}
        keyExtractor={(item) => item.id}
        renderItem={({ item }) => (
          <Jogos name={item.name} description={item.description} classification={item.classification} />
        )}
      />
      <StatusBar style="auto" />
    </SafeAreaView>
  );
}
;
