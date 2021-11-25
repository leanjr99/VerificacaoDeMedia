using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Digite um valor inteiro");
            int valor;
            valor = int.Parse(Console.ReadLine());

            if (valor > 0)
            {
                Console.WriteLine("Valor Positivo");
            }
            else if (valor <0)
            {
                Console.WriteLine("Valor negativo");
            }
            else
            {
                Console.WriteLine("O valor é zero");
            }
            */

            /*  EXERCICIO 5*/
            string Nome;
            int n1;
            int n2;
            int n3;
            

                Console.WriteLine("Digite o nome do aluno");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite a primeira nota: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segunda nota: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Terceira nota: ");
            n3 = int.Parse(Console.ReadLine());

            int media = (n1 + n2 + n3) / 3;
            if (media <= 5)
            {
                Console.WriteLine("Reprovado, média: " + media);
            }
            else if (media <= 7)
            {
                Console.WriteLine("Na média: " + media);
            }
            else if (media <= 8.9)
            {
                Console.WriteLine("Muito bom " + media);
            }
            else
            {
                Console.WriteLine("Excelente " + media);
                    }
        }
    }
}
