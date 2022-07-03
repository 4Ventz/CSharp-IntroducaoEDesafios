// Rendimento de 0.5% ao mês
// Informar qual é nosso rendimento depois de um determinado tempo

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 11 - Calcula Poupança");

        /* double investimento = 1000;
        int mes = 1;
        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você tem R$ " + investimento);

            mes += 1;
        }
       */

        double investimento = 1000;

        for (int mes = 1; mes <12; mes++)
        {
            //investimento = investimento + investimento * 0.005;
            //investimento = investimento * 1.005;
            //investimento =* 1.005;
            Console.WriteLine("No mês " + mes + " você tem R$ " + investimento);
        }

        Console.WriteLine("Tecle ENTER para fechar o programa");
        Console.ReadLine();
    }
}

// Estrutura do for (variável_de_inicialização; Condição; contador)