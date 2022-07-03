using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 2 - Criando variáveis");
        
        int idade;

        idade = 27;
        Console.WriteLine("Minha idade é " + idade);

        idade = 27 - 5;
        Console.WriteLine(idade);

        idade = 5 * 2 - 6;
        Console.WriteLine(idade);

        idade = (5 - 2) * 3;
        Console.Write(idade); //Apenas o comando Write não realiza a quebra de linha, mas imprime o texto desejado

        Console.WriteLine("Tecle ENTER para finalizar");
        Console.ReadLine();
    }
}