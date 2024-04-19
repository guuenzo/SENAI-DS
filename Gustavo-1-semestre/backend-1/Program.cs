// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//variaveis

//declarando uma variavel
//tipo nome = valor
// string nome = "Gustavo";
// const int idade = 16;

// Console.WriteLine("A idade do " + nome + " e " + idade + " anos ");

//tipos de dados 
// int quantidade = 10;
// double preco = 4.99d;
// float altura = 1.80f;
// bool careca = true;
// string texto = "Ola, mundo";
// char letra = 'C';

// //operador de atribuicao

// int idade = 36;

// //operadores aritimeticos 

// //soma
// Console.WriteLine(4 + 4);


// //subtracao
// Console.WriteLine(10 - 8);


// //multiplicacao
// Console.WriteLine(5 * 9);


// //divisao
// Console.WriteLine(10 / 2);

// //modular
// Console.WriteLine(5 % 2);

// //operadores de comparacao -resposta true ou false

// //igual a 
// Console.WriteLine(5 == 5);


// //maior ou igual a 
// Console.WriteLine(5 >= 4);


// //menor ou igual a 
// Console.WriteLine(4 <= 4);


// //maior que 
// Console.WriteLine(5 > 1);


// //menor que 
// Console.WriteLine(5 < 2);


// //diferente de 
// Console.WriteLine(5 != 8);

//operadores logicos e tabela verdade 

//&&: e
//||: ou
// !: negacao
//                                         //tabela verdade
// Console.WriteLine(5 == 5 && 8 == 8);//TRUE && TRUE = TRUE
// Console.WriteLine(5 == 5 && 8 == 9);//TRUE && FALSE = FALSE
// Console.WriteLine(5 == 6 && 8 == 8);//FALSE && TRUE = FALSE
// Console.WriteLine(5 == 6 && 8 == 9);//FALSE && FALSE = FALSE

// Console.WriteLine(2 == 2 || 3 ==3);//TRUE || TRUE = TRUE
// Console.WriteLine(2 == 2 || 3 == 4);//TRUE || FALSE = TRUE
// Console.WriteLine(2 == 3 || 3 == 3);//FALSE || TRUE = TRUE
// Console.WriteLine(1 == 2 || 3 == 5);//FALSE || FALSE = FALSE

// Console.WriteLine(!(2 == 2 || 3 == 8));//TRUE




//crie um programa para calcular o IMC de uma pessoa 

//entradas
string nome = "Carlos";
float peso = 89.9f;
float altura = 1.80f;

//processamento
float imc = peso / (altura * altura);

Console.WriteLine($"O IMC do " + nome + "e de: " + Math.Round(imc,2));













