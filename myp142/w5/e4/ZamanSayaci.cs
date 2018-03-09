using System;
using System.Diagnostics;

// https://msdn.microsoft.com/en-us/library/system.diagnostics.stopwatch(v=vs.110).aspx

namespace e4
{
    /// <summary>
    /// bir islemin baslangicindan bitisine kadar 
    /// gecen sureyi olcmek icin kullanilabilir
    /// Stopwatch sinifini kullanir
    /// </summary>
    public class ZamanSayaci
    {
        Stopwatch w;

        /// <summary>
        /// sayaci baslatir
        /// </summary>
        public void Baslat()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            w = Stopwatch.StartNew();
        }
        /// <summary>
        /// sayaci durdurur
        /// </summary>
        /// <returns>
        /// ms olarak ne kadar sure gectigi
        /// </returns>
        public long Durdur()
        {
            w.Stop();
            return w.ElapsedMilliseconds;
        }
        
        /// <summary>
        /// zaman sayaci string gorunumu
        /// </summary>
        /// <returns>
        /// formatli gecen sure
        /// </returns>
        public override string ToString()
        {
            return  $"Gecen sure (ms):" +
                $"{w.ElapsedMilliseconds}";
        }
    }
}
