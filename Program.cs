// Exercício 1

// Escreva um programa que peça ao usuário para digitar um número inteiro e informe se o
// número é par ou ímpar. Utilize uma estrutura condicional if/else para realizar o teste.
int numero = 0;
int impar = numero-=1;

Console.WriteLine($"Digite um numero:");
numero = int.Parse(Console.ReadLine()!);

Console.WriteLine($"---------------------");
Console.WriteLine($"O Numero {numero} é:");

if (numero != impar)
{
Console.WriteLine($"O numero é Par!");
}
else
{
Console.WriteLine($"O numero é Impar!");
}

// Exercício 2

// Crie um programa que permita que o usuário cadastre 5 nomes em um vetor. Após o
// cadastro, o programa deve imprimir na tela os nomes cadastrados em ordem alfabética.
// Utilize um laço for para o cadastro e um método de ordenação de sua preferência (por
// exemplo, bubble sort) para ordenar os nomes.
