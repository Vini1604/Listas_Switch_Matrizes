using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] campoMinado = new int[3,3];
            const int bandeira = 10, bomba = 0;
            int somaLinha1 = 0, somaColuna2 = 0;
            int multiplicaCelulas, divideBomba;
            campoMinado[0, 0] = 2;
            campoMinado[0, 1] = bandeira;
            campoMinado[1, 1] = bomba;
            campoMinado[1, 2] = 3;
            campoMinado[2, 1] = 1;

            for (int i = 0; i < campoMinado.GetLength(0); i++)
            {
                for (int j = 0; j < campoMinado.GetLength(1); j++)
                {
                    Console.Write($"{campoMinado[i, j]}     ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            for (int i = 0; i < campoMinado.GetLength(0); i++)
            {
                somaLinha1 += campoMinado[0, i];
                
            }
            Console.WriteLine(somaLinha1);

            for (int i = 0; i < campoMinado.GetLength(1); i++)
            {
                somaColuna2 += campoMinado[i, 1];
            }
            Console.WriteLine(somaColuna2);

            multiplicaCelulas = bandeira * campoMinado[1, 2];
            Console.WriteLine(multiplicaCelulas);


            // NAO E POSSIVEL A DIVISAO POIS TEMOS UMA DIVISAO POR ZERO
            /*  
            divideBomba = bandeira / bomba;
            Console.WriteLine(divideBomba);
            */
        }
    }
}
