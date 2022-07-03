using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        if (idadeJoao >= 18 || quantidadePessoas > 1)
        {
            Console.WriteLine("João pode entrar!");
        }
        else
        {
            Console.WriteLine("João não pode entrar");    
        }

        int idadePedro = 18;
        bool acompanhado = quantidadePessoas > 1;
        bool grupo = true;

        if (idadePedro >= 18 || acompanhado)
        {
            Console.WriteLine("Pedro pode entrar!");
        }
        else
        {
            Console.WriteLine("Pedro não pode entrar");
        }


        Console.WriteLine("Aperte ENTER para fechar o programa");
        Console.Read();
    }
}
// Ou = ||
// E =  &&