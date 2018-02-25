using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Secim yapiniz (1-3):");
                byte kullaniciSecimi = Convert.ToByte(Console.ReadLine());
                switch (kullaniciSecimi)
                {
                    case 1:
                        BirMethod_ArgumentNullExceptionAtar();
                        break;
                    case 2:
                        BirMethod_NotImplementedExceptionAtar();
                        break;
                    case 3:
                        BirMethod_Normal();
                        break;
                    default:
                        break;
                }
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine($"ArgumentNull olustu, tekrar deneyiniz. ({e.Message})");
            }
            catch(NotImplementedException e)
            {
                Console.WriteLine($"Programci hatasi, bildiriniz. ({e.Message})");
            }
            catch (Exception)
            {
                Console.WriteLine($"Beklenmeyen hata olustu.");
                throw;
            }
        }

        static void BirMethod_ArgumentNullExceptionAtar()
        {
            throw new ArgumentNullException("null parametre geldi");
        }

        static void BirMethod_NotImplementedExceptionAtar()
        {
            throw new NotImplementedException("programci unuttu");
        }
        static void BirMethod_Normal()
        {
            Console.WriteLine("BirMethod_Normal calisti");
        }
    }
}
