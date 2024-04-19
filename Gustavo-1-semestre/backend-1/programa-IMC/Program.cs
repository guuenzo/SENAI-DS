//Programa IMC

//Faca um programa que calcule o imc de uma pessoa recebendo os dados
//no console, ao final imprima o resultado no console

Console.WriteLine($"Informe o nome do paciente: ");
string nome = Console.ReadLine();

Console.WriteLine($"Informe o peso atual do paciente: ");
float peso = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe a altura do paciente: ");
float altura = float.Parse(Console.ReadLine());

float imc = peso / ((float)Math.Pow(altura,2));



