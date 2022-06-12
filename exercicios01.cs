// Elabore um programa que escreve seu nome completo, seu endereço, o CEP e telefone em linhas separadas.
using System;

namespace exercicio1
{
class exercicio1
  {
  static void Main(string[] args)
   {
          string nome;

        Console.WriteLine("qual é o seu nome?");

          string endereco;

        Console.WriteLine("qual é o seu endereço?");
        endereco = Console.ReadLine();

         string CEP;

        Console.WriteLine("qual é o seu CEP?");
        CEP = Console.ReadLine();

         string telefone;

        Console.WriteLine("qual é o seu telefone?");
         telefone = Console.ReadLine();

            Console.WriteLine("-------------------");
            Console.WriteLine("meu nome é esse: " + nome);
            Console.WriteLine("meu endereço é esse: " + endereco);
            Console.WriteLine("meu CEP é: " + CEP);
            Console.WriteLine("meu telefone é " + telefone);


        }

    }
}

// Escolha uma mulher famosa na história da tecnologia e implemente um programa que escreve seu nome, sua formação e uma contribuição feita por ela dentro da tecnologia em linhas separadas.

using System;

namespace exercicio2
{
    class exercicio2
    {
        static void Main(string[] args)
        {
           string nome = "Ada Lovelace";
           string formacao = "matemática e escritora";
            string contribuicao = "Hoje é reconhecida principalmente por ter escrito o primeiro algoritmo para ser processado por uma máquina, a máquina analítica de Charles Babbage";

            Console.WriteLine("O nome da mulher que escolhi é " + nome);
            Console.WriteLine("A formação de " + nome + " é: " + formacao);
            Console.WriteLine("A contribuição de " + nome + " é: " + contribuicao);

        }

    }
}



// Elabore um programa que mostre na tela uma letra de música que você gosta, o compositor e o gênero musical em linhas separadas.

using system;

namespace exercicio3
{
    class exercicio3
    {
        static void main(string[] args)
        {
            string nomedamusica = "imagine";
            string compositor = "john lennon";
            string genero = "pop";
            string letra = "imagine there's no heaven it's easy if you try no hell below us above us only sky imagine all the people living for today imagine there's no countries it isn't hard to do nothing to kill or die for and no religion too imagine all the people living life in peace you may say i'm a dreamer but i'm not the only one i hope some day you'll join us and the world will be as one imagine no possessions i wonder if you can no need for greed or hunger a brotherhood of man imagine all the people sharing all the world you may say, i'm a dreamer but i'm not the only one i hope some day you'll join us and the world will live as one";


            console.writeline("o nome da música é " + nomedamusica);
            console.writeline(nomedamusica + " foi escrita por " + compositor);
            console.writeline(nomedamusica + " é do gênero " + genero);
            console.writeline("a letra de " + nomedamusica + " é: " + letra);
        }

    }
}


// Elabore um programa que exibe uma mensagem que incentive outras mulheres a entrar na tecnologia.

using System;

namespace exercicio4
{
    class exercicio4
    {
        static void Main(string[] args)
        {
            string motivacional = "vamos galera, mulheres! Tem muita vaga na TI para gente preencher";
           
            Console.WriteLine(motivacional);
           
    }
}
}
