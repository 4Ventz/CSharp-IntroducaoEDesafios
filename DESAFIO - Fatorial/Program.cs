//Nesse exercício opcional, o seu desafio é imprimir os fatoriais de 1 a 10!

using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Desafio Extra: Fatoriais!");

        int fatorial = 1;

        for (int numero = 1; numero <= 10; numero++)
        {
            fatorial = fatorial * numero;
            Console.WriteLine("O fatorial de " + numero + " é " + fatorial);
        }


       

        Console.WriteLine("Tecle ENTER para fechar ...");
        Console.ReadLine();
    }
}