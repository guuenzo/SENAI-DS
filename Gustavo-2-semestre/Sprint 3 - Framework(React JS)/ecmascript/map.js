//metodos da classe array:
//filter - retorna um novo array apenas com elementos que atenderam a uma condicao
//foreach - void/nao retorna
//map - novo array modificado
//reduce

const numeros = [1, 2, 5, 10, 300];

//map
const dobro = numeros.map((n) => {
    return n * 2;
});

//filter
const maiorQue10 = numeros.filter((n) => {
    return n >= 10;
});

const comentarios = [
    { comentario: "bla bla bla", exibe: true },
    { comentario: "Evento foi uma merda!", exibe: false },
    { comentario: "Ótimo evento!", exibe: true }
];

const comentariosExibidos = comentarios.filter(c => c.exibe == true);

comentariosExibidos.forEach((c) => {
    // console.log(c.comentario);
})

//reduce
const soma = numeros.reduce((vlInical, n) => {
    return vlInical + n;
}, 0)//0 - valor inicial da funcao de callback

console.log(soma);