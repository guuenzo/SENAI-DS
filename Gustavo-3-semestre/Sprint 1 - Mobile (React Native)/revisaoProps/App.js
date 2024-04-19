import { StatusBar } from 'expo-status-bar';
import { FlatList, SafeAreaView, StyleSheet, Text, View } from 'react-native';
import Person from "./src/Person/Person"

  //import da fonte   
  import { useFonts, SingleDay_400Regular } from '@expo-google-fonts/single-day';

export default function App() {

  let [fontsLoaded, fontError] = useFonts({
    SingleDay_400Regular,
  });

  if (!fontsLoaded && !fontError) {
    return null;
  }

  const peopleList = [
    { id: '1', name: 'Carlos', age: 37 },
    { id: '2', name: 'Edu', age: 47 },
    { id: '3', name: 'Jucelino', age: 25 }
  ]

  return (
    <SafeAreaView>
      <Person name='Carlos' age={37} />
      {/* <Person name='Edu' age={38} />
      <Person name='Jucelino' age={25} /> */}

      <StatusBar style='auto' />

      {/*FlatList */}
      <FlatList
        data={peopleList}
        keyExtractor={(item) => item.id}
        renderItem={({ item }) => (
          <Person name={item.name} age={item.age} />
        )}
      />
    </SafeAreaView>
  );
}

