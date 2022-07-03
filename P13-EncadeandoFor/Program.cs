using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 13 - Encadeando For");

        // Com break
        for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        {
            for (int contadorColunas = 0; contadorLinhas < 10; contadorColunas++)
            {
                Console.Write("*");
                if (contadorColunas >= contadorLinhas)
                    break;
            }
            
            Console.WriteLine();
        }

        //Sem break
        for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        {
            for (int contadorColunas = 0; contadorColunas <= contadorLinhas; contadorColunas++)
            {
                Console.Write("*");
                if (contadorColunas >= contadorLinhas)
                    break;
            }

            Console.WriteLine();
        }


        Console.WriteLine("Tecle ENTER para fechar ...");
        Console.ReadLine();
    }
}
//break = Palabra reservada que para o programa quando uma condição for respeitada