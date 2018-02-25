using System;


namespace e11
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, string> birFonksiyon;
            int i = 10;

            if (i < 10)
                birFonksiyon = (int val) => { return $"10dan kucukler icin {val}"; };
            else
                birFonksiyon = x => { return "10dan buyuk veya esit"; };

            Console.WriteLine(birFonksiyon(i));
        }
    }
}
