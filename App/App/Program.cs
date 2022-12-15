using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            void Questao01(){
                while (true){
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("Digite um valor: ");
                    int valor = int.Parse(Console.ReadLine());

                    Console.WriteLine("1 - Adição");
                    Console.WriteLine("2 - Multiplicação");
                    Console.WriteLine("3 - Subtração");
                    Console.WriteLine("4 - Divisão");
                    Console.WriteLine("5 - Sair");
                    Console.WriteLine("----------------------------");

                    int resposta = int.Parse(Console.ReadLine());

                    if (resposta == 1){
                        for (int i = 1; i<=10; i++){
                            Console.WriteLine(valor + " + " + i + " = " + (valor + i));
                        }
                    }
                    else if (resposta == 2){
                       for (int i = 1; i <=10; i++){
                            Console.WriteLine(valor + " * " + i + " = " + (valor * i));
                        }
                    }
                    else if (resposta == 3)
                    {
                        for (int i = 1; i<=10; i++){
                            Console.WriteLine(valor + " - " + i + " = " + (valor - i));
                        }
                    }
                    else if (resposta == 4)
                    {
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine(valor + " / " + i + " = " + (valor / i));
                        }
                    }
                    else if (resposta == 5)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido");
                    }
                }
            }

            void Questao02()
            {
                int[,] numbers = new int[3, 3];
                
                //Preenchendo a matriz
                for (int i = 0; i <3; i++)
                {
                    for (int j=0; j<3; j++)
                    {
                        Console.WriteLine("Digite o valor da posição " + i + " "+ j+": ");
                        numbers[i,j] = int.Parse(Console.ReadLine());
                    }
                }

                //soma das linhas e análise se é par ou ímpar
                int somaLinha;
                for (int i = 0; i < 3; i++)
                {
                    somaLinha = 0;
                    for (int j = 0; j < 3; j++)
                    {
                        somaLinha += numbers[i,j];
                    }
                    if (somaLinha %2 == 0){
                        Console.WriteLine("A soma vale " + somaLinha + " e é par");
                    }
                    else
                    {
                        Console.WriteLine("A soma vale " + somaLinha + " e é ímpar");
                    }
                }
                //soma das colunas e análise se é par ou ímpar
                int somaColuna;
                for (int i = 0; i < 3; i++)
                {
                    somaColuna = 0;
                    for (int j = 0; j <3; j++)
                    {
                        somaColuna += numbers[j,i];
                    }
                    if (somaColuna % 2 == 0)
                    {
                        Console.WriteLine("A soma vale " + somaColuna + " e é par");
                    }
                    else
                    {
                        Console.WriteLine("A soma vale " + somaColuna + " e é ímpar");
                    }
                }
            }
            Questao02();
        }
    }
}
