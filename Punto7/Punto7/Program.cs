/*Escribe el programa para un juego que consista en averiguar un número. El programa nos 
indicará cada vez si el número introducido es mayor o menor que la constante almacenada que 
tendremos que averiguar. Cuando se descubre el numero mostrara un mensaje de felicitación*/

public class HelloWorld
{
    public static void adivinaNumero(int n)
    {
        int num = 0;
        while (num != n)
        {
            Console.WriteLine("ADIVINE EL NUMERO: ");
            int valor = Convert.ToInt32(Console.ReadLine());
            num = valor;
        }
        Console.WriteLine("ADIVINASTE!!\nEL NUMERO ERA " + n);
    }

    public static void Main(string[] args)
    {
        adivinaNumero(22);
    }
}