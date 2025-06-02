using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValiderNote
{
    class Program
    {
        static void Main(string[] args)
        {
            try {

                Console.WriteLine("Saisissez une note (entière)");

                int note = Convert.ToInt32(Console.ReadLine());

                ValiderNote(note);

                Console.WriteLine("La note est valide. Fin du programme");

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("une erreur s'est produite");

                Console.WriteLine(ex.Message);
            }
            catch (FormatException exc)

            {

                Console.WriteLine("une erreur s'est produite");

                Console.WriteLine(exc.Message);

            }

            catch (OverflowException exc)

            {

                Console.WriteLine("une erreur s'est produite");

                Console.WriteLine(exc.Message);

            }

            finally

            {

                Console.WriteLine("test");

            }
        }

        public static void ValiderNote(int n)
        {

            if (n < 0 || n > 20)
            {

                throw new ArgumentOutOfRangeException("Note invalide");

            }

        }
    }
}
