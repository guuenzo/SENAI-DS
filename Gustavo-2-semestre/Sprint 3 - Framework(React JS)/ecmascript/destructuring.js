const camisaLacoste = {
    descricao: "Camisa Lacoste",
    preco: 399.98,
    marca: "Lacoste",
    tamanho: "G",
    cor: "Azul",
    promo: true
}

const {descricao, preco, promo} = camisaLacoste;

// console.log(`
//     Produto: ${descricao}
//     Preço: ${preco}
//     Promoção ${camisaLacoste.promo ? "sim" : "não"}
// `);

/*Crie um objeto evento com as propriedades
    * dataEvento
    * descricaoEvento
    * titulo
    * presenca
    * comentario
     
  Crie uma destructuring das propriedades do objeto evento e as exiba no console.

  OBS: para a presenca deve-se exibir "sim" ou "nao"
 */

  const evento = {
    dataEvento: "26/07/2024",
    descricaoEvento: "Aniversário em comemoração aos 18 do Enzão",
    titulo: "Aniversário do delício",
    presenca: true,
    comentario: "Niver top, lindo"
  }

  const {dataEvento, descricaoEvento, titulo, presenca, comentario} = evento

  console.log(`
    Data do evento: ${dataEvento}
    Descrição: ${descricao}
    Nome do evento: ${titulo}
    Presença: ${presenca ? "confirmada" : "não vai"} //primeira opcao corresponde ao valor definido na propriedade
    Comentário: ${comentario}
  `);