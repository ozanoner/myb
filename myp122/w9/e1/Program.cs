using System;


namespace e1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int i = 0;
                int j = 1 / i;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
