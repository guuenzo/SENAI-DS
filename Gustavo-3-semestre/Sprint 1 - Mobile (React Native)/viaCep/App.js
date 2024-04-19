import { StatusBar } from 'expo-status-bar';
import { useFonts, Roboto_500Medium, Roboto_700Bold } from '@expo-google-fonts/roboto';
import { ContainerApp } from './style';
import { Header } from './src/components/Header/Index'
import { Home } from './src/components/screens/Home/Index'


export default function App() {

  let [fontsLoaded, fontError] = useFonts({
    Roboto_500Medium,
    Roboto_700Bold
  });

  if (!fontsLoaded && !fontError) {
    return null;
  }
  return (
    <ContainerApp >
      <StatusBar />
      <Header />
      <Home />
    </ContainerApp>
  );
}
