using System;

namespace e8
{
    // sinifin disinda enum tanimi
    enum Gun { Pazartesi, Sali, Carsamba, Persembe, Cuma, Ctesi, Pazar }
    class Program
    {
        static void Main(string[] args)
        {
            Gun gunDegiskeni = Gun.Pazar;
            if(gunDegiskeni == Gun.Pazartesi)
            {
                Console.WriteLine("Bugun dersimiz var");
            }
            else if(gunDegiskeni == Gun.Ctesi || gunDegiskeni == Gun.Pazar)
            {
                Console.WriteLine("Bugun haftasonu");
            }
        }
    }
}
