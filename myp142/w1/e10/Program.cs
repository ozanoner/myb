using System;


namespace e10
{
    class Program
    {
        static void Main(string[] args)
        {
            // VERBATIM 
            // @ ile escape iptal edilir. 
            
            // stringi oldugu gibi basar. escape \ gormezden gelir
            Console.WriteLine(@"Her\nsatira\nbir\nkelime");
            // ekrana dosya yerini basar
            Console.WriteLine(@"C:\kullanicilar\ozan\masaustu\dosya1.txt");
        }
    }
}
