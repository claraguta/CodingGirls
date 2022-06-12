using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio_1();
            Exercicio_2();
            Exercicio_3();
            Exercicio_4();
            Exercicio_5();

        }

        static void Exercicio_1()
        {
            /*  Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monet�rio. 
             *  A seguir, calcule o menor n�mero de notas e moedas poss�veis no qual o valor pode ser decomposto. 
             *  As notas consideradas s�o de 100, 50, 20, 10, 5, 2.
             *  Entrada: 576.73
             *  Exemplo de Sa�da: NOTAS: 5 nota(s) de R$ 100.00 1 nota(s) de R$ 50.00 1 nota(s) de R$ 20.00 0 nota(s)
             *  de R$ 10.00 1 nota(s) de R$ 5.00 0 nota(s) de R$ 2.008
             *  */

            Console.Write(" Insira o valor a ser decomposto:");

            float bankNote = float.Parse(Console.ReadLine());
            float leftovers;
            float hundred;
            float fifty;
            float twenty;
            float ten;
            float five;
            float two;

            if (bankNote >= 100.00)
            {
                hundred = bankNote / 100;
                leftovers = bankNote % 100;
                Console.Write($" Ser�o:\n {(int)hundred} nota(s) de 100.00");
                fifty = leftovers / 50;
                leftovers = leftovers % 50;
                Console.Write($" Ser�o {(int)fifty} nota(s) de 50.00");
                twenty = leftovers / 20;
                leftovers = leftovers % 20;
                Console.Write($"Ser�o {(int)twenty} nota(s) de 20.00");
                ten = leftovers / 10;
                leftovers = leftovers % 10;
                Console.Write($"Ser�o {(int)ten} nota(s) de 10.00");
                five = leftovers / 5;
                leftovers = leftovers % 5;
                Console.Write($"Ser�o {(int)five} nota(s) de 5.00");
                two = leftovers / 2;
                Console.Write($"E ser�o {(int)two} nota(s) de 2.00 .");

                Console.ReadLine();

            }

            Console.ReadLine();

        }

        static void Exercicio_2()
        {
            /*
             Fa�a um programa que leia tr�s valores e apresente o maior dos tr�s valores lidos seguido da 
            mensagem �x � o maior�. 
            Exemplo de Entrada 7 14 106
            Exemplo de Sa�da 106 � o maior
            */
           Console.WriteLine("Insira tr�s n�meros ");

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
                Console.WriteLine($" O n�mero {n1} �  maior");
            else if (n2 > n3)
                Console.WriteLine($" O n�mero {n2} � maior");
            else
                Console.WriteLine($" O n�mero {n3} �  maior");

            Console.ReadLine();
        }

        static void Exercicio_3()
        {
            /*
             Leia 3 valores que s�o as tr�s notas de um aluno. A seguir, calcule a m�dia do aluno. 
            Considere que cada nota pode ir de 0 at� 10.0, sempre com uma casa decimal. Imprima se 
            o aluno foi aprovado ou reprovado considerando a m�dia 7.
            Exemplo de Entrada 7 8 3
            Exemplo de Sa�da O aluno tirou 6 e foi reprovado.*/

           Console.WriteLine("Insira as notas do aluno:");

            float grade1 = float.Parse(Console.ReadLine());
            float grade2 = float.Parse(Console.ReadLine());
            float grade3 = float.Parse(Console.ReadLine());

            float mean = (grade1 + grade2 + grade3) / 3;

            if (grade1 > 10 || grade2 > 10 || grade3 > 10 || grade1 < 0 || grade2 < 0 || grade3 < 0)
            {
                Console.WriteLine("Nota inv�lida!");
            }
            else if (mean >= 7)
            {
                Console.WriteLine($"APROVADO com m�dia {mean.ToString("F1")}");
            }
            else
                Console.WriteLine($"REPROVADO por ter m�dia {mean.ToString("F1")}");


            Console.ReadLine();
        }

        static void Exercicio_4()
        {
            /*
             Leia 3 valores que s�o as tr�s notas de um aluno. A seguir, calcule a m�dia do aluno.
             Se a nota for menor que 6.0, deve exibir a nota F.
             Se a nota for de 6.0 at� 7.0, deve exibir a nota D.
             Se a nota for entre 7.0 e 8.0, deve exibir a nota C.
             Se a nota for entre 8.0 e 9.0, deve exibir a nota B.
             Se a nota fot entre 9.0 e 10.0, deve exibir um belo de um A.
             N�o esque�a de adicionar uma mensagem ap�s a nota, pode ser um simples parab�ns para aprova��o ou algo mais complexo.
             Exemplo de Entrada 10 8 9
             Exemplo de Sa�da O aluno tirou A. Parab�ns!*/

                        Console.Write("Digite o nome do aluno: ");

            string name = Console.ReadLine();

            Console.WriteLine(" Insira as notas do aluno:  ");

            float grade01 = float.Parse(Console.ReadLine());
            float grade02 = float.Parse(Console.ReadLine());
            float grade03 = float.Parse(Console.ReadLine());

            float mean = (grade01 + grade02 + grade03) / 3;

            if (grade01 > 10 || grade02 > 10 || grade03 > 10 || grade01 < 0 || grade02 < 0 || grade03 < 0)
            {
                Console.WriteLine(" Nota inv�lida!");
            }
            else if (mean < 6)
            {
                Console.WriteLine($" \n {name} sua nota final � F.\n\n Infelizmente voc� foi reprovade. ");
            }
            else if (mean <= 7)
            {
                Console.WriteLine($" \n {name} sua nota final � D.\n\n Sua nota foi suficiente para ser aprovade, mas � necess�rio se dedicar mais. ");
            }
            else if (mean <= 8)
            {
                Console.WriteLine($" \n {name} sua nota final � C.\n\n Voc� foi aprovade. Sua nota foi boa, mas � sempre poss�vel melhorar ainda mais. ");
            }
            else if (mean <= 9)
            {
                Console.WriteLine($" \n {name} voc� foi aprovade. Parab�ns pelo esfor�o. ");
            }
            else if (mean < 10)
            {
                Console.WriteLine($" \n {name} voc� foi aprovade, bem perto do gabarito! Parab�ns");
            }
            else

                Console.WriteLine($" \n {name} voc� foi aprovado com o gabarito, parab�ns" +
                    $".");


            Console.ReadLine();
        }

        static void Exercicio_5()
        {
            /*
             A Blue resolveu dar um aumento de sal�rios a seus funcion�rios de acordo com os dados abaixo:
            Sal�rio de 0 at� 400.00 ganha 15% Sal�rio de 400.01 at� 800.00 ganha 12% Sal�rio de 800.01 at� 
            1200.00 ganha 10% Sal�rio de 1200.01 at� 2000.00 ganha 7% Acima de 2000.00 ganha 4%
            Leia o sal�rio do funcion�rio e calcule e mostre o novo sal�rio, bem como o valor de reajuste 
            ganho e o �ndice reajustado, em percentual.
            Exemplo de Entrada 400.00
            Exemplo de Sa�da Novo salario: 460.00 Reajuste ganho: 60.00 Em percentual: 15 %*/

            
            Console.Write("Informe o nome do funcion�rio: ");
            string name = Console.ReadLine();

            Console.Write($"Informe o sal�rio {name} : ");
            float wage = float.Parse(Console.ReadLine());

            float difference;

            if( wage < 0)
            {
                Console.WriteLine("Sal�rio n�o � pass�vel de reajuste.");
            }
            else if (wage >= 0 && wage <= 400)
            {
                difference = wage * 0.15f;
                wage = wage + difference;               

                Console.WriteLine($" O funcion�rio(a) {name} ter� o novo sal�rio de {wage.ToString("F2")}, com reajuste de {difference.ToString("F2")}. Significando portanto um percentual de 15%");
            }
            else if ( wage >= 400.01 && wage <= 800)
            {
                difference = wage * 0.12f;
                wage = wage + difference;

                Console.WriteLine($" O funcion�rio(a) {name} ter� o novo sal�rio de {wage.ToString("F2")}, com reajuste de {difference.ToString("F2")}. Significando portanto um percentual de 15%");
            }
            else if (wage >= 800.01 && wage <= 1200.00)
            {
                difference = wage * 0.10f;
                wage = wage + difference;

                Console.WriteLine($" O funcion�rio(a) {name} ter� o novo sal�rio de {wage.ToString("F2")}, com reajuste de {difference.ToString("F2")}. Significando portanto um percentual de 15%");
            }
            else if (wage >= 12000.01 && wage <= 2000)
            {
                difference = wage * 0.7f;
                wage = wage + difference;

                Console.WriteLine($" O funcion�rio(a) {name} ter� o novo sal�rio de {wage.ToString("F2")}, com reajuste de {difference.ToString("F2")}. Significando portanto um percentual de 15%");
            }
            else
            {
                difference = wage * 0.4f;
                wage = wage + difference;

                Console.WriteLine($" O funcion�rio(a) {name} ter� o novo sal�rio de {wage.ToString("F2")}, com reajuste de {difference.ToString("F2")}. Significando portanto um percentual de 15%");
            }
            Console.ReadLine();
                
            

        }


    }
}