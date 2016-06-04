using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursao
{
    class Program
    {
        static void Main(string[] args)
        {            
            ExibeNate0REcursivo(8); //Exibe de 0 a 8
            Console.WriteLine();
            ExibeNate0(8); //Exibe de 0 a 8;

            Console.WriteLine();
            Console.WriteLine("valor final =" + ExibeFatorialRecursivo(4)); // 4x3x2x1x0
            Console.WriteLine();
            Console.WriteLine("valor final =" + ExibeSomaRecursivo(5)); // de 1 a 5 somando por eles
            Console.WriteLine();
            
            int[] n = { 1, 6, 10, 4, 5 }; // numeros do vetor
            // soma os valores dentro do vetor
            Console.WriteLine("valor final =" +  ExibeVetorRecursivo(n,n.Length-1));
            Console.WriteLine();
            Console.ReadKey();
        }

        static void ExibeNate0(int n)
        {
            for (int i = n; i >= 0; i--)
            {
                Console.WriteLine(i);
            }            
        }

        static void ExibeNate0REcursivo(int n)
        {
            if (n < 0)
            {
                return;
            }
            else
            {
                Console.WriteLine(n);
                ExibeNate0REcursivo(n - 1);
            }
        }

        static int ExibeFatorialRecursivo(int n)
        {
            Console.WriteLine("n =" + n);

            if (n == 0)
            {
                Console.WriteLine();
                int fat = 1;                
                return fat;
            }
            else
            {
                int fat = n * ExibeFatorialRecursivo(n - 1);
                Console.WriteLine("fat =" + fat);
                return fat; // Fatorial de n é n * (n-1)!
            }
        }

        static int ExibeSomaRecursivo(int n)
        {
            Console.WriteLine("n =" + n);

            if (n == 0)
            {
                Console.WriteLine();
                int soma = 0;               
                return soma;
            }
            else
            {
                int soma = n + ExibeSomaRecursivo(n - 1);
                Console.WriteLine("soma =" + soma);
                return soma; 
            }
        }
      
        static int ExibeVetorRecursivo(int[] vetor, int ind)
        {            
            Console.WriteLine("valor =" + vetor[ind]);

            if (ind == 0)
            {
                Console.WriteLine();
                int soma = 1;                
                return soma;
            }
            else
            {
                int soma = vetor[ind] + ExibeVetorRecursivo(vetor, ind - 1);
                Console.WriteLine("soma =" + soma);
                return soma;
            }
        }
    }
}
