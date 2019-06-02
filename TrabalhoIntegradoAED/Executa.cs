using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TrabalhoIntegradoAED
{
    class Executa
    {
        //Vetores para QuickSort
        private int[] quickInt;
        private string[] quickString;
        //Vetores para MergeSort
        private int[] mergeInt;
        private string[] mergeString;
        //Vetores para InsertionSort
        private int[] insertionInt;
        private string[] insertionString;
        //Vetores para SelectionSort
        private int[] selectionInt;
        private string[] selectionString;
        //Vetores para BubbleSort
        private int[] bubbleInt;
        private string[] bubbleString;

        public Executa(int vetInt, int vetString)
        {
            //Vetores para QuickSort
            quickInt = new int[vetInt];
            quickString = new string[vetString];
            //Vetores para MergeSort
            mergeInt = new int[vetInt];
            mergeString = new string[vetString];
            //Vetores para InsertionSort
            insertionInt = new int[vetInt];
            insertionString = new string[vetString];
            //Vetores para SelectionSort
            selectionInt = new int[vetInt];
            selectionString = new string[vetString];
            //Vetores para BubbleSort
            bubbleInt = new int[vetInt];
            bubbleString = new string[vetString];

            //Método para gerar os vetores de inteiros e strings
            geraVetor(quickInt, quickString, mergeInt, mergeString, insertionInt,
                      insertionString, selectionInt, selectionString, bubbleInt, bubbleString);            
        }

        public void fazQuick()
        {
            fazQuick(quickString, quickInt);
        }
        public void fazMerge()
        {
            fazMerge(mergeString, mergeInt);
        }
        public void fazSelection()
        {
            fazSelection(selectionString, selectionInt);
        }
        public void fazInsertion()
        {
            fazInsertion(insertionString, insertionInt);
        }
        public void fazBubble()
        {
            fazBubble(bubbleString, bubbleInt);
        }



        private void geraVetor(int[] quickInt, string[] quickString, int[] mergeInt, string[] mergeString,
                                     int[] insertionInt, string[] insertionString, int[] selectionInt, string[] selectionString,
                                     int[] bubbleInt, string[] bubbleString)
        {
            Console.WriteLine("Gerando vetores. Aguarde...\n");
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            Random rdn = new Random();

            for (int i = 0; i < quickString.Length; i++)
            {
                quickString[i] = new string(Enumerable.Repeat(chars, 4).Select(x => x[random.Next(x.Length)]).ToArray());
                mergeString[i] = new string(Enumerable.Repeat(chars, 4).Select(x => x[random.Next(x.Length)]).ToArray());
                insertionString[i] = new string(Enumerable.Repeat(chars, 4).Select(x => x[random.Next(x.Length)]).ToArray());
                selectionString[i] = new string(Enumerable.Repeat(chars, 4).Select(x => x[random.Next(x.Length)]).ToArray());
                bubbleString[i] = new string(Enumerable.Repeat(chars, 4).Select(x => x[random.Next(x.Length)]).ToArray());
            }
            for (int i = 0; i < quickInt.Length; i++)
            {
                quickInt[i] = rdn.Next(0, 100000);
                mergeInt[i] = rdn.Next(0, 100000);
                insertionInt[i] = rdn.Next(0, 100000);
                selectionInt[i] = rdn.Next(0, 100000);
                bubbleInt[i] = rdn.Next(0, 100000);
            }

            Console.WriteLine("Vetores gerados com sucesso.\n\n");
        }

        public void fazQuick(string[] quickString, int[] quickInt)
        {
            Console.WriteLine("     ------------- Ínicio do método de ordenação QuickSort -------------\n");
            Console.WriteLine("Ordenando vetor. Aguarde...\n");
            Stopwatch stopwatch = Stopwatch.StartNew();
            QuickSortString(quickString, 0, quickString.Length - 1);
            stopwatch.Stop();
            Console.WriteLine("           Tempo gasto com vetor de string desordenado: " + stopwatch.StringDeTempo());

            Console.WriteLine("\nOrdenando vetor. Aguarde...\n");
            Stopwatch stopwatch1 = Stopwatch.StartNew();
            QuickSortString(quickString, 0, quickString.Length - 1);
            stopwatch1.Stop();
            Console.WriteLine("           Tempo gasto com vetor de string ordenado: " + stopwatch1.StringDeTempo());

            Console.WriteLine("\nOrdenando vetor. Aguarde...\n");
            Stopwatch stopwatch2 = Stopwatch.StartNew();
            QuickSortInt(quickInt, 0, quickInt.Length - 1);
            stopwatch2.Stop();
            Console.WriteLine("           Tempo gasto com vetor de inteiros desordenado: " + stopwatch2.StringDeTempo());

            Console.WriteLine("\nOrdenando vetor. Aguarde...\n");
            Stopwatch stopwatch3 = Stopwatch.StartNew();
            QuickSortInt(quickInt, 0, quickInt.Length - 1);
            stopwatch3.Stop();
            Console.WriteLine("           Tempo gasto com vetor de inteiros ordenado: " + stopwatch3.StringDeTempo());

            Console.WriteLine("\n     ------------------------- Fim do QuickSort -------------------------\n");
        }

        public void fazMerge(string[] mergeString, int[] mergeInt)
        {
            Console.WriteLine("     ------------- Ínicio do método de ordenação MergeSort -------------\n");

            Console.WriteLine("\nOrdenando vetor. Aguarde...\n"); 
            Stopwatch stopwatch = Stopwatch.StartNew();
            MergeSortString(mergeString, 0, mergeString.Length - 1);
            stopwatch.Stop();
            Console.WriteLine("           Tempo gasto com vetor de string desordenado: " + stopwatch.StringDeTempo());

            Console.WriteLine("\nOrdenando vetor. Aguarde...\n");
            Stopwatch stopwatch1 = Stopwatch.StartNew();
            MergeSortString(mergeString, 0, mergeString.Length - 1);
            stopwatch1.Stop();
            Console.WriteLine("           Tempo gasto com vetor de string ordenado: " + stopwatch1.StringDeTempo());

            Console.WriteLine("\nOrdenando vetor. Aguarde...\n");
            Stopwatch stopwatch2 = Stopwatch.StartNew();
            MergeSortInt(mergeInt, 0, mergeInt.Length - 1);
            stopwatch2.Stop();
            Console.WriteLine("           Tempo gasto com vetor de inteiros desordenado: " + stopwatch2.StringDeTempo());

            Console.WriteLine("\nOrdenando vetor. Aguarde...\n");
            Stopwatch stopwatch3 = Stopwatch.StartNew();
            MergeSortInt(mergeInt, 0, mergeInt.Length - 1);
            stopwatch3.Stop();
            Console.WriteLine("           Tempo gasto com vetor de inteiros ordenado: " + stopwatch3.StringDeTempo());

            Console.WriteLine("\n     ------------------------- Fim do MergeSort -------------------------\n");
        }

        public void fazSelection(string[] selectionString, int[] selectionInt)
        {
            Console.WriteLine("     ------------- Ínicio do método de ordenação SelectionSort -------------\n");
            Console.WriteLine("Ordenando vetor. Aguarde...\n");
            Stopwatch stopwatch = Stopwatch.StartNew();
            SelectionSortString(selectionString);
            stopwatch.Stop();
            Console.WriteLine("           Tempo gasto com vetor de string desordenado: " + stopwatch.StringDeTempo());

            Console.WriteLine("\nOrdenando vetor. Aguarde...\n");
            Stopwatch stopwatch1 = Stopwatch.StartNew();
            SelectionSortString(selectionString);
            stopwatch1.Stop();
            Console.WriteLine("           Tempo gasto com vetor de string ordenado: " + stopwatch1.StringDeTempo());

            Console.WriteLine("\nOrdenando vetor. Aguarde...\n");
            Stopwatch stopwatch2 = Stopwatch.StartNew();
            SelectionSortInt(selectionInt);
            stopwatch2.Stop();
            Console.WriteLine("           Tempo gasto com vetor de inteiros desordenado: " + stopwatch2.StringDeTempo());

            Console.WriteLine("\nOrdenando vetor. Aguarde...\n");
            Stopwatch stopwatch3 = Stopwatch.StartNew();
            SelectionSortInt(selectionInt);
            stopwatch3.Stop();
            Console.WriteLine("           Tempo gasto com vetor de inteiros ordenado: " + stopwatch3.StringDeTempo());

            Console.WriteLine("\n     ------------------------- Fim do SelectionSort -------------------------\n");
        }

        public void fazInsertion(string[] insertionString, int[] insertionInt)
        {
            Console.WriteLine("     ------------- Ínicio do método de ordenação InsertionSort -------------\n");
            Console.WriteLine("Ordenando vetor. Aguarde...\n");
            Stopwatch stopwatch = Stopwatch.StartNew();
            InsertionSortString(insertionString);
            stopwatch.Stop();
            Console.WriteLine("           Tempo gasto com vetor de string desordenado: " + stopwatch.StringDeTempo());

            Console.WriteLine("\nOrdenando vetor. Aguarde...\n");
            Stopwatch stopwatch1 = Stopwatch.StartNew();
            InsertionSortString(insertionString);
            stopwatch1.Stop();
            Console.WriteLine("           Tempo gasto com vetor de string ordenado: " + stopwatch1.StringDeTempo());

            Console.WriteLine("\nOrdenando vetor. Aguarde...\n");
            Stopwatch stopwatch2 = Stopwatch.StartNew();
            InsertionSortInt(insertionInt);
            stopwatch2.Stop();
            Console.WriteLine("           Tempo gasto com vetor de inteiros desordenado: " + stopwatch2.StringDeTempo());

            Console.WriteLine("\nOrdenando vetor. Aguarde...\n");
            Stopwatch stopwatch3 = Stopwatch.StartNew();
            InsertionSortInt(insertionInt);
            stopwatch3.Stop();
            Console.WriteLine("           Tempo gasto com vetor de inteiros ordenado: " + stopwatch3.StringDeTempo());

            Console.WriteLine("\n     ------------------------- Fim do InsertionSort -------------------------\n");
        }

        public void fazBubble(string[] bubbleString, int[] bubbleInt)
        {
            Console.WriteLine("     ------------- Ínicio do método de ordenação BubbleSort -------------\n");
            Console.WriteLine("Ordenando vetor. Aguarde...\n");
            Stopwatch stopwatch = Stopwatch.StartNew();
            BubbleSortString(bubbleString, bubbleString.Length);
            stopwatch.Stop();
            Console.WriteLine("           Tempo gasto com vetor de string desordenado: " + stopwatch.StringDeTempo());

            Console.WriteLine("\nOrdenando vetor. Aguarde...\n");
            Stopwatch stopwatch1 = Stopwatch.StartNew();
            BubbleSortString(bubbleString, bubbleString.Length);
            stopwatch1.Stop();
            Console.WriteLine("           Tempo gasto com vetor de string ordenado: " + stopwatch1.StringDeTempo());

            Console.WriteLine("\nOrdenando vetor. Aguarde...\n");
            Stopwatch stopwatch2 = Stopwatch.StartNew();
            BubbleSortInt(bubbleInt, bubbleInt.Length);
            stopwatch2.Stop();
            Console.WriteLine("           Tempo gasto com vetor de inteiros desordenado: " + stopwatch2.StringDeTempo());

            Console.WriteLine("\nOrdenando vetor. Aguarde...\n");
            Stopwatch stopwatch3 = Stopwatch.StartNew();
            BubbleSortInt(bubbleInt, bubbleInt.Length);
            stopwatch3.Stop();
            Console.WriteLine("           Tempo gasto com vetor de inteiros ordenado: " + stopwatch3.StringDeTempo());

            Console.WriteLine("\n     ------------------------- Fim do BubbleSort -------------------------\n");
        }

        private void QuickSortString(string[] vet, int left, int right)
        {
            int i = left, j = right;
            string pivo = vet[(left + right) / 2];

            while (i <= j)
            {
                while (vet[i].CompareTo(pivo) < 0)
                {
                    i++;
                }

                while (vet[j].CompareTo(pivo) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    string tmp = vet[i];
                    vet[i] = vet[j];
                    vet[j] = tmp;

                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                QuickSortString(vet, left, j);
            }

            if (i < right)
            {
                QuickSortString(vet, i, right);
            }
        }
        private void QuickSortInt(int[] vet, int left, int right)
        {
            int i = left, j = right;
            int pivo = vet[(left + right) / 2];

            while (i <= j)
            {
                while (vet[i] < pivo)
                {
                    i++;
                }

                while (vet[j] > pivo)
                {
                    j--;
                }

                if (i <= j)
                {
                    int tmp = vet[i];
                    vet[i] = vet[j];
                    vet[j] = tmp;

                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                QuickSortInt(vet, left, j);
            }

            if (i < right)
            {
                QuickSortInt(vet, i, right);
            }
        }


        public void MergeSortInt(int[] vet, int esq, int dir)
        {
            int meio;

            if (dir > esq)
            {
                meio = (dir + esq) / 2;
                MergeSortInt(vet, esq, meio);
                MergeSortInt(vet, (meio + 1), dir);
                Merge(vet, esq, (meio + 1), dir);
            }
        }

        public void Merge(int[] vet, int esq, int meio, int dir)
        {
            
            int[] aux = new int[vet.Length];
            int i, fimEsq, lenghtVet, posAux;
            fimEsq = meio - 1;
            posAux = esq;
            lenghtVet = dir - esq + 1;

            
            while ((esq <= fimEsq) && (meio <= dir))
            {
                if (vet[esq] <= vet[meio])
                {
                    aux[posAux++] = vet[esq++];
                }
                else
                {
                    aux[posAux++] = vet[meio++];
                }
            }
           
            while (esq <= fimEsq)
            {
                aux[posAux++] = vet[esq++];
            }

            
            while (meio <= dir)
            {
                aux[posAux++] = vet[meio++];
            }

            
            for (i = 0; i < lenghtVet; i++)
            {
                vet[dir] = aux[dir];
                dir--;
            }
        }

        public void MergeSortString(string[] vet, int esq, int dir)
        {
            int meio;

            if (dir > esq)
            {
                meio = (dir + esq) / 2;
                MergeSortString(vet, esq, meio);
                MergeSortString(vet, (meio + 1), dir);
                Merge(vet, esq, (meio + 1), dir);
            }
        }

        public void Merge(string[] vet, int esq, int meio, int dir)
        {

            string[] aux = new string[vet.Length];
            int i, fimEsq, lenghtVet, posAux;
            fimEsq = meio - 1;
            posAux = esq;
            lenghtVet = dir - esq + 1;


            while ((esq <= fimEsq) && (meio <= dir))
            {
                if (vet[esq].CompareTo(vet[meio]) == 0 || vet[esq].CompareTo(vet[meio]) < 0)
                {
                    aux[posAux++] = vet[esq++];
                }
                else
                {
                    aux[posAux++] = vet[meio++];
                }
            }

            while (esq <= fimEsq)
            {
                aux[posAux++] = vet[esq++];
            }


            while (meio <= dir)
            {
                aux[posAux++] = vet[meio++];
            }


            for (i = 0; i < lenghtVet; i++)
            {
                vet[dir] = aux[dir];
                dir--;
            }
        }

        private void SelectionSortInt(int[] vet)
        {
            int aux, min;

            for (int i = 0; i < vet.Length; i++)
            {
                min = i;
                for (int j = 1 + i; j < vet.Length; j++)
                {
                    if (vet[j] < vet[min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    aux = vet[i];
                    vet[i] = vet[min];
                    vet[min] = aux;
                }
            }
        }
        private void SelectionSortString(string[] vet)
        {
            int min;
            string aux;

            for (int i = 0; i < vet.Length; i++)
            {
                min = i;
                for (int j = 1 + i; j < vet.Length; j++)
                {
                    if (vet[j].CompareTo(vet[min]) == -1)
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    aux = vet[i];
                    vet[i] = vet[min];
                    vet[min] = aux;
                }
            }
        }

        private void InsertionSortString(string[] vet)
        {

            for (int i = 1; i < vet.Length; i++)
            {
                int j = i;

                while (j > 0)
                {
                    if (string.Compare(vet[j - 1], vet[j]) > 0)
                    {
                        string temp = vet[j - 1];
                        vet[j - 1] = vet[j];
                        vet[j] = temp;
                        j--;
                    }
                    else
                        break;
                }
            }            
        }
        private void InsertionSortInt(int[] vet)
        {

            for (int i = 1; i < vet.Length; i++)
            {
                int j = i;


                while (j > 0)
                {
                    if (vet[j - 1] > vet[j])
                    {
                        int temp = vet[j - 1];
                        vet[j - 1] = vet[j];
                        vet[j] = temp;
                        j--;
                    }
                    else
                        break;
                }
            }
        }

        private void BubbleSortString(string[] vet, int tamVet)
        {
            for (int i = 0; i < vet.Length - 1; i++)
            {
                for (int j = 0; j < vet.Length - 1; j++)
                {
                    if (vet[j].CompareTo(vet[j + 1]) > 0)
                    {
                        string aux = vet[j];
                        vet[j] = vet[j + 1];
                        vet[j + 1] = aux;
                    }
                }
            }
        }
        private void BubbleSortInt(int[] vet, int tamVet)
        {
            for (int i = 0; i < vet.Length - 1; i++)
            {
                for (int j = 0; j < vet.Length - 1; j++)
                {
                    if (vet[j] > vet[j + 1])
                    {
                        int aux = vet[j];
                        vet[j] = vet[j + 1];
                        vet[j + 1] = aux;
                    }
                }
            }
        }
    }
}
