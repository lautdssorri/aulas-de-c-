using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite alguma coisa no teclado");

        //Capturando a entrada do usuário
        string entrada = Console.ReadLine();

        //Exibindo o que o usuario digitou
        Console.WriteLine("Você digitou: " + entrada);

        //Exemplo 2 --------

        Console.WriteLine("*********EX2*********");
        //Capturando o primeiro valor
        Console.WriteLine("Digite o primeiro valor: ");
        string valor1 = Console.ReadLine();
        int numero1 = int.Parse(valor1);

        //Capturando o segundo valor
        Console.WriteLine("Digite o segundo valor: ");
        string valor2 = Console.ReadLine();
        int numero2 = int.Parse(valor2);

        //Calculando a soma
        int soma = numero1 + numero2;

        //Exibindo o resultado
        Console.WriteLine("A soma dos valores é: " + soma);


        //Exemplo 3 --------
        Console.WriteLine("----------EX3-----------");
        Console.WriteLine("Digite o primeiro valor: ");
        string nota1 = Console.ReadLine();
        int n1 = int.Parse(nota1);

        Console.WriteLine("Digite o segundo valor: ");
        string nota2 = Console.ReadLine();
        int n2 = int.Parse(nota2);

        Console.WriteLine("Digite o terceiro valor: ");
        string nota3 = Console.ReadLine();
        int n3 = int.Parse(nota3);

        int media = (n1 + n2 + n3) / 3;

        Console.WriteLine("A media dos valores é: " + media);

    }
}