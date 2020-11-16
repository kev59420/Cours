using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SayMyName
{
    class Program
    {
        
        static void Main(string[] args)
        {

            
            NewPartie(numero);
            Win(numero);
            Console.ReadKey();
        }
        static void NewPartie()
        {
            int numero = new Random().Next(1, 20);
            int valeur = 0;
            Console.WriteLine("Choisissez un nombre entre 1 et 20");
            do
            {
                valeur = Test();
                if (valeur > numero)
                {
                    Console.WriteLine("C'est Moins");
                }
                else if (valeur < numero)
                {
                    Console.WriteLine("C'est Plus");
                }
            } while (valeur != numero);
        }
        static void Win(int random)
        {
            Console.WriteLine("Bravo c'etait bien : " + random);
        }
        static int Test()
        {
            string lol;
            int lol2;
            lol = Console.ReadLine();
            while ((!int.TryParse(lol, out lol2)) || (int.Parse(lol) >= 20) || (int.Parse(lol) < 1))
            {
                Console.WriteLine("il faut saisir un nombre entre 1 et 20");
                lol = Console.ReadLine();
            }
            return lol2;
        }

    }
}
