using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 3 - Variáveis Ponto Flutuantes");
        
        double salario;
        salario = 3000.13;
        Console.WriteLine(salario);

        salario = 3000;
        Console.WriteLine(salario);
        //Variável double aceita números inteiros

        double idade;
        idade = 7 / 5;
        Console.WriteLine(idade);
        //Por aceitar valores inteiros, o comando double entende que os números trabalhados, "7" e "5", são inteiros. Por isso ele devolve um número inteiro, no caso a resposta "1"
        //Nesse caso não é um arredondamento!! É desconsiderado tudo o que vem depois do inteiro!

        idade = 7.0 / 5.0;
        Console.WriteLine(idade);
        //Para não perder a informação decimal devemos adicionar o ".0" quando trabalhamos com número inteiros usando o double

        Console.WriteLine("Tecle ENTER para fechar");
        Console.ReadLine();
    }
} 
