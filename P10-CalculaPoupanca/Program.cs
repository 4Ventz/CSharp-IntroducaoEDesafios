// Rendimento de 0.5% ao mês
// Informar qual é nosso rendimento depois de um determinado tempo

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 10 - Calcula Poupança");

        double investimento = 1000;

       //investimento = investimento + investimento * 0.005;
       // Console.WriteLine(investimento);

        int mes = 1;

        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você tem R$ " + investimento);

            //mes = mes + 1; mes ++ 1; mes ++; Todos significam a mesma coisa
            mes += 1;
        }


        Console.WriteLine("Tecle ENTER para fechar o programa");
        Console.ReadLine();
    }
}