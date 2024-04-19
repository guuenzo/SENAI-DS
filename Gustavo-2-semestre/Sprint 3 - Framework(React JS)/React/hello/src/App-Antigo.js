import './App.css';
import Titulo from './components/Titulo/Titulo'
import CardEvento from './components/CardEvento/CardEvento'

function App() {

  //criar o componente CardEvento
  //criar o css do componente
  //exibir o componente no App.js
  //alterar o componente para receber as props: titulo, texto, textoLink
  //exibir 3 componentes do CardEvento

  return (
    <div className="App">
      <h1>Hello react</h1>
      <Titulo texto="Eduardo" />
      <Titulo texto="Marcos" />
      <Titulo texto="Maria" />
      <Titulo texto="John" />

      <CardEvento
        titulo="niver do Enzo"
        texto="parabenizar o lindão"
        textoLink="Chega mais!"
      />
      <CardEvento
        titulo="niver do Lucas"
        texto="parabenizar o lindão"
        textoLink="Chega mais!"
      />
      <CardEvento
        titulo="niver do Thiago"
        texto="parabenizar o lindão"
        textoLink="Chega mais!"
      />
    </div>
  );
}

export default App;