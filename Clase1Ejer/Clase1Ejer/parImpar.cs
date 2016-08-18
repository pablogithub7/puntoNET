using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1Ejer
{
    class parImpar
    {
        static void Main(string[] args)
        {
            try
            {
                //DECLARACION VARIABLES:
                int num;
                Console.Clear();
                Console.WriteLine("PROGRAMA QUE DETERMINA SI UN NUMERO ES PAR O IMPAR");
                Console.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _\n");
                Console.Write("INGRESE EL NUMERO: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine("ES PAR");
                }
                
                {
                    Console.WriteLine("ES IMPAR");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
            Console.ReadKey();
        }
    }



}

