using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szemelyautok
{
    class Szemelyautok
    {
        static void Main(string[] args)
        {

            /*Személy autó*/
            try
            {
                Autok auto = new Autok("Audi", "Audi R8", 2000, 21000);
                Console.WriteLine($"Az autó neve: {auto.Nev}, \ntípusa: {auto.Tipus}, \néve: {auto.Eve}, \nára: {auto.Ara}");
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);

            }
            try
            {
                Autok auto = new Autok("", "", -2000, -21);
                Console.WriteLine($"Az autó neve: {auto.Nev}, \ntípusa: {auto.Tipus}, \néve: {auto.Eve}, \nára: {auto.Ara}");
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);

            }

            Console.WriteLine("\nProgram vége");
            Console.ReadKey();

        }
    }
}
