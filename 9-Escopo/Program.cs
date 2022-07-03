using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;

        string textoAdicional;

        if (acompanhado == true)
        {
            textoAdicional = "João está acompanhado";
        }
        else
        {
            textoAdicional = "João não está acompanhado";
        }

        if (idadeJoao >= 18 || quantidadePessoas > 1)
        {
            Console.WriteLine("Pode entrar!");
            Console.WriteLine(textoAdicional);
        }
        else
        {
            Console.WriteLine("Não pode entrar");
        }

    }
}
// Variaveis declaradas dentro de chaves só existiram para aquela parte do código!
// Quando temos uma única linha de comando no else não precisamos usar {}