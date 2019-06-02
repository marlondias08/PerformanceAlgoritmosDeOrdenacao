using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TrabalhoIntegradoAED
{
    public static class StopWatchExt
    {
        public static string StringDeTempo(this Stopwatch stopwatch, int digitos = 2)
        {
            double tempo = stopwatch.ElapsedTicks / (double)Stopwatch.Frequency;
            if (tempo > 1)
                return Math.Round(tempo, digitos) + " segundos"; //Segundos
            if (tempo > 1e-3)
                return Math.Round(1e3 * tempo, digitos) + " milissegundos"; //Milissegundos
            if (tempo > 1e-6)
                return Math.Round(1e6 * tempo, digitos) + " microsssegundos"; //Microsssegundos 
            if (tempo > 1e-9)
                return Math.Round(1e9 * tempo, digitos) + " nanossegundos"; //Nanossegundos
            return stopwatch.ElapsedTicks + " ticks";
        }
    }
}
