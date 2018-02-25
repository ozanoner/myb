using System;

namespace e4
{
    class Program
    {
        static void Main(string[] args)
        {
            Nokta nokta = new Nokta() { X = 1, Y = 2 };
            nokta.NoktaDegisti += NoktaDegistigindeCalistir;
            nokta.X = 3;
        }

        private static void NoktaDegistigindeCalistir(object sender, EventArgs e)
        {
            Console.WriteLine("nokta koordinat degisti.");
        }
    }
}
