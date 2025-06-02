using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_2___Attraper_des_exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("saisissez un nombre entier");

            //int nombre = int.Parse(Console.ReadLine());

            //Console.WriteLine("le nombre vaut : " + nombre);
            try

            {

                Console.WriteLine("saisissez un nombre entier");

                int nombre = int.Parse(Console.ReadLine());

                Console.WriteLine("le nombre vaut : " + nombre);

            }

            catch (FormatException exc)

            {

                Console.WriteLine("exception attrapée, voici son message :");

                Console.WriteLine(exc.Message);

            }

            catch (OverflowException exc)

            {

                Console.WriteLine("exception attrapée, voici son message :");

                Console.WriteLine(exc.Message);

            }

            finally

            {

                Console.WriteLine("ce bloc est toujours exécuté");

            }
        }
    }
}
