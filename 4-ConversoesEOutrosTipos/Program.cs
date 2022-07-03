using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 4 - Conversões e outros tipos de variáveis");

        double salario = 3000.15;
        Console.WriteLine(salario);

        int salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);
        //Casting = convertemos uma variável do tipo float para inteiro
        //É desconsiderado todos os decimais da variável transformada

        long x = 200000000000;
        Console.WriteLine(x);
        //Variáveis do tipo long guardam até 64bits

        short y = 15000;
        Console.WriteLine(y);
        //Armazena até 16bits

        float altura = 1.62f;
        Console.WriteLine(altura);
        //o "f" é utilizado para sinalizar ao computador que realmente queremos utilizar o float. Sem ele aparecerá um erro!

        Console.WriteLine("Tecle ENTER para fechar");
        Console.ReadLine();
    }
}
//Váriaveis do tipo int trabalha com até 32bit, podendo não suportar números muito grandes. Suporta de -2^32 até 2^32
//Em C# é utilizado mais o double do que o float. Esse último apresenta uma precisão muito maior quando necessitamos de números decimais
//É questão de boa prática declarar a váriavel juntamente com o seu valor, em uma mesma linha. Ex: float altura = 1.62f;