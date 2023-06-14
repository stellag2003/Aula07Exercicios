using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07Exercícios
{
    class Program
    {
        static void Main(string[] args)

            void Atividade03()
        {
            //Atividade03

            float nota1;
            float nota2;
            float nota3;
          

            Console.WriteLine("Digite sua 1 nota:");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine($"Sua nota 1 é: {nota1}");

            Console.WriteLine("Digite sua 2 nota:");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"Sua nota 2 é: {nota2}");

            Console.WriteLine("Digite sua nota 3:");
            nota3 = float.Parse(Console.ReadLine());
            Console.WriteLine($"Sua nota 3 é: {nota3}");

            if (nota1 > nota2 && nota1 > nota3)
            {
                Console.WriteLine($"Essa é a sua maior nota: {nota1}");
            }

            if (nota2 > nota1 && nota2 > nota3)
            {
                Console.WriteLine($"Essa é a sua maior nota: {nota2}");
            }

            if (nota3 > nota1 && nota3 > nota2)
            {
                Console.WriteLine($"Essa é a sua maior nota: {nota3}");
            }
            
           

       

















            void Atividade02()
                {
                // Atividade02

                string nome;
                double media;

                Console.WriteLine("Digite o seu nome:");
                nome = Console.ReadLine();

                Console.WriteLine($"Seu nome é: {nome}");

                Console.WriteLine("Digite a sua média:");
                media = double.Parse(Console.ReadLine());

                if (media >= 6)
                {
                    Console.WriteLine($"O aluno:{nome}, foi aprovado!");
                }

                Console.WriteLine($"O aluno:{nome}, foi reprovado.");



                Console.ReadKey();
            }






            void Atividade01()
            {
                // Atividade01
                int numero;


                Console.WriteLine("Digite um número:");
                numero = int.Parse(Console.ReadLine());

                if (numero > 100)
                {
                    Console.WriteLine($"Resultado:{numero + 150}");
                }

                else
                {
                    Console.WriteLine($"O número é:{numero}");

                }



                Console.ReadKey();

            }
        }
    }
}