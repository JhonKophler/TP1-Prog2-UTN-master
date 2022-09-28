/*Escribe un programa que ingrese un número entero positivo N y luego N números enteros
e imprima la suma de los números que se encuentran entre el mayor de los N números 
leídos y el menor de los N números leídos.*/

public class HelloWorld
{
    public static int ingresarNumero()
    {
        Console.WriteLine("Ingrese numero");
        int num = Convert.ToInt32(Console.ReadLine());
        return num;
    }

    public static int[] llenarVector(int cantidad)
    {
        int[] vectorLocal = new int[cantidad];
        for (int i = 0; i < cantidad; i++)
        {
            vectorLocal[i] = ingresarNumero();
        }
        return vectorLocal;
    }

    public static void sumarInternos(int[] n)
    {
        int sumaTotal = 0;
        Array.Sort(n);
        for (int i = 1; i < n.Length - 1; i++)
        {
            sumaTotal += n[i];
        }

        Console.WriteLine("LOS NUMEROS EXCLUIDOS SON:");
        Console.WriteLine("EL MENOR DE TODOS: {0} \nY EL MAYOR DE TODOS: {1}", n[0], n[n.Length - 1]);
        Console.WriteLine("LA SUMA DEL RESTO DE LOS INTERNOS ES: " + sumaTotal);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("INGRESE UN NUMERO PARA CREAR UNA LISTA CON ESA CANTIDAD: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] vectorCompleto = llenarVector(n);

        Console.WriteLine("VALORES DENTRO DEL ARRAY");

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i + ") " + vectorCompleto[i - 1]);
        }

        sumarInternos(vectorCompleto);

    }
}