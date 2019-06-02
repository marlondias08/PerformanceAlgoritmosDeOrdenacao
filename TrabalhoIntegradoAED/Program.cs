using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TrabalhoIntegradoAED
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("     ---------------------------------------------------------------------");
            Console.WriteLine("                            Trabalho Integrado de AED                    ");
            Console.WriteLine("                                     Bem vindo                           ");
            Console.WriteLine("     ---------------------------------------------------------------------\n\n");

            /* Instância da classe que irá executar os testes
             * Os valores nos parâmetros são os tamanhos dos vetores
             * O primeiro valor refere-se aos vetores de inteiros
             * E o segundo aos vetores de strings */
            Executa executar = new Executa(25000, 10000);

            //Chamada para o QuickSort
            executar.fazQuick();
            //Chamada para o MergeSort
            executar.fazMerge();
            //Chamada para o SelectionSort
            executar.fazSelection();
            //Chamada para o InsertionSort
            executar.fazInsertion();
            //Chamada para o BubbleSort
            executar.fazBubble();

            Console.ReadKey();
         }  
        

        
    }
}
