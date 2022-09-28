/*Escribe un programa que escriba la tabla de multiplicar de cualquier número entero dado 
por el usuario, entre 1 y 10.*/

public class HelloWorld
{
    public static void tablaDeMultiplicar(int n)
    {
        Console.WriteLine("TABLA DE " + n + " es:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i + " X " + n + " = " + i * n);
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("INGRESE UN NUMERO:");
        int userValue = Convert.ToInt32(Console.ReadLine());
        tablaDeMultiplicar(userValue);
    }
}