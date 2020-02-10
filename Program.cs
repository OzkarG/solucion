using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dime el primer numero a dividir: ");
            int Digito1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dime el segundo numero a dividir: ");
            int Digito2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                decimal resul = Digito1 / Digito2;

            }
            catch(Exception e)
            {
                Console.WriteLine("{0} Hubo un error compa: "+e);
            }
            Console.ReadKey();

        }
    }
}
