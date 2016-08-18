using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sueldo
{
    class sueldo
    {
        static void Main(string[] args)
        {
            float salario, aumento;
            int antig;
            salario = 40000;

            Console.WriteLine("EL salario del trabajador es de 40.000");
            Console.WriteLine("Ingrese la antiguedad en años del trabajador: ");
            antig = Convert.ToInt32(Console.ReadLine());

            if (antig >= 10)
            {
                aumento = salario + salario * 0.1F;
                Console.WriteLine("El salario final con aumento incluido segun antiguedad del trabajador es: " + aumento);
            }
            else if (antig < 10 && antig >= 5 )
            {
                aumento = salario + salario * 0.07F;
                Console.WriteLine("El salario final con aumento incluido segun antiguedad del trabajador es: " + aumento);
            }
            else if (antig < 5 && antig >= 3)
            {
                aumento = salario + salario * 0.05F;
                Console.WriteLine("El salario final con aumento incluido segun antiguedad del trabajador es: " + aumento);
            }
            else if (antig < 3 && antig >= 0)
            {
                aumento = salario + salario * 0.03F;
                Console.WriteLine("El salario final con aumento incluido segun antiguedad del trabajador es: " + aumento);
            }
            else
            {
                Console.WriteLine("La antiguedad no puede ser un numero negativo");
            }
       

            Console.ReadLine();

        }
    }
}
