using System;

namespace Vetor3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = {10 , 23, 5, 45, 68, 12, 70};
            Console.WriteLine("Qtd do vetor. " +numeros.Length);
            int resultado = numeros[0];
            for (int i = 1 ; i < numeros.Length ; i ++) {
                resultado+=numeros[i];
            }
            Console.WriteLine("A soma é " + resultado);
        }
    }
}
