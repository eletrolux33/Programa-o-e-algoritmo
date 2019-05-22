using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_02_Exe_22
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Construa um algoritmo que leia o código de um determinado produto (CP) e mostre a sua
classificação, utilizando a seguinte tabela:

Código do Produto (CP)          Classificação
1                               Alimento não perecível
2, 3 ou 4                       Alimento perecível
5 ou 6                          Vestuário
7                               Higiene Pessoal
8 ou 9                          Limpeza e Utensílios Domésticos
Qualquer outro código           Inválido*/

            int cp;
            Console.Write("Insira o código do produto: ");
            cp = int.Parse(Console.ReadLine());
            switch (cp)
            {
                case 1:
                    Console.Write("Classificação: Alimento não perecível!");
                    break;
                case 2:
                    Console.Write("Classificação: Alimento perecível!");
                    break;
                case 3:
                    Console.Write("Classificação: Alimento perecível!");
                    break;
                case 4:
                    Console.Write("Classificação: Alimento perecível!");
                    break;
                case 5:
                    Console.Write("Classificação: Vestuário!");
                    break;
                case 6:
                    Console.Write("Classificação: Vestuário!");
                    break;
                case 7:
                    Console.Write("Classificação: Higiene Pessoal!");
                    break;
                case 8:
                    Console.Write("Classificação: Limpeza e Utensílios Domésticos!");
                    break;
                case 9:
                    Console.Write("Classificação: Limpeza e Utensílios Domésticos!");
                    break;
                default:
                    Console.Write("Inválido!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
