// Faça um programa que pergunte ao usuário ano de nascimento e imprima sua idade.

namespace aula02_07_06
{
    internal class program
    {
       static void main(string[] args)
        {
            console.writeline("programa ano de nascimento");
            console.writeline("digite o seu ano de nascimento: ");
            int anodenascimento = int.parse(console.readline());

            int resultadoano = 0;
            int anoatual = 2022;
            resultadoano = (anoatual - anodenascimento);

            console.writeline("a idade é: " + resultadoano);
            console.readline();
        }
    }
}

// Escreva um programa que leia 10 valores inteiros e ao final exiba a soma dos números.

namespace Aula02_07_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 1;
            int valor2 = 2;
            int valor3 = 3;
            int valor4 = 4;
            int valor5 = 5; 
            int valor6 = 6;
            int valor7 = 7; 
            int valor8 = 8;
            int valor9 = 9;
            int valor10 = 10;

            int soma = (valor1 + valor2 + valor3 + valor4 + valor5 + valor6 + valor7 + valor8 + valor9 + valor10);

            Console.WriteLine("A soma é: " + soma);
            Console.ReadLine();
        }
    }
}


// Escreva um programa que leia o número de horas trabalhadas e um funcionário, o valor que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais.

namespace aula02_07_06
{
    internal class program
    {
        static void main(string[] args)
        {
            console.writeline("quantas horas você trabalha? ");
            int horastrabalhadas = int.parse(console.readline());

            console.writeline("quanto você recebe por hora? ");
            int valorrecebidoporhora = int.parse(console.readline());

            int salariodiario;

            salariodiario = (horastrabalhadas * valorrecebidoporhora);

            int salariomensal;

            salariomensal = (salariodiario * 30);

            console.writeline("seu salário mensal é de r$" + salariomensal);
            console.readline();

        }
    }
}


// Leia um valor inteiro correspondente à idade de uma pessoa e mostre-a em anos, meses e dias.
// Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias. Nos casos de teste nunca haverá uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364. Este é apenas um exercício com objetivo de testar raciocínio matemático simples.


namespace aula02_07_06
{
    internal class program
    {
        static void main(string[] args)
        {

            console.writeline("qual sua idade? ");
            int idade = int.parse(console.readline());

            
            int idadeemanos;
            int idadeemmeses;
            int idadeemdias;

            idadeemanos = idade;
            idadeemmeses = idade * 12;
            idadeemdias = idadeemmeses * 365;

            console.writeline("você tem " + idadeemanos + " anos, ou " + idadeemmeses + " meses ou " + idadeemdias + " dias de vida" );
            console.readline();

        }
    }
}



//5. Construa um conversor de moedas:
/*// *///Crie um programa que solicite um um valor em real ao usuário e converta esse valor, para:
       //dolar
       //euro
       //libra esterlina
       //dólar canadense
       //peso argentino
       //peso chileno



namespace Aula02_07_06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("qual valor você quer converter? ");
            double valorEmReais = double.Parse(Console.ReadLine());


            double valorEmDolar;
            double valorEmEuro;
            double valorEmLibra;
            double valorEmDolarCanadense;
            double valorEmPesoArgentino;
            double valorEmPesoChileno;


            valorEmDolar = valorEmReais * 0.21;
            valorEmEuro = valorEmReais * 0.19;
            valorEmLibra = valorEmReais * 0.16;
            valorEmDolarCanadense = valorEmReais * 0.26;
            valorEmPesoArgentino = valorEmReais * 24.90;
            valorEmPesoChileno = valorEmReais * 169.36;

            Console.WriteLine("O valor em Dólar é R$" + valorEmDolar);
            Console.WriteLine("O valor em Euro é R$" + valorEmEuro);
            Console.WriteLine("O valor em Libras é R$" + valorEmLibra);
            Console.WriteLine("O valor em Dólar Canadense é R$" + valorEmDolarCanadense);
            Console.WriteLine("O valor em Peso Argentino é R$" + valorEmPesoArgentino);
            Console.WriteLine("O valor em Peso Chileno é R$" + valorEmPesoChileno);

            Console.ReadLine();

        }
    }
}
