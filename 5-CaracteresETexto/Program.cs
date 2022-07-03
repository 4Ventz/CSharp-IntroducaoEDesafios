using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 5 - Caracteres e Textos");

        char letra = 'a';
        Console.WriteLine(letra);
        //Armazena 1 caracter apenas dentro de determinada variável
        //IMPORTANTE: Sempre declarar esse tipo de variável utilizando aspas simples

        letra = (char)65;
        Console.WriteLine(letra);
        //Seguindo a tabela ascii, podemos converter números em caracteres!

        letra = (char)(65 + 1);
        Console.WriteLine(letra);
        //Nesse caso devemos colocar a operação entre (), do contrario gerará um erro

        string primeiraFrase = "Alura - Cursos de tecnologia ";
        Console.WriteLine(primeiraFrase + 2022);

        string vazia = "";
        Console.WriteLine(vazia);

        string cursos = @"Cursos disponíveis: 
-Go 
-C# 
-Python 
-Java";
        Console.WriteLine(cursos);
        //@ permite listar os itens de uma string, porém se tentarmos arrumar a identação, os espaços inseridos apareceram no cmd.

        Console.WriteLine("Aperte ENTER para fechar o programa");
        Console.ReadLine();
    }
}

//Variáveis do tipo char são interpretadas internamente, pelo nosso computador, como um número, e não apenas como um caractere
//Variáveis char armazenam até 16bits
//Podemos armazenar strings vazias, porém o mesmo não pode ser feito com char! Ele deve conter, pelo menos, um espaço. Ex: char exemplo = ' ';