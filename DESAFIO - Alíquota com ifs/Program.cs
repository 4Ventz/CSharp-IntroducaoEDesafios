/*O João gostaria de criar um programa sobre Imposto de Renda (IR) e verificou as regras de alíquota. Ele descobriu no site da receita o seguinte:

De 1900.0 até 2800.0, o IR é de 7.5% e pode deduzir na declaração o valor de R$ 142;
De 2800.01 até 3751.0, o IR é de 15% e pode deduzir R$ 350;
De 3751.01 até 4664.00, o IR é de 22.5% e pode deduzir R$ 636.*/

using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Desafio 1: Alíquota com ifs");

        double salario = 3300.0;

        if (salario > 1900.0 && salario < 2800.0)
        {
            Console.WriteLine("IR é de 7.5%, pode deduzir R$ 142,00");
        }
        if (salario > 2800.01 && salario < 3751.0)
        {
            Console.WriteLine("IR é de 15%, pode deduzir R$ 350,00");
        }
        else
        {
            Console.WriteLine("IR é de 22.5%, pode deduzir R$ 636");
        }

        Console.WriteLine("Tecle ENTER para fechar o programa");
        Console.ReadLine();
    }
}