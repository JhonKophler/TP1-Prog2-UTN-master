/*Escribe un programa que calcule la suma de todos los números múltiplos de 5 
comprendidos entre dos enteros positivos leídos por teclado*/


public class HelloWorld
{
    public static void sumaDeLos5(int n, int m)
    {
        int sumita = 0;
        for (int i = n; i <= m; i++)
        {
            if ((i % 5) == 0)
            {
                sumita += i;
            }
        }
        Console.WriteLine(sumita);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("INGRESE UIN INTERVALO DE DOS NUMEROS: ");
        Console.WriteLine("INICIO:");
        int value1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("FINAL:");
        int value2 = Convert.ToInt32(Console.ReadLine());
        sumaDeLos5(value1, value2);
    }
}
