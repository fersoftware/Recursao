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
                Console.WriteLine(i); //Exibe o loop i
            }            
        }

        static void ExibeNate0REcursivo(int n)
        {
            if (n < 0)
            {
                return; // menor que 0 para;
            }
            else
            {
                Console.WriteLine(n); //mostra o valor de n
                ExibeNate0REcursivo(n - 1); // chama o metodo tirando 1 sempre
                // a cada metodo chamado ele diminui 1 até zerar
            }
        }

        static int ExibeFatorialRecursivo(int n)
        {
            Console.WriteLine("n =" + n); //Mostra os numeros

            if (n == 0)
            {
                Console.WriteLine(); //Se a posicao for 0 pula linha
                int fat = 1; // guarda o valor 1 para ser usado depois na multiplicacao
                return fat; // retorna o valor para ser usado na volta
            }
            else
            {
                // pega a posicao n e multiplica pelo retorno do metodo
                int fat = n * ExibeFatorialRecursivo(n - 1); // a cada retorno do metodo ele diminui 1
                Console.WriteLine("fat =" + fat); // mostra a multiplicacao feita pela variavel fat
                return fat; // Fatorial de n é n * (n-1)!
            }
        }

        static int ExibeSomaRecursivo(int n)
        {
            Console.WriteLine("n =" + n); //Mostra o valor do metodo

            if (n == 0)
            {
                Console.WriteLine(); //Ao chegar na posicao 0 ele pula a linha
                int soma = 0;               
                return soma; // retorna 0 para ser ser usado depois na soma
            }
            else
            {
                int soma = n + ExibeSomaRecursivo(n - 1); //Pega o valor n (que é do proprio metodo) e soma com o metodo - 1
                Console.WriteLine("soma =" + soma); // mostra a soma
                return soma; // retorna a soma para ser usado na volta
            }
        }
      
        static int ExibeVetorRecursivo(int[] vetor, int ind)
        {
            //Mostra os valores guardados no vetor
            Console.WriteLine("valor =" + vetor[ind]);

            if (ind == 0)
            {
                Console.WriteLine(); //Indice 0 pula linha
                int soma = 1; // é 1 porque 0 dá a soma errada               
                return soma; // retorna o valor para ser usado na volta
            }
            else
            {
                // pega o valor do vetor e soma com o valor da posicao anterior (ind - 1)
                int soma = vetor[ind] + ExibeVetorRecursivo(vetor, ind - 1);
                Console.WriteLine("soma =" + soma); //Exibe a soma;
                return soma; // retorna a soma para ser usada na volta
            }
        }
    }
}
