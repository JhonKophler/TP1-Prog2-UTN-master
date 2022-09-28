using System;
/* Escribe un programa que tome un año introducido por el usuario y diga si es bisiesto o no.
Recuerda que los años múltiplos de 4 son bisiestos, excepto aquellos que son múltiplos de
100 y no lo son de 400. Es decir el año 2000 si es bisiesto, pero no lo son el 1990 ni el 2100. */
namespace Punto_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INGRESE UN ANIO PARA SABER SI ES BISIESTO");
            int anio = Convert.ToInt32(Console.ReadLine());

            if (((anio % 4) == 0 && (anio % 100) != 0) || ((anio % 400) == 0 && (anio % 100) == 0))
            {
                Console.WriteLine("ES UN ANIO BISIESTO");
            }
            else
            {
                Console.WriteLine("NO ES BISIESTO");
            }

        }
    }
}
