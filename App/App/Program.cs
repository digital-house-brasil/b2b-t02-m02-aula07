using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Program
    {
        static void Main(string[] args) {
            //void Calculadora() {

            //    Console.WriteLine("Digite um número");
            //    int numero = int.Parse(Console.ReadLine());

            //    int opcao;
            //    do {
            //        Console.WriteLine("Digite a operação \n 1 - Adição \n 2 - Multiplicação \n 3 - Subtração \n 4 - Divisão \n Sair");
            //        opcao = int.Parse(Console.ReadLine());
            //        switch (opcao) {
            //            case 1:
            //            for (int i = 1; i <= 10; i++)
            //                Console.WriteLine(i + " + " + numero + " = " + (i + numero));
            //            break;
            //            case 2:
            //            for (int i = 1; i <= 10; i++)
            //                Console.WriteLine(i + " * " + numero + " = " + (i * numero));
            //            break;
            //            case 3:
            //            for (int i = 1; i <= 10; i++)
            //                Console.WriteLine(i + " - " + numero + " = " + (i - numero));
            //            break;
            //            case 4:
            //            for (int i = 1; i <= 10; i++)
            //                Console.WriteLine(i + " / " + numero + " = " + (i / numero));
            //            break;
            //            default:
            //            Console.WriteLine("");
            //            break;
            //        }
            //    } while (opcao != 5);
            //}
            //Calculadora();

            void ParOuImpar() {
                int[,] matriz = new int[3, 3];
                matriz[0, 0] = 1;
                matriz[0, 1] = 1;
                matriz[0, 2] = 2;

                matriz[1, 0] = 8;
                matriz[1, 1] = 3;
                matriz[1, 2] = 1;

                matriz[2, 0] = 9;
                matriz[2, 1] = 9;
                matriz[2, 2] = 4;

                int soma = 0;
                string resultado;

                // Linhas
                for (int i = 0; i < 3; i++) {
                    soma = matriz[i, 0] + matriz[i, 1] + matriz[i, 2];
                    resultado = ((soma % 2) == 0) ? "par" : "ímpar";
                    Console.WriteLine("A soma da linha " + (i+1) + " é " + resultado);
                }

                // Colunas
                for (int i = 0; i < 3; i++) {
                    soma = matriz[0, i] + matriz[1, i] + matriz[2, i];
                    resultado = ((soma % 2) == 0) ? "par" : "ímpar";
                    Console.WriteLine("A soma da coluna " + (i+1) + " é " + resultado);
                }
            }
            //ParOuImpar();

            void DiagonalPrincipal() {
                int[,] matriz = new int[3, 3];
                matriz[0, 0] = 1;
                matriz[0, 1] = 1;
                matriz[0, 2] = 2;

                matriz[1, 0] = 8;
                matriz[1, 1] = 3;
                matriz[1, 2] = 1;

                matriz[2, 0] = 9;
                matriz[2, 1] = 9;
                matriz[2, 2] = 4;

                int[] vetor = new int[3];

                vetor[0] = matriz[0, 0];
                vetor[1] = matriz[1, 1];
                vetor[2] = matriz[2, 2];

                foreach(int i in vetor) {
                    Console.WriteLine(i);
                }
            }

            DiagonalPrincipal();

            Console.ReadKey();
        }
    }
}
