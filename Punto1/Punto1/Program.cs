using System;

/*Escribe un programa que tome 3 números enteros introducidos por el usuario mediante el
teclado y determine cuántos de dichos números son diferentes, el promedio, la suma de
todos, el producto del mayor por el menor y si el número restante es divisible por 3.*/

namespace Punto_1
{
    class Program
    {

        public static int IngresarNumero()
        {
            Console.WriteLine("INGRESE VALOR");
            int valor = Convert.ToInt32(Console.ReadLine());
            return valor;
        }
        public static void DivisiblePor3(int x)
        {
            if ((x % 3) == 0)
            {
                Console.WriteLine(x + " Es divisible por CERO\n");
            }
            else
            {
                Console.WriteLine(x + " No es divisible por CERO\n");
            }
        }

        static void Main(string[] args)
        {
            int menor = 0;
            int mayor = 0;
            int producto = 0;
            int a = IngresarNumero();
            int b = IngresarNumero();
            int c = IngresarNumero();

            Console.WriteLine("LOS VALORES INGRESADOS SON:\n" + a + "\n" + b + "\n" + c + "\n");

            if (a != b && b != c && a != c)
            {
                Console.WriteLine("Los tres numeros son diferentes");
                if (a < b && a < c)
                {
                    menor = a;
                    Console.WriteLine("A es el menor");
                    if (b > c)
                    {
                        mayor = b;
                        Console.WriteLine("B es el mayor");
                        DivisiblePor3(c);

                    }
                    else
                    {
                        mayor = c;
                        Console.WriteLine("C es el mayor");
                        DivisiblePor3(b);
                    }
                }
                if (b < a && b < c)
                {
                    menor = b;
                    Console.WriteLine("B es el menor");
                    if (a > c)
                    {
                        mayor = a;
                        Console.WriteLine("A es el mayor");
                        DivisiblePor3(c);
                    }
                    else
                    {
                        mayor = c;
                        Console.WriteLine("C es el mayor");
                        DivisiblePor3(a);
                    }
                }
                if (c < b && c < a)
                {
                    menor = c;
                    Console.WriteLine("C es el menor");
                    if (a > b)
                    {
                        mayor = a;
                        Console.WriteLine("A es el mayor");
                        DivisiblePor3(b);
                    }
                    else
                    {
                        mayor = b;
                        Console.WriteLine("B es el mayor");
                        DivisiblePor3(a);
                    }
                }
                producto = menor * mayor;
            }
            if (a == b && b != c)
            {
                Console.WriteLine(c + " Es diferente al primero y segundo ingresado.");
                producto = c * a;
            }
            if (a != b && b == c)
            {
                Console.WriteLine(a + " Es diferente al segundo y tercero ingresado.");
                producto = a * b;
            }
            if (a != b && a == c)
            {
                Console.WriteLine(b + " Es diferente al primero y tercero ingresado.");
                producto = b * a;
            }

            int suma = a + b + c;
            double promedio = (double)suma / 3;
            Console.WriteLine("El promedio de los 3 numeros es: " + promedio.ToString("N2"));
            Console.WriteLine("La suma de todos es: " + suma);

            Console.WriteLine("\n");
            Console.WriteLine("El producto del mayor por el menor: " + producto);
            Console.WriteLine("\n");
        }
    }
}
