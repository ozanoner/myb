using System;

namespace e11
{
    class Program
    {
        static void Main(string[] args)
        {
            // diziye ilk deger atama
            int[] notlar = new int[10]
            { 89, 62, 0, 0, 0, 0, 0, 0, 0, 0 };

            // dizinin tum elemanlarini yazdirma
            for (int index = 0; index < notlar.Length; index++)
            {
                Console.WriteLine(notlar[index]);
            }
        }
    }
}
