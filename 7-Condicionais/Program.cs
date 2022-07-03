using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        if (idadeJoao >= 18)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            if (quantidadePessoas > 1)
            {
                Console.WriteLine("Ele está acompanhado. Pode entrar!");
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }
        }

        Console.WriteLine("Aperte ENTER para fechar o programa");
        Console.Read();
    }
}
//Para organizar um código mal encadeado podemos ir em Editar > avançado > formatar documento