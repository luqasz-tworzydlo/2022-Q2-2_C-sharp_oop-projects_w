using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FK_UzycieWlasnegoWyjatku
{
    public class Program
    {
        static void Main(string[] args)
        {
            Tablica tab = new Tablica();
            try
            {
                int value = tab.getElement(24);
                Console.WriteLine("=> Element nr 24 ma wartość: " + value);
            }

            catch (NieMaTakiegoElementu)
            {
                Console.WriteLine("=> Nie ma 'Element nr 24 ma wartość'");
            }

            Console.ReadKey();
        }
    }

    public class NieMaTakiegoElementu : Exception
    { }

    public class Tablica
    {
        int[] tablica;
        public Tablica()
        { tablica = new int[5]; }
        public int getElement(int index)
        {
            if (index < 0 || index > tablica.Length - 1)
            {
                throw new NieMaTakiegoElementu();
            }
            else
            {

                return tablica[index];
            }
        }
    }
}
