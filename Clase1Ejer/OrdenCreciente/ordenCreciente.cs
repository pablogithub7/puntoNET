using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenCreciente
{
    class ordenCreciente
    {
        static void Main(string[] args)
        {
            //VARIABLES:
            int n1, n2, n3;
            Console.Clear();
            Console.WriteLine("PROGRAMA ORDEN CRECIENTE.-(PABLO BIELSA).");
            Console.Write("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _\n");
            Console.WriteLine("INGRESE EL PRIMER VALOR: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("INGRESE EL SEGUNDO VALOR: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("INGRESE EL TERCER VALOR: ");
            n3 = Convert.ToInt32(Console.ReadLine());
            if (n1 < n2)
            {
                if (n2 < n3)
                {
                    Console.WriteLine("Orden creciente");
                }
                else
                {
                    Console.WriteLine("No están introducidos en orden creciente");
                }
            }
            else
            {
                Console.WriteLine("No están introducidos en orden creciente");
            }
            Console.ReadKey();

        }
    }
}
