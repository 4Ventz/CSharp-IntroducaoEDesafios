//Utilize um laço do tipo for para imprimir todos os múltiplos de 3, entre 1 e 100.

using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Desafio 2: Múltiplos de 3");

        for (int contadorNumeros = 0; contadorNumeros < 100; contadorNumeros++)
        {
            if (contadorNumeros % 3 == 0)
            {
                Console.WriteLine(contadorNumeros);
            }
        }

        Console.WriteLine("Tecle ENTER para fechar ...");
        Console.ReadLine();
    }
}