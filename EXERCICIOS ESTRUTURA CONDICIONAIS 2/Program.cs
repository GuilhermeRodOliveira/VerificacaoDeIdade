using System;


namespace EXERCICIOS_ESTRUTURA_CONDICIONAIS_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2 - Crie um programa que peça ao usuário para digitar sua idade e, em seguida, imprima se ele é menor de idade(abaixo de 18 anos) ou maior de idade.

            Console.WriteLine("Informe sua idade: ");
            int Idade = int.Parse(Console.ReadLine());

            if (Idade >= 18)
            {
                Console.WriteLine($"Você tem {Idade} anos e você é de maior.");
            }

            else
            {
                Console.WriteLine($"Você tem {Idade} anos e você é de menor.");
            }

        }
    }
}
