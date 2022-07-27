using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_1
{
   public class Program
    {
        public static bool verificare_numere(double nr1,double nr2)
        {
            if (nr1 == 0 && nr2 == 0)
                return false;
            else return true;
        }
        public static double adunare(double nr1,double nr2)
        {
            return nr1 + nr2;
        }
        public static double scadere(double nr1, double nr2)
        {if (nr1 > nr2)
                return nr1 - nr2;
            else return nr2 - nr1;
        }
        public static double impartire(double nr1, double nr2)
        {
            if (nr1 > nr2 && nr2 != 0)
                return nr1 / nr2;
            else return nr2 / nr1;

        }
        public static double inmultire(double nr1, double nr2)
        {
                return nr1 * nr2;
        }
        public double getNumarmaiMic(double nr1, double nr2)
        {
            if (nr1 < nr2)
                return nr1;
            else return nr2;
        }
        static void Main(string[] args)
        { double nr1, nr2;
            Console.Write("Primul numar : ");
            nr1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Al doilea numar : ");
            nr2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Adunarea celor 2 numere este : {0} \n", adunare(nr1, nr2));
                Console.Write("Scaderea celor 2 numere este : {0} \n", scadere(nr1, nr2));
                Console.Write("Inmultirea celor 2 numere este : {0} \n", inmultire(nr1, nr2));

            if (verificare_numere(nr1, nr2) == true)
            { Console.Write("Impartirea celor 2 numere este : {0} \n", impartire(nr1, nr2)); }
            else Console.WriteLine(" !!! Nu putem face impartirea la 0");
                Console.ReadLine();

        }
    }
}
