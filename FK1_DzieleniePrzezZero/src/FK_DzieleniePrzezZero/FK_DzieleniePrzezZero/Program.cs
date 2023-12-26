using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FK_DzieleniePrzezZero
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 12;

            Console.WriteLine("Twoje wartości to: \n=> x = " + x + "\n=> y = "+ y);
            Console.WriteLine("\nDziałanie matematyczne to: z = y / x\n");

            try
            {
                int z = y / x;
                Console.WriteLine("x=" + x);
                Console.WriteLine("y=" + y);
                Console.WriteLine("z=" + z);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Przykro mi, ale nie można dzielić przez zero :<");
            }

            Console.ReadKey();
        }
    }

    public class NaszaTablica
    {
        int[] tablica;
        public NaszaTablica()
        { tablica = new int[5]; }
        public int getElement(int index)
        {
            return tablica[index];
        }
    }
}
