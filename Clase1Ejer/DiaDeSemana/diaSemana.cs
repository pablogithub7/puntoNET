using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaDeSemana
{
    class diaSemana
    {
        static void Main(string[] args)
        {
            String[] Dia = { "Domingo", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado" };
            Console.WriteLine("Ingresa un numero");
            int d = Convert.ToInt16(Console.ReadLine());
            if (d >= 1 && d <= 7)
            {
                Console.WriteLine("el dia " + d + " es " + Dia[d - 1]);
            }
            else
            {
                Console.WriteLine("No es un dia de la semana");
            }
            Console.ReadLine();
        }
    }
    
}
