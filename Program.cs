//// 1. Maior de Dois Números
//// Peça dois números inteiros ao usuário e exiba o maior entre eles.

//Capta o primeiro número
Console.WriteLine("Digite o primeiro número:");
int numero1 = Convert.ToInt32(Console.ReadLine());

// Capta o segundo número
Console.WriteLine("Digite o segundo número:");
int numero2 = Convert.ToInt32(Console.ReadLine());

if (numero1 > numero2)
{
    Console.WriteLine("O maior número é: " + numero1);
}
else if (numero2 > numero1)
{
    Console.WriteLine("O maior número é: " + numero2);
}
else
{
    Console.WriteLine("Os números são iguais.");
}

//2.Classificação de Idade

//Peça a idade do usuário e classifique-o como:
//-"Criança"(0 a 12 anos)
//- "Adolescente"(13 a 17 anos)
//- "Adulto"(18 anos ou mais)
//- "Idoso"(60 anos ou mais)

// Capta a idade do usuário
Console.WriteLine("Digite sua idade:");

// Converte o valor do número decimal especificado em um inteiro com sinal de 32 bits equivalente.
int idade = Convert.ToInt32(Console.ReadLine());

if (idade >= 1 && idade <= 12)
{
    Console.WriteLine("Criança");
}
else if (idade >= 13 && idade <= 17)
{
    Console.WriteLine("Adolescente");
}
else if (idade >= 18)
{
    Console.WriteLine("Adulto");
}
else if (idade >= 60)
{
    Console.WriteLine("Idoso");
}
else
{
    Console.WriteLine("Idade inválida!");
}

// If Else simplificado
idade = 29;

string msg = (idade > 18) ? "Maior de idade!" : "Menor de idade";

//3.Par ou Ímpar**
// Crie um programa que receba um número inteiro do usuário e exiba se ele é par ou ímpar.

// Capta o número
Console.WriteLine("Digite o número:");
int inteiro = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(inteiro / 2);

if (inteiro % 2 == 0)
{
    Console.WriteLine("Numero par");
}
else
{
    Console.WriteLine("Ímpar");
}

// OU
string tipo = (inteiro % 2 == 0) ? "Par" : "Impar";

// 4. Maior de Três Números
// Receba três números e determine o maior entre eles.

//Capta os números
Console.WriteLine("Digite o primeiro número:");
int opcao1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
int opcao2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o terceiro número:");
int opcao3 = Convert.ToInt32(Console.ReadLine());

int maior;

// Verifica qual é o maior número
if (opcao1 >= opcao2 && opcao1 >= opcao3)
{
    maior = opcao1;
}
else if (opcao2 >= opcao1 && opcao2 >= opcao3)
{
    maior = opcao2;
}
else
{
    maior = opcao3;
}

// Exibe o resultado
Console.WriteLine($"O maior número é: {maior}");

// 5. Cálculo do Delta (Fórmula de Bhaskara)
//Receba os coeficientes de uma equação quadrática (ax² + bx + c = 0) e calcule o delta.

Console.WriteLine("Digite o coeficiente 'a' (diferente de zero):");
double a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o coeficiente 'b':");
double b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o coeficiente 'c':");
double c = Convert.ToInt32(Console.ReadLine());

// Verifica se 'a' é diferente de zero
if (a == 0)
{
    Console.WriteLine("O coeficiente 'a' não pode ser zero em uma equação quadrática.");
    return;
}

// Calcula o delta
// O delta é calculado usando a fórmula Δ = b2 − 4ac
// Math.Pow é uma função matemática que calcula o valor de um número elevado a uma potência
double delta = Math.Pow(b, 2) - 4 * a * c;

// Exibe o resultado
Console.WriteLine($"O valor de delta (Δ) é: {delta}");