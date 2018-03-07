using System;

namespace e1
{
    class Sekil
    {
        public int KenarSayisi { get; set; }

        public virtual string Bilgi()
        {
            return $"K={KenarSayisi}";
        }
    }

    class Daire: Sekil
    {
        public int Yaricap { get; set; }
        public override string Bilgi()
        {
            return $"Yaricap={Yaricap}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sekil sekil = new Sekil();
            Console.WriteLine($"Sekil bilgi: {sekil.Bilgi()}");

            Daire daire = new Daire();
            Console.WriteLine($"Daire bilgi: {daire.Bilgi()}");

            sekil = daire;
            Console.WriteLine($"Sekil bilgi: {sekil.Bilgi()}");
        }
    }
}
