const somar = (x, y) => {
    return x + y;
}

const dobro = (num) => {
    return num * 2;
}

//arrow function recebendo apenas um parametro (omite os parenteses)
const dobro2 = numero => {
    return numero * 2;
}

//arrow function recebendo apenas um parametro (omite os parenteses e as chaves)
const dobro3 = numero => numero * 2

const boaTarde = () => { console.log("Boa tarde!") }

//  boaTarde();

const convidados = [
    { nome: "Carlos", idade: 36 }, 
    { nome: "Claiton", idade: 43 },
    { nome: "Rebeca", idade: 16 },
    { nome: "Magalhães", idade: 18 },
    { nome: "Guilherme Henrique", idade: 18 }
];

convidados.forEach((convidados, i) => {
    console.log(`${i + 1}º Convidado: ${convidados.nome}, idade: ${convidados.idade}`)
})