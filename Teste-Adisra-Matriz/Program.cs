using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImparOuPar
{
    internal class Program
    {
        public int ContarMaioresOcorrencias(int[,] matriz, int numLinhas, int numColunas)
        {
            int contagemPares = 0;
            int contagemImpares = 0;

            // Iterar por cada elemento da matriz
            for (int i = 0; i < numLinhas; i++)
            {
                for (int j = 0; j < numColunas; j++)
                {
                    // Verificar se o elemento é par ou ímpar
                    if (matriz[i, j] % 2 == 0)
                    {
                        contagemPares++;
                    }
                    else
                    {
                        contagemImpares++;
                    }
                }
            }

            // Verificar qual contagem é maior e retornar o valor correspondente
            if (contagemPares >= contagemImpares)
            {
                return contagemPares;
            }
            else
            {
                return contagemImpares;
            }
        }
    }
}