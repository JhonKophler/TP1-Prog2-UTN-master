/*Escribe un programa que escriba todos los divisores de un número n entero 
positivo introducido por el usuario.*/

public class HelloWorld
{
    public static void todos_los_divisores(int n)
    {
        Console.WriteLine("LOS DIVISORES DE " + n + " son:");
        for (int i = 1; i <= n; i++)
        {
            if ((n % i) == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("INGRESE UN NUMERO:");
        int userValue = Convert.ToInt32(Console.ReadLine());
        todos_los_divisores(userValue);
    }
}