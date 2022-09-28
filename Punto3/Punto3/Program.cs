/*Escribe un programa que calcule el factorial de n donde n es un número entero mayor o 
igual que cero dado por el usuario.*/

public class HelloWorld
{
    public static long factorial(int n)
    {
        long actual = 0;
        actual = n;
        for (int i = n; i >= 1; i--)
        {
            if (n - 1 == 0)
            {
                break;
            }
            else
            {
                actual = actual * (n - 1);
                n = n - 1;
            }
        }
        return actual;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("INGRESE UN NUMERO:");
        int userValue = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("El factorial de " + userValue + " es: " + factorial(userValue));
    }
}